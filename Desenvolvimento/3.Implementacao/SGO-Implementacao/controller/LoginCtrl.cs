using sgo.model.business;
using sgo.model.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.controller
{
    public class LoginCtrl
    {
        public bool logar(Login objLogin)
        {
            LoginDAO objLoginDAO = new LoginDAO();
            try
            {
                bool resultado = objLoginDAO.logar(objLogin);
                if (resultado)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}