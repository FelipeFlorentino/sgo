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
     * Classe com funções para manipular obras no banco de dados
     *
     */
    public class ObraDAO
    {
        // Cadastrar nova obra no banco de dados
        public int cadastrar(Obra objObra)
        {
            Banco db;
            int endereco_codigo;
            int obra_codigo;
            try
            {
                db = new Banco();
                db.transacao = Banco.conexao.BeginTransaction();
                db.comando.CommandText = "INSERT INTO endereco (cep, rua, numero, bairro, cidade, uf) VALUES (@ce, @ru, @nu, @ba, @ci, @uf)";
                db.comando.Parameters.Add("@ce", MySqlDbType.VarChar).Value = objObra.getEndereco().getCEP();
                db.comando.Parameters.Add("@ru", MySqlDbType.VarChar).Value = objObra.getEndereco().getRua();
                db.comando.Parameters.Add("@nu", MySqlDbType.Int32).Value = objObra.getEndereco().getNumero();
                db.comando.Parameters.Add("@ba", MySqlDbType.VarChar).Value = objObra.getEndereco().getBairro();
                db.comando.Parameters.Add("@ci", MySqlDbType.VarChar).Value = objObra.getEndereco().getCidade();
                db.comando.Parameters.Add("@uf", MySqlDbType.VarChar).Value = objObra.getEndereco().getUF();
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
                if (db.comando.LastInsertedId != 0)
                {
                    db.comando.Parameters.Add(new MySqlParameter("codigo", db.comando.LastInsertedId));
                }
                endereco_codigo = Convert.ToInt32(db.comando.Parameters["@codigo"].Value);
                try
                {
                    db.comando.CommandText = "INSERT INTO obra(status, endereco_codigo, cliente_nome) VALUES(@s, @ec, @n)";
                    db.comando.Parameters.Add("@s", MySqlDbType.VarChar).Value = "Não Iniciada";
                    db.comando.Parameters.Add("@ec", MySqlDbType.Int32).Value = endereco_codigo;
                    db.comando.Parameters.Add("@n", MySqlDbType.VarChar).Value = objObra.getClienteNome();
                    db.comando.Prepare();
                    db.comando.ExecuteNonQuery();
                    if (db.comando.LastInsertedId != 0)
                    {
                        db.comando.Parameters.Add(new MySqlParameter("obraCodigo", db.comando.LastInsertedId));
                    }
                    obra_codigo = Convert.ToInt32(db.comando.Parameters["@obraCodigo"].Value);
                    db.transacao.Commit();
                    return obra_codigo;
                }
                catch (Exception ex)
                {
                    db.transacao.Rollback();
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Cadastrar a Obra na Base de Dados: " + ex.Message);
            }
        }
        // Alterar status e data de início da obra
        public void iniciar(DateTime data, int codigo)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "UPDATE obra SET dataInicio = @di, status = 'Em Andamento' WHERE codigo = @c";
                db.comando.Parameters.Add("@di", MySqlDbType.Date).Value = data;
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = codigo;
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Iniciar a Obra: " + ex.Message);
            }
        }
        // Alterar status e data de finalização da obra
        public void finalizar(DateTime data, int codigo)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "UPDATE obra SET dataFim = @df, status = 'Finalizada' WHERE codigo = @c";
                db.comando.Parameters.Add("@df", MySqlDbType.Date).Value = data;
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = codigo;
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Finalizar a Obra: " + ex.Message);
            }
        }
        // Listar as obras cadastradas no banco de dados
        public DataTable consultar(string status)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT o.codigo, o.status, o.dataInicio, o.dataFim, CONCAT(c.nome), " +
                    "CONCAT(e.rua, ', ', e.numero, ', ', e.bairro, ', ', e.cidade, '-', e.uf) FROM obra o INNER JOIN cliente c " +
                    "ON o.cliente_nome = c.nome INNER JOIN endereco e ON o.endereco_codigo = e.codigo WHERE o.status LIKE @s ORDER BY o.dataInicio DESC";
                db.comando.Parameters.Add("@s", MySqlDbType.VarChar).Value = "%" + status + "%";
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Consultar as Obras na Base de Dados: " + ex.Message);
            }
        }
        public string verificarStatus(int obraCodigo)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT status FROM obra WHERE codigo = @oc";
                db.comando.Parameters.Add("@oc", MySqlDbType.Int32).Value = obraCodigo;
                db.comando.Prepare();   
                Object retorno = db.comando.ExecuteScalar();
                return retorno.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Consultar as Obras na Base de Dados: " + ex.Message);
            }
        }
    }
}