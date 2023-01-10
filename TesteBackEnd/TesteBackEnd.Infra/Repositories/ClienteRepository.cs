using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Core.Entities;
using TesteBackEnd.Core.Interfaces;
using TesteBackEnd.Infra.Context;

namespace TesteBackEnd.Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly TesteContext context;
        public ClienteRepository(TesteContext _context)
        {
            context = _context;
        }
        public List<Cliente> Get()
        {
            return context.clientes.ToList();
        }

        public Cliente GetById(int id)
        {
            var clientes = context.clientes.Where(m => m.Id == id).AsNoTracking().FirstOrDefault();
            return clientes;
        }

        public void Post(Cliente cliente)
        {

            context.clientes.Add(cliente);
            context.SaveChanges();
        }

        public void Put(Cliente cliente)
        {
            context.clientes.Entry(cliente).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
