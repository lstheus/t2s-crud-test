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
    public class ConteinerProfile : Profile
    {
        public ConteinerProfile()
        {
            CreateMap<ConteinerInputModel, Conteiner>();

        }
    }
}
