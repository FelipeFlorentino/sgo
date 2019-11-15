using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.model.business
{
    public class Gasto
    {
        #region Atributos
        private int codigo;
        private string descricao;
        private string tipo;
        private double valor;
        private DateTime data;
        private int obraCodigo;
        private int etapaCodigo;
        #endregion

        #region Getters
        public int getCodigo()
        {
            return this.codigo;
        }
        public string getDescricao()
        {
            return this.descricao;
        }
        public string getTipo()
        {
            return this.tipo;
        }
        public double getValor()
        {
            return this.valor;
        }
        public DateTime getData()
        {
            return this.data;
        }
        public int getObraCodigo()
        {
            return this.obraCodigo;
        }
        public int getEtapaCodigo()
        {
            return this.etapaCodigo;
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
        public bool setTipo(string tipo)
        {
            try
            {
                this.tipo = tipo;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setValor(string val)
        {
            double valor;
            try
            {
                valor = Convert.ToDouble(val);
                this.valor = valor;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setData(string date)
        {
            DateTime data;
            try
            {
                data = Convert.ToDateTime(date);
                this.data = data;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setObraCodigo(string cod)
        {
            int codigo;
            try
            {
                codigo = Convert.ToInt32(cod);
                this.obraCodigo = codigo;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setEtapaCodigo(string cod)
        {
            int codigo;
            try
            {
                codigo = Convert.ToInt32(cod);
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