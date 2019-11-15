using MySql.Data.MySqlClient;
using sgo.model.business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.model.database
{
    /**
     * Classe com funções para manipular funcionários no banco de dados
     *
     */
    public class FuncionarioDAO
    {
        // Cadastrar funcionário no banco de dados
        public bool cadastrar(Funcionario objFuncionario)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.transacao = Banco.conexao.BeginTransaction();
                db.comando.CommandText = "INSERT INTO endereco (cep, rua, numero, bairro, cidade, uf) VALUES (@ce, @ru, @nu, @ba, @ci, @uf)";
                db.comando.Parameters.Add("@ce", MySqlDbType.VarChar).Value = objFuncionario.getEndereco().getCEP();
                db.comando.Parameters.Add("@ru", MySqlDbType.VarChar).Value = objFuncionario.getEndereco().getRua();
                db.comando.Parameters.Add("@nu", MySqlDbType.Int32).Value = objFuncionario.getEndereco().getNumero();
                db.comando.Parameters.Add("@ba", MySqlDbType.VarChar).Value = objFuncionario.getEndereco().getBairro();
                db.comando.Parameters.Add("@ci", MySqlDbType.VarChar).Value = objFuncionario.getEndereco().getCidade();
                db.comando.Parameters.Add("@uf", MySqlDbType.VarChar).Value = objFuncionario.getEndereco().getUF();
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
                db.comando.CommandText = "SELECT codigo FROM endereco WHERE cep = @ce AND rua = @ru AND numero = @nu";
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                if (db.dreader.Read())
                {
                    int enderecoCodigo = (int)db.dreader[0];
                    db.dreader.Close();
                    try
                    {
                        db.comando.CommandText = "INSERT INTO funcionario (cpf, nome, email, telefone, salario, funcao," +
                            "endereco_codigo, obra_codigo) " +
                            "VALUES (@cp, @no, @em, @te, @sa, @fu, @ec, @oc)";
                        db.comando.Parameters.Add("@cp", MySqlDbType.VarChar).Value = objFuncionario.getCPF();
                        db.comando.Parameters.Add("@no", MySqlDbType.VarChar).Value = objFuncionario.getNome();
                        db.comando.Parameters.Add("@em", MySqlDbType.VarChar).Value = objFuncionario.getEmail();
                        db.comando.Parameters.Add("@te", MySqlDbType.VarChar).Value = objFuncionario.getTelefone();
                        db.comando.Parameters.Add("@sa", MySqlDbType.Float).Value = objFuncionario.getSalario();
                        db.comando.Parameters.Add("@fu", MySqlDbType.VarChar).Value = objFuncionario.getFuncao();
                        db.comando.Parameters.Add("@oc", MySqlDbType.Int32).Value = objFuncionario.getObraCodigo();
                        db.comando.Parameters.Add("@ec", MySqlDbType.Int32).Value = enderecoCodigo;
                        db.comando.Prepare();
                        db.comando.ExecuteNonQuery();
                        db.transacao.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        db.transacao.Rollback();
                        throw new Exception("Erro ao Cadastrar o Funcionario na Base de Dados: " + ex.Message);
                    }
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Cadastrar o Endereço do Funcionario na Base de Dados: " + ex.Message);
            }
        }
        // Alterar funcionário no banco de dados
        public void alterar(Funcionario objFuncionario)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "UPDATE funcionario f INNER JOIN endereco e ON e.codigo = f.endereco_codigo " +
                    "INNER JOIN obra o ON f.obra_codigo = o.codigo SET f.cpf = @cp, f.nome = @n, f.email = @e, " +
                    "f.telefone = @t, f.salario = @s, f.funcao = @fu," +
                    "e.cep = @ce, e.rua = @ru, e.numero = @nu, e.bairro = @ba, e.cidade = @ci, e.uf = @uf WHERE f.cpf = @cp";
                db.comando.Parameters.Add("@cp", MySqlDbType.VarChar).Value = objFuncionario.getCPF();
                db.comando.Parameters.Add("@n", MySqlDbType.VarChar).Value = objFuncionario.getNome();
                db.comando.Parameters.Add("@e", MySqlDbType.VarChar).Value = objFuncionario.getEmail();
                db.comando.Parameters.Add("@t", MySqlDbType.VarChar).Value = objFuncionario.getTelefone();
                db.comando.Parameters.Add("@s", MySqlDbType.Double).Value = objFuncionario.getSalario();
                db.comando.Parameters.Add("@fu", MySqlDbType.VarChar).Value = objFuncionario.getFuncao();
                db.comando.Parameters.Add("@ce", MySqlDbType.VarChar).Value = objFuncionario.getEndereco().getCEP();
                db.comando.Parameters.Add("@ru", MySqlDbType.VarChar).Value = objFuncionario.getEndereco().getRua();
                db.comando.Parameters.Add("@nu", MySqlDbType.Int32).Value = objFuncionario.getEndereco().getNumero();
                db.comando.Parameters.Add("@ba", MySqlDbType.VarChar).Value = objFuncionario.getEndereco().getBairro();
                db.comando.Parameters.Add("@ci", MySqlDbType.VarChar).Value = objFuncionario.getEndereco().getCidade();
                db.comando.Parameters.Add("@uf", MySqlDbType.VarChar).Value = objFuncionario.getEndereco().getUF();
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Alterar o Funcionário na Base de Dados: " + ex.Message);
            }
        }
        // Remover funcionário do banco de dados
        public void remover(int codigo)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "DELETE FROM endereco WHERE codigo = @c";
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = codigo;
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na Remoção do Funcionario: " + ex.Message);
            }
        }
        // Consultar os funcionários cadastrados
        public DataTable consultar(string nome)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT f.cpf, f.nome, f.email, f.telefone, f.salario, f.funcao, e.codigo, e.cep, e.rua, " +
                    "e.numero, e.bairro, e.cidade, e.uf FROM funcionario f INNER JOIN endereco e " +
                    "ON f.endereco_codigo = e.codigo WHERE f.nome LIKE @n";
                db.comando.Parameters.Add("@n", MySqlDbType.VarChar).Value = "%" + nome + "%";
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Consultar os Funcionarios na Base de Dados: " + ex.Message);
            }
        }
    }
}