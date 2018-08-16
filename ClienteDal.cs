using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Entities;
using Projeto.DAL.DataSource;

namespace Projeto.DAL.Persistence
{
    public class ClienteDal
    {
        public void Insert(Cliente c)
        {
            using(Conexao Con = new Conexao())
            {
                Con.Cliente.Add(c);
                Con.SaveChanges();
            }
        }

        public void Update(Cliente c)
        {
            using(Conexao Con = new Conexao())
            {
                Con.Entry(c).State = EntityState.Modified;
                Con.SaveChanges();
            }
        }

        public void Delete(int idCliente)
        {
            using (Conexao Con = new Conexao())
            {
                Cliente c = Con.Cliente.Find(idCliente);

                Con.Cliente.Remove(c);
                Con.SaveChanges();
            }
        }

        public List<Cliente> FindAll()
        {
            using(Conexao Con = new Conexao())
            {
                return Con.Cliente.ToList();
            }
        }

        public Cliente FindById(int idCliente)
        {
            using(Conexao Con = new Conexao())
            {
                return Con.Cliente.Find(idCliente);
            }
        }

        public List<Cliente> FindAllByNome(string Nome)
        {
            using(Conexao Con = new Conexao())
            {
                return Con.Cliente
                        .Where(c => c.Nome.Contains(Nome))
                        .OrderBy(c => c.Nome)
                        .ToList();
            }
        }


    }
}
