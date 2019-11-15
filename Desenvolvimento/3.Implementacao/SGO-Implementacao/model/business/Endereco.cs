using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.model.business
{
    public class Endereco
    {
        #region Atributos
        private int codigo;
        private string cep;
        private string rua;
        private int numero;
        private string bairro;
        private string cidade;
        private string uf;
        #endregion

        #region Getters
        public int getCodigo()
        {
            return this.codigo;
        }
        public string getCEP()
        {
            return this.cep;
        }
        public string getRua()
        {
            return this.rua;
        }
        public int getNumero()
        {
            return this.numero;
        }
        public string getBairro()
        {
            return this.bairro;
        }
        public string getCidade()
        {
            return this.cidade;
        }
        public string getUF()
        {
            return this.uf;
        }
        #endregion

        #region Setters
        public bool setCodigo(string cod)
        {
            int codigo;
            try
            {
                codigo = Convert.ToInt32(cod);
                this.codigo = codigo;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void setCEP(string cep)
        {
            this.cep = cep;
        }
        public void setRua(string rua)
        {
            this.rua = rua;
        }
        public bool setNumero(string num)
        {
            int numero;
            try
            {
                numero = Convert.ToInt32(num);
                this.numero = numero;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public void setUF(string uf)
        {
            this.uf = uf;
        }
        #endregion
    }
}