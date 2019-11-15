using sgo.model.business;
using sgo.model.database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.controller
{
    public class ObraCtrl
    {
        public int cadastrar(Obra objObra)
        {
            ObraDAO objObraDAO;
            try
            {
                objObraDAO = new ObraDAO();
                return (objObraDAO.cadastrar(objObra));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool iniciar(DateTime data, int codigo)
        {
            ObraDAO objObraDAO;
            try
            {
                objObraDAO = new ObraDAO();
                objObraDAO.iniciar(data, codigo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool finalizar(DateTime data, int codigo)
        {
            ObraDAO objObraDAO;
            try
            {
                objObraDAO = new ObraDAO();
                objObraDAO.finalizar(data, codigo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable consultar(string status)
        {
            ObraDAO objObraDAO;
            try
            {
                objObraDAO = new ObraDAO();
                return (objObraDAO.consultar(status));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string verificarStatus(int obraCodigo)
        {
            ObraDAO objObraDAO;
            try
            {
                objObraDAO = new ObraDAO();
                return (objObraDAO.verificarStatus(obraCodigo));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}