using FotballSchoolMS.DAL.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FotballSchoolMS.DAL.Configuration
{
    public abstract class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void  Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(b => b.Id);
        }
    }

    
}
