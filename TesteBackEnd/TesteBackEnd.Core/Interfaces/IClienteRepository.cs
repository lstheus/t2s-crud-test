using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Core.Entities;

namespace TesteBackEnd.Core.Interfaces
{
    public interface IClienteRepository
    {
        public List<Cliente> Get();
        public Cliente GetById(int id);
        public void Post(Cliente cliente);
        public void Put(Cliente cliente);
    }
}
