using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.DAL
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {
        Cliente ObterPorCpf(string cpf);
    }
}
