using Microsoft.EntityFrameworkCore;
using ApiCadastroClientes.Models;
using ApiCadastroClientes.Models.FluentMap;

namespace ApiCadastroClientes.Data{
    public class ApiCadastroClientesContext : DbContext{
        public ApiCadastroClientesContext(DbContextOptions<ApiCadastroClientesContext> options) 
        : base(options){

        }
        public DbSet<Cliente> Clientes {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            new ClienteMap(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}