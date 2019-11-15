using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.model.business
{
    public class Imagem
    {
        #region Atributos
        private string descricao;
        private Byte[] imagem;
        private DateTime data;
        private int etapaCodigo;
        #endregion

        #region Getters
        public string getDescricao()
        {
            return this.descricao;
        }
        public Byte[] getImagem()
        {
            return this.imagem;
        }
        public DateTime getData()
        {
            return this.data;
        }
        public int getEtapaCodigo()
        {
            return this.etapaCodigo;
        }
        #endregion

        #region Setters
        public bool setDescricao(string descricao)
        {
            try
            {
                this.descricao = descricao;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setImagem(Byte[] imagem)
        {
            try
            {
                this.imagem = imagem;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setData(string date)
        {
            DateTime data = Convert.ToDateTime(date);
            try
            {
                this.data = data;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setEtapaCodigo(string cod)
        {
            int codigo = Convert.ToInt32(cod);
            try
            {
                this.etapaCodigo = codigo;
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