using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.model.business
{
    public class Obra
    {
        #region Atributos
        private int codigo;
        private DateTime dataInicio;
        private DateTime dataFim;
        private string status;
        private string cliente_nome;
        private Endereco endereco;
        #endregion

        #region Getters
        public int getCodigo()
        {
            return this.codigo;
        }
        public DateTime getDataInicio()
        {
            return this.dataInicio;
        }
        public DateTime getDataFim()
        {
            return this.dataFim;
        }
        public string getStatus()
        {
            return this.status;
        }
        public string getClienteNome()
        {
            return this.cliente_nome;
        }
        public Endereco getEndereco()
        {
            return this.endereco;
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
        public bool setDataInicio(string date)
        {
            DateTime dataInicio;
            try
            {
                dataInicio = Convert.ToDateTime(date);
                this.dataInicio = dataInicio;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setDataFim(string date)
        {
            DateTime dataFim;
            try
            {
                dataFim = Convert.ToDateTime(date);
                this.dataFim = dataFim;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setStatus(string status)
        {
            try
            {
                this.status = status;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setClienteNome(string cliente_nome)
        {
            try
            {
                this.cliente_nome = cliente_nome;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setEndereco(Endereco endereco)
        {
            try
            {
                this.endereco = endereco;
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