using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Email
    {
        public int Id { get; set; }
        public string EnderecoEmail { get; set; }

        public Cliente cliente { get; set; }

        protected Email() { }


    }
}
