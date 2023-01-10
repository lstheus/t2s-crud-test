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
    public class MovimentacaoService : IMovimentacaoService
    {
        private readonly IMovimentacaoRepository _movimentacaoRepository;
        private readonly IConteinerRepository _conteinerRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;
        public MovimentacaoService(IConteinerRepository conteinerRepository, IClienteRepository clienteRepository, IMapper mapper,IMovimentacaoRepository movimentacaoRepository)
        {
            _conteinerRepository = conteinerRepository;
            _clienteRepository = clienteRepository;
            _mapper = mapper;
            _movimentacaoRepository = movimentacaoRepository;
        }

        public void AddMovimentacaoConteiner(int id, string codigo)
        {
            var conteiner = _conteinerRepository.GetById(codigo);
            var movimentacao = _movimentacaoRepository.GetById(id);
            conteiner.movimentacoes.Add(movimentacao);
            _conteinerRepository.Put(conteiner);
        }

        public void Delete(int id)
        {
            var movimentacao = _movimentacaoRepository.GetById(id);
            _movimentacaoRepository.Delete(movimentacao);
        }

        public List<Movimentacao> Get()
        {
            var movimentacoes = _movimentacaoRepository.Get();
            if (movimentacoes == null) throw new NullReferenceException();
            return movimentacoes;
        }

        public Movimentacao GetById(int id)
        {
            if (id == null) throw new NullReferenceException();
            var movimentacao = _movimentacaoRepository.GetById(id);
            if (movimentacao == null) throw new NullReferenceException();
            return movimentacao;
        }

        public void Post(MovimentacaoInputModel movimentacao)
        {
            var movimentacaoMap = _mapper.Map<Movimentacao>(movimentacao);
            var clienteId = _conteinerRepository.GetById(movimentacao.CodigoConteiner).ClienteId;
            var cliente = _clienteRepository.GetById(clienteId);
            movimentacaoMap.ClienteId = cliente.Id;
            movimentacaoMap.ClienteNome = cliente.Nome;
            _movimentacaoRepository.Post(movimentacaoMap);
        }

        public void Put(int id, MovimentacaoInputModel movimentacao)
        {
            var movimentacaoMap = _mapper.Map<Movimentacao>(movimentacao);
            var clienteId = _conteinerRepository.GetById(movimentacao.CodigoConteiner).ClienteId;
            var cliente = _clienteRepository.GetById(clienteId);
            movimentacaoMap.ClienteId = cliente.Id;
            movimentacaoMap.ClienteNome = cliente.Nome;
            _movimentacaoRepository.Put(movimentacaoMap);
        }
    }
}
