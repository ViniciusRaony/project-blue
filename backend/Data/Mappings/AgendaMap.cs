using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Blue.Models;


namespace Blue.Data.Mappings
{
    public class AgendaMap : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            // Tabela
            builder.ToTable("Agenda");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Propriedades
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("Nome")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasColumnType("VARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasColumnName("Telefone")
                .HasColumnType("VARCHAR")
                .HasMaxLength(15);


        }
    }
}
