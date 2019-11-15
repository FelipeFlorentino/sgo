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
     * Classe com funções para manipular imagens no banco de dados
     *
     */
    public class ImagemDAO
    {
        // Cadastrar imagem no banco de dados
        public void gravar(Imagem objImagem)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "INSERT INTO imagem VALUES (@d, @i, @dt, @ec)";
                db.comando.Parameters.Add("@d", MySqlDbType.VarChar).Value = objImagem.getDescricao();
                db.comando.Parameters.Add("@i", MySqlDbType.MediumBlob).Value = objImagem.getImagem();
                db.comando.Parameters.Add("@dt", MySqlDbType.DateTime).Value = objImagem.getData();
                db.comando.Parameters.Add("@ec", MySqlDbType.Int32).Value = objImagem.getEtapaCodigo();
                db.comando.Prepare();
                db.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Cadastrar a Obra na Base de Dados: " + ex.Message);
            }
        }
        // Listar as imagens cadastradas no banco de dados
        public DataTable consultar(int codigo)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT * FROM imagem WHERE etapa_codigo = @ec";
                db.comando.Parameters.Add("@ec", MySqlDbType.Int32).Value = codigo;
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                db.tabela = new DataTable();
                db.tabela.Load(db.dreader);
                return (db.tabela);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Consultar as Imagens na Base de Dados: " + ex.Message);
            }
        }
    }
}