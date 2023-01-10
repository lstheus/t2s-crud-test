using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Application.Models;
using TesteBackEnd.Core.Entities;

namespace TesteBackEnd.Application.Interfaces
{
    public interface IClienteService
    {
        public List<Cliente> Get();
        public Cliente GetById(int id);
        public void Post(ClienteInputModel cliente);
        public void Put(int id, ClienteInputModel cliente);
    }
}
