using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entities;

namespace Projeto.DAL.Configurations
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            ToTable("Tb_Cliente");

            HasKey(c => c.IdCliente);

            Property(c => c.IdCliente)
                .HasColumnName("IDCLIENTE_PK");

            Property(c => c.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.Email)
                 .HasColumnName("EMAIL")
                 .HasMaxLength(50)
                 .IsRequired();

            Property(c => c.DataCadastro)
                .HasColumnName("DATACADASTRO")
                .IsRequired();
        }



    }
}
