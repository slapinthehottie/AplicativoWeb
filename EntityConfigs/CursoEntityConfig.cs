using AplicativoWeb.Models; //camada Model
using Microsoft.EntityFrameworkCore;// Ef framework
using Microsoft.EntityFrameworkCore.Metadata.Builders; // Fluent API
namespace AplicativoWeb.EntityConfigs; //Novo namespace

public class CursoEntityConfig : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.ToTable("Curso");//Nome da Tabela
        //lambda
        /* s=>x+y
        */

        //Id        
        builder.HasKey(c => c.Id);//chave primária

        //TituloMarketing
        builder.Property(c => c.TituloMarketing)
                .HasColumnType("nvarchar(80)")
                .IsRequired();

        //TituloInterno
        builder.Property(c => c.TituloInterno)
        .HasColumnType("nvarchar(80)")
        .IsRequired();

        //Descricao
        builder.Property(c => c.Descricao)
        .HasColumnType("text")
        .IsRequired();
    }
}