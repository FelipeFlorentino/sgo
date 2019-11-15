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
     * Classe com funções para manipular etapas no banco de dados
     *
     */
    public class EtapaDAO
    {
        // Cadastrar etapa no banco de dados
        public void cadastrar(Etapa objEtapa)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "INSERT INTO etapa (nome, percentualConclusao, totalGastosPrevisto, dataInicioPrevisto, dataFimPrevisto, obra_codigo) " +
                    "VALUES (@n, @p, @g, @di, @df, @c)";
                db.comando.Parameters.Add("@n", MySqlDbType.VarChar).Value = objEtapa.getNome();
                db.comando.Parameters.Add("@p", MySqlDbType.Int32).Value = 0;
                db.comando.Parameters.Add("@g", MySqlDbType.Double).Value = objEtapa.getTotalGastosPrevisto();
                db.comando.Parameters.Add("@di", MySqlDbType.Date).Value = objEtapa.getDataInicioPrevisto();
                db.comando.Parameters.Add("@df", MySqlDbType.Date).Value = objEtapa.getDataFimPrevisto();
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = objEtapa.getObraCodigo();
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Inserir a Etapa na Base de Dados: " + ex.Message);
            }
        }
        // Alterar etapa no banco de dados
        public void alterar(Etapa objEtapa)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "UPDATE etapa SET totalGastosPrevisto = @gp, dataInicioPrevisto = @dIP," +
                    "dataFimPrevisto = @dFP WHERE codigo = @c AND obra_codigo = @oc";
                db.comando.Parameters.Add("@gp", MySqlDbType.Double).Value = objEtapa.getTotalGastosPrevisto();
                db.comando.Parameters.Add("@dIP", MySqlDbType.DateTime).Value = objEtapa.getDataInicioPrevisto();
                db.comando.Parameters.Add("@dFP", MySqlDbType.DateTime).Value = objEtapa.getDataFimPrevisto();
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = objEtapa.getCodigo();
                db.comando.Parameters.Add("@oc", MySqlDbType.Int32).Value = objEtapa.getObraCodigo();
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na Atualização da Etapa: " + ex.Message);
            }
        }
        // Remover etapa do banco de dados
        public void remover(int codigoEtapa, int codigoObra)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "DELETE FROM etapa WHERE codigo = @c AND obra_codigo = @oc";
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = codigoEtapa;
                db.comando.Parameters.Add("@oc", MySqlDbType.Int32).Value = codigoObra;
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na Atualização da Etapa: " + ex.Message);
            }
        }
        // Atualizar informações de uma etapa em andamento
        public void atualizar(Etapa objEtapa)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "UPDATE etapa SET percentualConclusao = @pc, dataInicioReal = @dIR," +
                    "dataFimReal = @dFR WHERE codigo = @c";
                db.comando.Parameters.Add("@pc", MySqlDbType.Int32).Value = objEtapa.getPercentualConclusao();
                db.comando.Parameters.Add("@dIR", MySqlDbType.DateTime).Value = objEtapa.getDataInicioReal();
                db.comando.Parameters.Add("@dFR", MySqlDbType.DateTime).Value = objEtapa.getDataFimReal();
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = objEtapa.getCodigo();
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na Atualização da Etapa: " + ex.Message);
            }
        }
        // Finalizar etapa em andamento
        public void finalizar(int codigo)
        {
            Banco db;
            DateTime dataAtual;
            try
            {
                dataAtual = DateTime.Now;
                db = new Banco();
                db.comando.CommandText = "Update etapa SET percentualConclusao = 100, dataFimReal = @dFR WHERE codigo = @c";
                db.comando.Parameters.Add("@dFR", MySqlDbType.DateTime).Value = dataAtual;
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = codigo;
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na Finalização da Etapa: " + ex.Message);
            }
        }
        // Listar todas as etapas previstas e suas respectivas informações
        public DataTable previsto(int codigo)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT nome, dataInicioPrevisto, dataFimPrevisto, DATEDIFF(dataFimPrevisto, dataInicioPrevisto) FROM etapa " +
                    "WHERE obra_codigo = @c";
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = codigo;
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Consultar as Etapas na Base de Dados: " + ex.Message);
            }
        }
        // Listar todas as etapas realizadas e suas respectivas informações
        public DataTable realizado(int codigo)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT e.codigo, e.nome, e.percentualConclusao, e.dataInicioReal, e.dataFimReal FROM etapa e " +
                    "INNER JOIN obra o ON e.obra_codigo = @c";
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = codigo;
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Consultar as Etapas: " + ex.Message);
            }
        }
        // Listar todas as etapas de uma determinada obra
        public DataTable listar(int codigo)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT e.codigo, e.nome, e.totalGastosPrevisto, e.dataInicioPrevisto, e.dataFimPrevisto FROM etapa e " +
                    "INNER JOIN obra o ON e.obra_codigo = @c WHERE o.status != 'Finalizada'";
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = codigo;
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Listar as Etapas: " + ex.Message);
            }
        }
    }
}