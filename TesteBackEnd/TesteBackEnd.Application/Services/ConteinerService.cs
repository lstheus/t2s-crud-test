using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Application.Interfaces;
using TesteBackEnd.Application.Models;
using TesteBackEnd.Core.Entities;
using TesteBackEnd.Core.Interfaces;

namespace TesteBackEnd.Application.Services
{
    public class ConteinerService : IConteinerService
    {
        private readonly IConteinerRepository _conteinerRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;
        public ConteinerService(IConteinerRepository conteinerRepository, IClienteRepository clienteRepository, IMapper mapper)
        {
            _conteinerRepository = conteinerRepository;
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public void AddConteinerCliente(int id, string codigo)
        {
            var cliente = _clienteRepository.GetById(id);
            var conteiner = _conteinerRepository.GetById(codigo);
            cliente.conteiners.Add(conteiner);
            _clienteRepository.Put(cliente);
        }

        public void Delete(string codigo)
        {
            var conteiner = _conteinerRepository.GetById(codigo);
            _conteinerRepository.Delete(conteiner);
        }

        public List<Conteiner> Get()
        {
            var conteiners = _conteinerRepository.Get();
            if (conteiners == null) throw new NullReferenceException();
            return conteiners;
        }

        public Conteiner GetById(string codigo)
        {
            if (codigo == null) throw new NullReferenceException();
            var conteiner = _conteinerRepository.GetById(codigo);
            if (conteiner == null) throw new NullReferenceException();
            return conteiner;
        }

        public void Post(ConteinerInputModel conteiner)
        {
            var conteinerModel =_conteinerRepository.GetById(conteiner.Codigo);
            if (conteinerModel != null) throw new InvalidOperationException();
            var conteinerMap = _mapper.Map<Conteiner>(conteiner);
            _conteinerRepository.Post(conteinerMap);
        }

        public void Put(string codigo, ConteinerInputModel conteiner)
        {
            var conteinerModel = GetById(conteiner.Codigo);
            if (conteinerModel == null) throw new NullReferenceException();
            var conteinerMap = _mapper.Map<Conteiner>(conteiner);
            _conteinerRepository.Put(conteinerMap);
        }
    }
}
