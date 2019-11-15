using sgo.model.business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.controller
{
    public class EnderecoCtrl
    {
        public bool validar(Endereco objEndereco)
        {
            try
            {
                if ( (objEndereco.getCEP().Length > 0) && (objEndereco.getRua().Length > 0) && (objEndereco.getNumero() != 0) 
                    && (objEndereco.getBairro().Length > 0) && (objEndereco.getCidade().Length > 0) && (objEndereco.getUF().Length > 0) )
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
