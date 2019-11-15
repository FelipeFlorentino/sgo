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
    public class ImagemCtrl
    {
        public bool gravar(Imagem objImagem)
        {
            ImagemDAO objImagemDAO;
            try
            {
                objImagemDAO = new ImagemDAO();
                objImagemDAO.gravar(objImagem);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable consultar(int codigo)
        {
            ImagemDAO objImagemDAO;
            try
            {
                objImagemDAO = new ImagemDAO();
                return (objImagemDAO.consultar(codigo));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}