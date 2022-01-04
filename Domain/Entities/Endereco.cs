using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }

        public virtual Cliente cliente { get; set; }

        protected Endereco(){ }

        public Endereco(
            string logradouro, string numero, string bairro, string cidade, string estado, string complemento,
            string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Complemento = complemento;
            CEP = cep;
        }

        public void AlterarLogradouro(string endereco, string numero)
        {
            Logradouro = endereco;
            Numero = numero;
        }

        public void AlterarBairro(string bairro)
        {
            Bairro = bairro;
        }

        public void AlterarCidade(string cidade)
        {
            Cidade = cidade;
        }

        public void AlterarEstado(string estado)
        {
            Estado = estado;
        }

        public void AlterarComplemento(string complemento)
        {
            Complemento = complemento;
        }

        public void AlterarCep(string cep)
        {
            CEP = cep;
        }
    }
}
