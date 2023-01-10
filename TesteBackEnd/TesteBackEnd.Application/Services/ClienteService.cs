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
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;
        public ClienteService( IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }
        public List<Cliente> Get()
        {
            var clientes = _clienteRepository.Get();
            if (clientes == null) throw new NullReferenceException();
            return clientes;

        }

        public Cliente GetById(int id)
        {
            var cliente = _clienteRepository.GetById(id);
            if(cliente == null) throw new NullReferenceException();
            return cliente;
        }

        public void Post(ClienteInputModel cliente)
        {
            var clienteMap = _mapper.Map<Cliente>(cliente);
            _clienteRepository.Post(clienteMap);
        }

        public void Put(int id, ClienteInputModel cliente)
        {
            var clienteModel = GetById(id);
            if (clienteModel == null) throw new NullReferenceException();
            var clienteMap = _mapper.Map<Cliente>(cliente);
            _clienteRepository.Put(clienteMap);
        }

   
    }
}
