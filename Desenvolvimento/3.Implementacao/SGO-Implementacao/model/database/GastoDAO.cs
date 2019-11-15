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
     * Classe com funções para manipular gastos no banco de dados
     *
     */
    public class GastoDAO
    {
        // Cadastrar novo gasto no banco de dados
        public bool cadastrar(Gasto objGasto)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.transacao = Banco.conexao.BeginTransaction();
                db.comando.CommandText = "INSERT INTO gasto (descricao, tipo, valor, dataGasto, obra_codigo, etapa_codigo) " +
                                         "VALUES (@de, @t, @v, @da, @oc, @ec)";
                db.comando.Parameters.Add("@de", MySqlDbType.VarChar).Value = objGasto.getDescricao();
                db.comando.Parameters.Add("@t", MySqlDbType.VarChar).Value = objGasto.getTipo();
                db.comando.Parameters.Add("@v", MySqlDbType.Double).Value = objGasto.getValor();
                db.comando.Parameters.Add("@da", MySqlDbType.DateTime).Value = objGasto.getData();
                db.comando.Parameters.Add("@oc", MySqlDbType.Int32).Value = objGasto.getObraCodigo();
                db.comando.Parameters.Add("@ec", MySqlDbType.Int32).Value = objGasto.getEtapaCodigo();
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
                db.transacao.Commit();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Cadastrar o Gasto na Base de Dados: " + ex.Message);
            }
        }
        // Alterar gasto no banco de dados
        public void alterar(Gasto objGasto)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "UPDATE gasto SET descricao = @de, tipo = @t, valor = @v, dataGasto = @da " +
                                         "WHERE codigo = @c AND obra_codigo = @oc AND etapa_codigo = @ec";
                db.comando.Parameters.Add("@de", MySqlDbType.VarChar).Value = objGasto.getDescricao();
                db.comando.Parameters.Add("t", MySqlDbType.VarChar).Value = objGasto.getTipo();
                db.comando.Parameters.Add("@v", MySqlDbType.Double).Value = objGasto.getValor();
                db.comando.Parameters.Add("@da", MySqlDbType.DateTime).Value = objGasto.getData();
                db.comando.Parameters.Add("@oc", MySqlDbType.Int32).Value = objGasto.getObraCodigo();
                db.comando.Parameters.Add("@ec", MySqlDbType.Int32).Value = objGasto.getEtapaCodigo();
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = objGasto.getCodigo();
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Alterar o Gasto na Base de Dados: " + ex.Message);
            }
        }
        // Remover gasto do banco de dados
        public void remover(int codigo)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "DELETE FROM gasto WHERE codigo = @c";
                db.comando.Parameters.Add("@c", MySqlDbType.Int32).Value = codigo;
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na Remoção do Gasto: " + ex.Message);
            }
        }
        // Listar todos os gastos de uma determinada obra
        public DataTable gastosObra(int codigoObra)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT g.descricao, g.tipo, g.valor, g.dataGasto " +
                                         "FROM gasto g INNER JOIN obra o ON g.obra_codigo = o.codigo " +
                                         "WHERE g.obra_codigo = @co";
                db.comando.Parameters.Add("@co", MySqlDbType.Int32).Value = codigoObra;
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Consultar os Gastos na Base de Dados: " + ex.Message);
            }
        }
        // Listar todos os gastos de uma determinada etapa em uma determinada obra
        public DataTable gastosEtapa(int codigoObra, int codigoEtapa)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT g.codigo, g.descricao, g.tipo, g.valor, g.dataGasto, g.obra_codigo, g.etapa_codigo " +
                                         "FROM gasto g INNER JOIN obra o ON g.obra_codigo = o.codigo INNER JOIN etapa e ON g.etapa_codigo = e.codigo " +
                                         "WHERE g.obra_codigo = @co AND g.etapa_codigo = @ce";
                db.comando.Parameters.Add("@co", MySqlDbType.Int32).Value = codigoObra;
                db.comando.Parameters.Add("@ce", MySqlDbType.Int32).Value = codigoEtapa;
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Consultar os Gastos na Base de Dados: " + ex.Message);
            }
        }
        // Filtrar os gastos da obra de acordo com os filtros escolhidos pelo usuário
        public DataTable filtrar(Gasto objGasto, DateTime dataInicio, DateTime dataFim)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT g.codigo, g.descricao, g.tipo, g.valor, g.dataGasto, g.obra_codigo, g.etapa_codigo " +
                                         "FROM gasto g INNER JOIN obra o ON g.obra_codigo = o.codigo " +
                                         "WHERE g.dataGasto BETWEEN @di AND @df AND g.obra_codigo = @oc";
                db.comando.Parameters.Add("@di", MySqlDbType.DateTime).Value = dataInicio;
                db.comando.Parameters.Add("@df", MySqlDbType.DateTime).Value = dataFim;
                db.comando.Parameters.Add("@oc", MySqlDbType.Int32).Value = objGasto.getObraCodigo();
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Consultar os Gastos na Base de Dados: " + ex.Message);
            }
        }
        // Gráfico de gastos por etapa
        public DataTable gastosEtapas()
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT e.nome, SUM(g.valor) " +
                                         "FROM gasto g INNER JOIN etapa e ON g.etapa_codigo = e.codigo " +
                                         "GROUP BY e.codigo";
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Gerar Gráfico: " + ex.Message);
            }
        }
        // Gráfico de gastos por tipo
        public DataTable gastosTipo()
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT tipo, SUM(valor) " +
                                         "FROM gasto " +
                                         "GROUP BY tipo";
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Gerar Gráfico: " + ex.Message);
            }
        }
        // Gráfico de gastos por mês
        public DataTable gastosMes()
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT MONTH(g.dataGasto), SUM(g.valor) " +
                                         "FROM gasto g INNER JOIN etapa e ON g.etapa_codigo = e.codigo " +
                                         "GROUP BY MONTH(g.dataGasto)";
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Gerar Gráfico: " + ex.Message);
            }
        }
        // Gráfico com um comparativo entre gastos previstos e realizados
        public DataTable comparativoGastos()
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT SUM(valor), SUM(totalGastosPrevisto) " +
                                         "FROM gasto g INNER JOIN etapa e ON e.codigo = g.etapa_codigo INNER JOIN obra o ON o.codigo = g.obra_codigo";
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Gerar Gráfico: " + ex.Message);
            }
        }
        // Gráfico com um comparativo entre prazos previstos e realizados
        public DataTable comparativoPrazos()
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT DATEDIFF(dataFimPrevisto, dataInicioPrevisto), " +
                                         "CONCAT(dataInicioPrevisto, ' - ', dataFimPrevisto) AS 'Prazo Previsto', " +
                                         "DATEDIFF(dataFimReal, dataInicioReal), CONCAT(dataInicioReal, ' - ', dataFimReal) AS 'Prazo Real'" +
                                         "FROM etapa e INNER JOIN obra o ON o.codigo = e.obra_codigo " +
                                         "GROUP BY e.codigo";
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Gerar Gráfico: " + ex.Message);
            }
        }
    }
}