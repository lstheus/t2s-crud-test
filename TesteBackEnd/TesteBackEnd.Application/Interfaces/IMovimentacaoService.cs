using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Application.Models;
using TesteBackEnd.Core.Entities;

namespace TesteBackEnd.Application.Interfaces
{
    public interface IMovimentacaoService
    {
        public List<Movimentacao> Get();
        public Movimentacao GetById(int id);
        public void Post(MovimentacaoInputModel conteiner);
        public void Put(int id, MovimentacaoInputModel conteiner);
        public void Delete(int id);
        public void AddMovimentacaoConteiner(int id, string codigo);
    }
}
