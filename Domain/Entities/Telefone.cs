using Domain.Entities;
using System;

namespace Domain
{
    public class Telefone
    {
        public int Id { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }

        public Cliente cliente { get; set; }
    }
}
