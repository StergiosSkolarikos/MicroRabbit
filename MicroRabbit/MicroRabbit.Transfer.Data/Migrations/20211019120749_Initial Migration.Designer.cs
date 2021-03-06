// <auto-generated />
using MicroRabbit.Transfer.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MicroRabbit.Transfer.Data.Migrations
{
    [DbContext(typeof(TransferDbContext))]
    [Migration("20211019120749_Initial Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MicroRabbit.Transfer.Domain.Models.TransferLog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("FromAccount")
                        .HasColumnType("integer");

                    b.Property<int>("ToAccount")
                        .HasColumnType("integer");

                    b.Property<decimal>("TransferAmount")
                        .HasColumnType("numeric");

                    b.HasKey("id");

                    b.ToTable("TransferLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
