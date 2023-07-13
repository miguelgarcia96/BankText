﻿using TechBank.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TechBank.Data.Configurations
{    
    public class AccountTransactionConfiguration : IEntityTypeConfiguration<AccountTransaction>
    {
        public void Configure(EntityTypeBuilder<AccountTransaction> builder)
        {
            //Table configurations
            builder.ToTable("account_transaction", "account");

            builder.HasKey(e => e.Id);

            // Entity configurations
            builder.Property(e => e.Id)
                .HasColumnName("account_transaction_id")
                .IsRequired()
                .HasColumnOrder(1);

            #region IPublicKeyEntity
            builder.Property(e => e.EntityPublicKey)
                .HasColumnName("public_key")
                .IsRequired()
                .HasColumnOrder(2);
            #endregion            

            #region IAuditEntity
            builder.Property(e => e.Created)
                .HasColumnName("created")
                .IsRequired()
                .HasColumnOrder(4);

            builder.Property(e => e.CreatedBy)
                .HasColumnName("created_by")
                .IsRequired()
                .HasColumnOrder(5);

            builder.Property(e => e.Modified)
                .HasColumnName("modified")
                .IsRequired()
                .HasColumnOrder(6);

            builder.Property(e => e.ModifiedBy)
                .HasColumnName("modified_by")
                .IsRequired()
                .HasColumnOrder(7);

            builder.Property(e => e.Deleted)
                .HasColumnName("deleted")
                .IsRequired(false)
                .HasColumnOrder(8);

            builder.Property(e => e.DeletedBy)
                .HasColumnName("deleted_by")
                .IsRequired(false)
                .HasColumnOrder(9);

            builder.Property(e => e.Locked)
                .HasColumnName("locked")
                .IsRequired(false)
                .HasColumnOrder(10);

            builder.Property(e => e.LockedBy)
                .HasColumnName("locked_by")
                .IsRequired(false)
                .HasColumnOrder(11);
            #endregion            

            builder.Property(e => e.Comments)
                .IsRequired(false)
                .HasMaxLength(256);                

            builder.Ignore(e => e.Destination);
            builder.Ignore(e => e.Source);

        }
    }
}
