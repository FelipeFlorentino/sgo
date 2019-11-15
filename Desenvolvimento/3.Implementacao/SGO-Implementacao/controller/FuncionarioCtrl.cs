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
    public class FuncionarioCtrl
    {
        public bool cadastrar(Funcionario objFuncionario)
        {
            FuncionarioDAO objFuncionarioDAO;
            try
            {
                objFuncionarioDAO = new FuncionarioDAO();
                objFuncionarioDAO.cadastrar(objFuncionario);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool alterar(Funcionario objFuncionario)
        {
            FuncionarioDAO objFuncionarioDAO;
            try
            {
                objFuncionarioDAO = new FuncionarioDAO();
                objFuncionarioDAO.alterar(objFuncionario);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool remover(int codigo)
        {
            FuncionarioDAO objFuncionarioDAO;
            try
            {
                objFuncionarioDAO = new FuncionarioDAO();
                objFuncionarioDAO.remover(codigo);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable consultar(string nome)
        {
            FuncionarioDAO objFuncionarioDAO;
            try
            {
                objFuncionarioDAO = new FuncionarioDAO();
                return (objFuncionarioDAO.consultar(nome));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}