using API.Application.ViewModels;
using API.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Infrastructure.IoC.MapperProfiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile() 
        {
            CreateMap<CategoriaProduto, CategoriaProdutoVM>();
            CreateMap<Produto, ProdutoVM>();

            CreateMap<CategoriaProdutoVM, CategoriaProduto>();
            CreateMap<ProdutoVM, Produto>();

            CreateMap<IEnumerable<CategoriaProduto>, IEnumerable<CategoriaProdutoVM>>();
            CreateMap<IEnumerable<Produto>, IEnumerable<ProdutoVM>>();
        }
    }
}