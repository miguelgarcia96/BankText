﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechBank.Data;

#nullable disable

namespace TechBank.Data.Migrations
{
    [DbContext(typeof(WebAppContext))]
    partial class WebAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TechBank.DomainModel.AccountTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("account_transaction_id")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountTransactionTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("BankAccountId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("created")
                        .HasColumnOrder(4);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("created_by")
                        .HasColumnOrder(5);

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted")
                        .HasColumnOrder(8);

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int")
                        .HasColumnName("deleted_by")
                        .HasColumnOrder(9);

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<Guid>("EntityPublicKey")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("public_key")
                        .HasColumnOrder(2);

                    b.Property<DateTime?>("Locked")
                        .HasColumnType("datetime2")
                        .HasColumnName("locked")
                        .HasColumnOrder(10);

                    b.Property<int?>("LockedBy")
                        .HasColumnType("int")
                        .HasColumnName("locked_by")
                        .HasColumnOrder(11);

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified")
                        .HasColumnOrder(6);

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("modified_by")
                        .HasColumnOrder(7);

                    b.Property<int>("SourceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.ToTable("account_transaction", "account");
                });

            modelBuilder.Entity("TechBank.DomainModel.AppCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("customer_id")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("created")
                        .HasColumnOrder(4);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("created_by")
                        .HasColumnOrder(5);

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted")
                        .HasColumnOrder(8);

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int")
                        .HasColumnName("deleted_by")
                        .HasColumnOrder(9);

                    b.Property<Guid>("EntityPublicKey")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("public_key")
                        .HasColumnOrder(2);

                    b.Property<DateTime?>("Locked")
                        .HasColumnType("datetime2")
                        .HasColumnName("locked")
                        .HasColumnOrder(10);

                    b.Property<int?>("LockedBy")
                        .HasColumnType("int")
                        .HasColumnName("locked_by")
                        .HasColumnOrder(11);

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified")
                        .HasColumnOrder(6);

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("modified_by")
                        .HasColumnOrder(7);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("customer", "contact");
                });

            modelBuilder.Entity("TechBank.DomainModel.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("bank_account_id")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AppCustomerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BankAccountTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("created")
                        .HasColumnOrder(4);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("created_by")
                        .HasColumnOrder(5);

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted")
                        .HasColumnOrder(8);

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int")
                        .HasColumnName("deleted_by")
                        .HasColumnOrder(9);

                    b.Property<Guid>("EntityPublicKey")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("public_key")
                        .HasColumnOrder(2);

                    b.Property<DateTime?>("Locked")
                        .HasColumnType("datetime2")
                        .HasColumnName("locked")
                        .HasColumnOrder(10);

                    b.Property<int?>("LockedBy")
                        .HasColumnType("int")
                        .HasColumnName("locked_by")
                        .HasColumnOrder(11);

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified")
                        .HasColumnOrder(6);

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("modified_by")
                        .HasColumnOrder(7);

                    b.HasKey("Id");

                    b.HasIndex("AppCustomerId");

                    b.ToTable("bank_account", "account");
                });

            modelBuilder.Entity("TechBank.DomainModel.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("contact_id")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("created")
                        .HasColumnOrder(4);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int")
                        .HasColumnName("created_by")
                        .HasColumnOrder(5);

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted")
                        .HasColumnOrder(8);

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int")
                        .HasColumnName("deleted_by")
                        .HasColumnOrder(9);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EntityPublicKey")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("public_key")
                        .HasColumnOrder(2);

                    b.Property<string>("FirstLastName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("first_last_name")
                        .HasColumnOrder(19);

                    b.Property<string>("FirstName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("first_name")
                        .HasColumnOrder(17);

                    b.Property<DateTime?>("Locked")
                        .HasColumnType("datetime2")
                        .HasColumnName("locked")
                        .HasColumnOrder(10);

                    b.Property<int?>("LockedBy")
                        .HasColumnType("int")
                        .HasColumnName("locked_by")
                        .HasColumnOrder(11);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("middle_name")
                        .HasColumnOrder(18);

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2")
                        .HasColumnName("modified")
                        .HasColumnOrder(6);

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int")
                        .HasColumnName("modified_by")
                        .HasColumnOrder(7);

                    b.Property<string>("SecondLastName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("second_last_name")
                        .HasColumnOrder(20);

                    b.Property<string>("Title")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("title")
                        .HasColumnOrder(16);

                    b.HasKey("Id");

                    b.ToTable("contact", "contact");
                });

            modelBuilder.Entity("TechBank.DomainModel.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("TechBank.DomainModel.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedBy")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<Guid>("EntityPublicKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Locked")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LockedBy")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("TechBank.DomainModel.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("TechBank.DomainModel.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("TechBank.DomainModel.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("TechBank.DomainModel.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechBank.DomainModel.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("TechBank.DomainModel.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TechBank.DomainModel.AccountTransaction", b =>
                {
                    b.HasOne("TechBank.DomainModel.BankAccount", null)
                        .WithMany("Transactions")
                        .HasForeignKey("BankAccountId");
                });

            modelBuilder.Entity("TechBank.DomainModel.AppCustomer", b =>
                {
                    b.HasOne("TechBank.DomainModel.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TechBank.DomainModel.BankAccount", b =>
                {
                    b.HasOne("TechBank.DomainModel.AppCustomer", null)
                        .WithMany("Accounts")
                        .HasForeignKey("AppCustomerId");
                });

            modelBuilder.Entity("TechBank.DomainModel.User", b =>
                {
                    b.HasOne("TechBank.DomainModel.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("TechBank.DomainModel.AppCustomer", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("TechBank.DomainModel.BankAccount", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
