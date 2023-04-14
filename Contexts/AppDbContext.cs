
//Trabalho para Amanhã: Instalar Dependências
using AplicativoWeb.Models; //Chamando camada modelo
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using AplicativoWeb.EntityConfigs;
public class AppDbContext : DbContext
{

    //DbContexto = Representa o banco de dados
    //DbSet = Representa a Tabela

    public DbSet<Curso> Cursos => Set<Curso>(); // Representa a tabela

    //override(Sobrecrever)
    //NaoTrair( ) - Contrato
    //CompartilharCarteira( )
    //Protect

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Server=LA-F08-20;DataBase=EscolaDotNet;User Id=sa;Password=senai@123;TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new CursoEntityConfig());
    }



}





