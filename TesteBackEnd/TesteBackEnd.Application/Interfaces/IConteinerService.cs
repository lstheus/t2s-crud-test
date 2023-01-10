using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Application.Models;
using TesteBackEnd.Core.Entities;

namespace TesteBackEnd.Application.Interfaces
{
    public interface IConteinerService
    {
        public List<Conteiner> Get();
        public Conteiner GetById(string codigo);
        public void Post(ConteinerInputModel conteiner);
        public void Put(string codigo,ConteinerInputModel conteiner);
        public void Delete(string codigo);
        public void AddConteinerCliente(int id,string codigo);
    }
}
