using Aluno.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aluno.Data.Mapping
{
    public class AlunoEntityMap : IEntityTypeConfiguration<AlunoEntity>
    {
        public void Configure(EntityTypeBuilder<AlunoEntity> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(a => a.Id);

            builder.HasIndex(a => a.Email)
                .IsUnique();

            builder.Property(a => a.Nome)
                .HasMaxLength(30);

            builder.Property(a => a.Email)
                .HasMaxLength(50);
        }
    }
}
