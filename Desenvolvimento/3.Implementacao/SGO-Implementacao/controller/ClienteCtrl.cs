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
    public class ClienteCtrl
    {
        public bool cadastrar(Cliente objCliente)
        {
            ClienteDAO objClienteDAO;
            try
            {
                objClienteDAO = new ClienteDAO();
                objClienteDAO.cadastrar(objCliente);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool alterar(Cliente objCliente)
        {
            ClienteDAO objClienteDAO;
            try
            {
                objClienteDAO = new ClienteDAO();
                objClienteDAO.alterar(objCliente);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool remover(int codigo)
        {
            ClienteDAO objClienteDAO;
            try
            {
                objClienteDAO = new ClienteDAO();
                objClienteDAO.remover(codigo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable consultar(string nome)
        {
            ClienteDAO objClienteDAO;
            try
            {
                objClienteDAO = new ClienteDAO();
                return (objClienteDAO.consultar(nome));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}