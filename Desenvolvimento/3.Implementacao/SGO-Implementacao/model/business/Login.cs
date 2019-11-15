using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.model.business
{
    public class Login
    {
        #region Atributos
        private string login;
        private string senha;
        #endregion

        #region Getters
        public string getLogin()
        {
            return this.login;
        }
        public string getSenha()
        {
            return this.senha;
        }
        #endregion

        #region Setters
        public bool setLogin(string login)
        {
            try
            {
                this.login = login;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setSenha(string senha)
        {
            try
            {
                this.senha = senha;
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}