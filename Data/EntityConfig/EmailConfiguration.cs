using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Infra.Data.EntityConfig
{
    public class EmailConfiguration : EntityTypeConfiguration<Email>
    {
        public EmailConfiguration() { }
    }
}
