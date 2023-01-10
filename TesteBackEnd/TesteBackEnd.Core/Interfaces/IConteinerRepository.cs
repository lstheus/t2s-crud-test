using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Core.Entities;

namespace TesteBackEnd.Core.Interfaces
{
    public interface IConteinerRepository
    {
        public List<Conteiner> Get();
        public Conteiner GetById(string codigo);
        public void Post(Conteiner conteiner);
        public void Put(Conteiner conteiner);
        public void Delete(Conteiner conteiner);
    }
}
