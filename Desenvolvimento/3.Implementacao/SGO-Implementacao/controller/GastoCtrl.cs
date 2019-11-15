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
    public class GastoCtrl
    {
        public bool cadastrar(Gasto objGasto)
        {
            GastoDAO objGastoDAO;
            try
            {
                objGastoDAO = new GastoDAO();
                objGastoDAO.cadastrar(objGasto);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool alterar(Gasto objGasto)
        {
            GastoDAO objGastoDAO;
            try
            {
                objGastoDAO = new GastoDAO();
                objGastoDAO.alterar(objGasto);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool remover(int codigo)
        {
            GastoDAO objGastoDAO;
            try
            {
                objGastoDAO = new GastoDAO();
                objGastoDAO.remover(codigo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable gastosObra(int codigoObra)
        {
            GastoDAO objGastoDAO;
            try
            {
                objGastoDAO = new GastoDAO();
                return (objGastoDAO.gastosObra(codigoObra));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable gastosEtapa(int codigoObra, int codigoEtapa)
        {
            GastoDAO objGastoDAO;
            try
            {
                objGastoDAO = new GastoDAO();
                return (objGastoDAO.gastosEtapa(codigoObra, codigoEtapa));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable filtrar(Gasto objGasto, DateTime dataInicio, DateTime dataFim)
        {
            GastoDAO objGastoDAO;
            try
            {
                objGastoDAO = new GastoDAO();
                return (objGastoDAO.filtrar(objGasto, dataInicio, dataFim));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable gastosEtapas()
        {
            GastoDAO objGastoDAO;
            try
            {
                objGastoDAO = new GastoDAO();
                return (objGastoDAO.gastosEtapas());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable gastosTipo()
        {
            GastoDAO objGastoDAO;
            try
            {
                objGastoDAO = new GastoDAO();
                return (objGastoDAO.gastosTipo());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable gastosMes()
        {
            GastoDAO objGastoDAO;
            try
            {
                objGastoDAO = new GastoDAO();
                return (objGastoDAO.gastosMes());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable comparativoGastos()
        {
            GastoDAO objGastoDAO;
            try
            {
                objGastoDAO = new GastoDAO();
                return (objGastoDAO.comparativoGastos());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable comparativoPrazos()
        {
            GastoDAO objGastoDAO;
            try
            {
                objGastoDAO = new GastoDAO();
                return (objGastoDAO.comparativoPrazos());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}