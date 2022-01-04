using Domain.Entities;
using System;

namespace Domain
{
    public class Telefone
    {
        public int Id { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }

        public Cliente Cliente { get; set; }

        protected Telefone() { }

        public Telefone(string ddd, string telefone)
        {
            DDD = ddd;
            Numero = telefone;
        }

        public void AlterarTelefone(string ddd, string telefone)
        {
            DDD = ddd;
            Numero = telefone;
        }
    }
}
