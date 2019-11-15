using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sgo.model.business
{
    public class Cliente
    {
        #region Atributos
        private string cpf;
        private string nome;
        private string email;
        private string telefone;
        private Endereco endereco;
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
        public Endereco getEndereco()
        {
            return this.endereco;
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