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
     * Classe com funções para manipular clientes no banco de dados
     *
     */
    public class ClienteDAO
    {
        // Cadastrar novo cliente no banco de dados
        public bool cadastrar(Cliente objCliente)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.transacao = Banco.conexao.BeginTransaction();
                db.comando.CommandText = "INSERT INTO endereco (cep, rua, numero, bairro, cidade, uf) VALUES (@ce, @ru, @nu, @ba, @ci, @uf)";
                db.comando.Parameters.Add("@ce", MySqlDbType.VarChar).Value = objCliente.getEndereco().getCEP();
                db.comando.Parameters.Add("@ru", MySqlDbType.VarChar).Value = objCliente.getEndereco().getRua();
                db.comando.Parameters.Add("@nu", MySqlDbType.Int32).Value = objCliente.getEndereco().getNumero();
                db.comando.Parameters.Add("@ba", MySqlDbType.VarChar).Value = objCliente.getEndereco().getBairro();
                db.comando.Parameters.Add("@ci", MySqlDbType.VarChar).Value = objCliente.getEndereco().getCidade();
                db.comando.Parameters.Add("@uf", MySqlDbType.VarChar).Value = objCliente.getEndereco().getUF();
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
                        db.comando.CommandText = "INSERT INTO cliente (cpf, nome, email, telefone, endereco_codigo) " +
                            "VALUES (@cp, @no, @em, @te, @ec)";
                        db.comando.Parameters.Add("@cp", MySqlDbType.VarChar).Value = objCliente.getCPF();
                        db.comando.Parameters.Add("@no", MySqlDbType.VarChar).Value = objCliente.getNome();
                        db.comando.Parameters.Add("@em", MySqlDbType.VarChar).Value = objCliente.getEmail();
                        db.comando.Parameters.Add("@te", MySqlDbType.VarChar).Value = objCliente.getTelefone();
                        db.comando.Parameters.Add("@ec", MySqlDbType.Int32).Value = enderecoCodigo;
                        db.comando.Prepare();
                        db.comando.ExecuteNonQuery();
                        db.transacao.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        db.transacao.Rollback();
                        throw new Exception(ex.Message);
                    }
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Cadastrar o Cliente na Base de Dados: " + ex.Message);
            }
        }
        // Alterar cliente no banco de dados
        public void alterar(Cliente objCliente)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "UPDATE cliente c INNER JOIN endereco e ON e.codigo = c.endereco_codigo SET " +
                    "c.cpf = @cp, c.nome = @n, c.email = @e, c.telefone = @t, " +
                    "e.cep = @ce, e.rua = @ru, e.numero = @nu, e.bairro = @ba, e.cidade = @ci, e.uf = @uf WHERE c.cpf = @cp";
                db.comando.Parameters.Add("@cp", MySqlDbType.VarChar).Value = objCliente.getCPF();
                db.comando.Parameters.Add("@n", MySqlDbType.VarChar).Value = objCliente.getNome();
                db.comando.Parameters.Add("@e", MySqlDbType.VarChar).Value = objCliente.getEmail();
                db.comando.Parameters.Add("@t", MySqlDbType.VarChar).Value = objCliente.getTelefone();
                db.comando.Parameters.Add("@ce", MySqlDbType.VarChar).Value = objCliente.getEndereco().getCEP();
                db.comando.Parameters.Add("@ru", MySqlDbType.VarChar).Value = objCliente.getEndereco().getRua();
                db.comando.Parameters.Add("@nu", MySqlDbType.Int32).Value = objCliente.getEndereco().getNumero();
                db.comando.Parameters.Add("@ba", MySqlDbType.VarChar).Value = objCliente.getEndereco().getBairro();
                db.comando.Parameters.Add("@ci", MySqlDbType.VarChar).Value = objCliente.getEndereco().getCidade();
                db.comando.Parameters.Add("@uf", MySqlDbType.VarChar).Value = objCliente.getEndereco().getUF();
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Alterar o Cliente na Base de Dados: " + ex.Message);
            }
        }
        // Remover cliente do banco de dados
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
                throw new Exception("Erro na Remoção do Cliente: " + ex.Message);
            }
        }
        // Consultar os clientes cadastrados
        public DataTable consultar(string nome)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT c.cpf, c.nome, c.email, c.telefone, e.codigo, e.cep, e.rua, e.numero, e.bairro, e.cidade, e.uf " +
                                         "FROM cliente c INNER JOIN endereco e ON c.endereco_codigo = e.codigo " +
                                         "WHERE c.nome LIKE @n";
                db.comando.Parameters.Add("@n", MySqlDbType.VarChar).Value = "%" + nome + "%";
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Consultar os Clientes na Base de Dados: " + ex.Message);
            }
        }
    }
}