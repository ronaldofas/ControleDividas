using Domain.Interfaces.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IClienteRepository ClienteRepository { get; }
        IEmailRepository EmailRepository { get; }
        IEnderecoRepository EnderecoRepository { get; }
        ITelefoneRepository TelefoneRepository { get; }

        void Save();
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        void EnableBulkInsertOptimizations();
        void DisableBulkInsertOptimizations();
    }
}
