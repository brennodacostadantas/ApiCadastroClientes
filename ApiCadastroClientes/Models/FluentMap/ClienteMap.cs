using Microsoft.EntityFrameworkCore;

namespace ApiCadastroClientes.Models.FluentMap{
    public class ClienteMap{
        public ClienteMap(ModelBuilder builder){
            builder.Entity<Cliente>(cliente =>{
                cliente.ToTable("Clientes");
                cliente.HasKey(c => c.Id);
                cliente.Property(cl => cl.Id).ValueGeneratedOnAdd();
                cliente.Property(c => c.CNPJ).IsRequired().HasColumnType("varchar(18)");
                cliente.Property(c => c.Nome).IsRequired().HasColumnType("varchar(100)");
                cliente.Property(c => c.Endereco).IsRequired().HasColumnType("varchar(100)");
                cliente.Property(c => c.Contato).IsRequired().HasColumnType("varchar(15)");
                cliente.Property(c => c.DataCadastro).IsRequired();
            });
        }
    }
}