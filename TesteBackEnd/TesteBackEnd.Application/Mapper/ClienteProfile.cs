using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBackEnd.Application.Models;
using TesteBackEnd.Core.Entities;

namespace TesteBackEnd.Application.Mapper
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<ClienteInputModel, Cliente>();

        }
    }
}
