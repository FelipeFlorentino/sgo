using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.model.database
{
    /**
     * Classe de conexão com o banco de dados
     *
     */
    public class Banco
    {
        public static MySqlConnection conexao;
        public MySqlCommand comando;
        public MySqlDataReader dreader;
        public DataTable tabela;
        public MySqlTransaction transacao;
        public Banco()
        {
            try
            {
                if ((conexao == null) || (conexao.State != ConnectionState.Open))
                {
                    conexao = new MySqlConnection("Server=127.0.0.1; Port=3306; User Id=root; Password=''; Database=sgo; SslMode=None");
                    conexao.Open();
                }
                comando = new MySqlCommand();
                comando.Connection = conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na Conexão com o Banco de Dados: " + ex.Message);
            }
        }
    }
}