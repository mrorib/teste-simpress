using API.Application.Interfaces;
using API.Application.ViewModels;
using API.Domain.Entities;
using API.Domain.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<ProdutoVM> EditProduto(ProdutoVM editProduto)
        {
            return _mapper.Map<ProdutoVM>(await _produtoRepository.EditProduto(_mapper.Map<Produto>(editProduto)));
        }

        public async Task<ProdutoVM> CreateProduto(CreateProdutoVM createProduto)
        {
            return _mapper.Map<ProdutoVM>(await _produtoRepository.CreateProduto(createProduto.nome, createProduto.descricao, createProduto.perecivel, createProduto.idCategoriaProduto));
        }

        public async Task<CategoriasProdutoVM> GetCategoriasProdutos()
        {
            return new CategoriasProdutoVM()
            {
                CategoriasProduto = _mapper.Map<IEnumerable<CategoriaProdutoVM>>(await _produtoRepository.GetCategoriaProdutos())
            };
        }

        public async Task<ProdutosVM> GetProdutos()
        {
            return new ProdutosVM()
            {
                Produtos = _mapper.Map<IEnumerable<ProdutoVM>>(await _produtoRepository.GetProdutos())
            };
        }
    }
}
