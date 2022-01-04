using Core.CrossCutting.ConnectionStrings.Interfaces;
using Infra.Data.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Infra.Data.Context
{
    public class ControleDividasContext : System.Data.Entity.DbContext
    {
        public event Action<ControleDividasContext> SavingChanges;
        public ControleDividasContext(
            IDatabaseInitializer<ControleDividasContext> dbInitializer, IControleDividasConnectionStringFactory connectionStringFactory)
            : base(nameOrConnectionString: connectionStringFactory.GetConnectionString())
        {
            Database.SetInitializer(dbInitializer);
        }
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // Configura todos os campos do tipo string para ter tamanho máximo de 100 caracteres.
            // Sets all string type fields to have a maximum length of 100 characters.
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            // Configura todos os campos do tipo datetime para assumir o tipo datetime2 no banco de dados.
            // Sets all fields of type datetime to assume type datetime2 in the database.
            modelBuilder.Properties<DateTime>()
                .Configure(x => x.HasColumnType("datetime2").HasPrecision(0));

            modelBuilder.HasDefaultSchema("dbo");

            // Adiciona configurações atualizada para as entidades, caso necessário.
            // Add updated settings for entities if necessary.
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EmailConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new TelefoneConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            if (SavingChanges != null)
            {
                SavingChanges.Invoke(this);
            }

            return base.SaveChanges();
        }

        private static string GetBoundedContextName()
        {
            return typeof(ControleDividasContext).Namespace.Split('.')[0];
        }
    }
}
