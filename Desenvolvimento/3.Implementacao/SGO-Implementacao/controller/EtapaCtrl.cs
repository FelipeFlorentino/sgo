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
    public class EtapaCtrl
    {
        public bool cadastrar(Etapa objEtapa)
        {
            EtapaDAO objEtapaDAO = new EtapaDAO();
            try
            {
                objEtapaDAO.cadastrar(objEtapa);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool alterar(Etapa objEtapa)
        {
            EtapaDAO objEtapaDAO = new EtapaDAO();
            try
            {
                objEtapaDAO.alterar(objEtapa);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool remover(int codigoEtapa, int codigoObra)
        {
            EtapaDAO objEtapaDAO = new EtapaDAO();
            try
            {
                objEtapaDAO.remover(codigoEtapa, codigoObra);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool atualizar(Etapa objEtapa)
        {
            EtapaDAO objEtapaDAO = new EtapaDAO();
            try
            {
                objEtapaDAO.atualizar(objEtapa);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool finalizar(int codigo)
        {
            EtapaDAO objEtapaDAO = new EtapaDAO();
            try
            {
                objEtapaDAO.finalizar(codigo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable previsto(int codigo)
        {
            EtapaDAO objEtapaDAO;
            try
            {
                objEtapaDAO = new EtapaDAO();
                return (objEtapaDAO.previsto(codigo));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable realizado(int codigo)
        {
            EtapaDAO objEtapaDAO;
            try
            {
                objEtapaDAO = new EtapaDAO();
                return (objEtapaDAO.realizado(codigo));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable listar(int codigo)
        {
            EtapaDAO objEtapaDAO;
            try
            {
                objEtapaDAO = new EtapaDAO();
                return (objEtapaDAO.listar(codigo));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}