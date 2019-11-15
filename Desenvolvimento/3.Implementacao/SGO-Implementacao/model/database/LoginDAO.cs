using MySql.Data.MySqlClient;
using sgo.model.business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.model.database
{
    public class LoginDAO
    {
        // Consulta o login e a senha no banco para verificar se o usuário está apto a usar o sistema
        public bool logar(Login objLogin)
        {
            Banco db;
            try
            {
                db = new Banco();
                db.comando.CommandText = "SELECT * FROM usuario WHERE login = @l AND senha = @s";
                db.comando.Parameters.Add("@l", MySqlDbType.VarChar).Value = objLogin.getLogin();
                db.comando.Parameters.Add("@s", MySqlDbType.VarChar).Value = objLogin.getSenha();
                db.comando.Prepare();
                db.dreader = db.comando.ExecuteReader();
                if (db.dreader.Read())
                {
                    db.comando.Connection.Close();
                    return true;
                }
                else
                {
                    db.comando.Connection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Efetuar Login: " + ex.Message);
            }
        }
    }
}