using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public virtual Endereco Endereco { get; private set; }
        public ICollection<Telefone> Telefone { get; private set; }
        public ICollection<Email> Email { get; private set; }

        protected Cliente() { }

        public Cliente(string nome, Endereco endereco, string cpf)
        {
            Nome = nome;
            Endereco = endereco;
            CPF = cpf;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }
    }
}
