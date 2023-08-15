using API.Application.Interfaces;
using API.Application.Services;
using API.Application.Validator;
using API.Domain.Interfaces;
using API.Infra.Data.Repositories;
using API.Infrastructure.IoC.MapperProfiles;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Serviços
            services.AddScoped<IProdutoService, ProdutoService>();

            //Repositorios
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            //AutoMapper
            services.AddAutoMapper(typeof(ProdutoProfile));

            //FluentValidation
            services.AddValidatorsFromAssemblyContaining(typeof(CategoriaProdutoValidator));
            services.AddValidatorsFromAssemblyContaining(typeof(ProdutoValidator));
            services.AddValidatorsFromAssemblyContaining(typeof(CreateProdutoValidator));
        }
    }
}