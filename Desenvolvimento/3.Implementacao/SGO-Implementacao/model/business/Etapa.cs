using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.model.business
{
    public class Etapa
    {
        #region Atributos
        private int codigo;
        private string nome;
        private int percentualConclusao;
        private double totalGastosPrevisto;
        private DateTime dataInicioPrevisto;
        private DateTime dataFimPrevisto;
        private DateTime dataInicioReal;
        private DateTime dataFimReal;
        private int obraCodigo;
        #endregion

        #region Getters
        public int getCodigo()
        {
            return this.codigo;
        }
        public string getNome()
        {
            return this.nome;
        }
        public int getPercentualConclusao()
        {
            return this.percentualConclusao;
        }
        public double getTotalGastosPrevisto()
        {
            return this.totalGastosPrevisto;
        }
        public DateTime getDataInicioPrevisto()
        {
            return this.dataInicioPrevisto;
        }
        public DateTime getDataFimPrevisto()
        {
            return this.dataFimPrevisto;
        }
        public DateTime getDataInicioReal()
        {
            return this.dataInicioReal;
        }
        public DateTime getDataFimReal()
        {
            return this.dataFimReal;
        }
        public int getObraCodigo()
        {
            return this.obraCodigo;
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
        public bool setNome(string nome)
        {
            try
            {
                this.nome = nome;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setPercentualConclusao(string percentual)
        {
            int percentualConclusao;
            try
            {
                percentualConclusao = Convert.ToInt32(percentual);
                this.percentualConclusao = percentualConclusao;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setTotalGastosPrevisto(string total)
        {
            double totalGastos;
            try
            {
                totalGastos = Convert.ToDouble(total);
                this.totalGastosPrevisto = totalGastos;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setDataInicioPrevisto(string date)
        {
            DateTime inicioPrevisto;
            try
            {
                inicioPrevisto = Convert.ToDateTime(date);
                this.dataInicioPrevisto = inicioPrevisto;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setDataFimPrevisto(string date)
        {
            DateTime fimPrevisto;
            try
            {
                fimPrevisto = Convert.ToDateTime(date);
                this.dataFimPrevisto = fimPrevisto;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setDataInicioReal(string date)
        {
            DateTime inicioReal;
            try
            {
                inicioReal = Convert.ToDateTime(date);
                this.dataInicioReal = inicioReal;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setDataFimReal(string date)
        {
            DateTime fimReal;
            try
            {
                fimReal = Convert.ToDateTime(date);
                this.dataFimReal = fimReal;
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
        #endregion
    }
}