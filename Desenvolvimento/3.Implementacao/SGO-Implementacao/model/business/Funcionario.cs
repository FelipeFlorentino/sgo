using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.model.business
{
    public class Funcionario
    {
        #region Atributos
        private string cpf;
        private string nome;
        private string email;
        private string telefone;
        private double salario;
        private string funcao;
        private Endereco endereco;
        private int obraCodigo;
        #endregion

        #region Getters
        public string getCPF()
        {
            return this.cpf;
        }
        public string getNome()
        {
            return this.nome;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getTelefone()
        {
            return this.telefone;
        }
        public double getSalario()
        {
            return this.salario;
        }
        public string getFuncao()
        {
            return this.funcao;
        }
        public Endereco getEndereco()
        {
            return this.endereco;
        }
        public int getObraCodigo()
        {
            return this.obraCodigo;
        }
        #endregion

        #region Setters
        public bool setCPF(string cpf)
        {
            try
            {
                this.cpf = cpf;
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
        public bool setEmail(string email)
        {
            try
            {
                this.email = email;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setTelefone(string telefone)
        {
            try
            {
                this.telefone = telefone;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setSalario(string sal)
        {
            double salario;
            try
            {
                salario = Convert.ToDouble(sal);
                this.salario = salario;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool setFuncao(string funcao)
        {
            try
            {
                this.funcao = funcao;
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