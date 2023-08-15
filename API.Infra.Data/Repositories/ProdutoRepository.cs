using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        public AppDbContext _content;

        public ProdutoRepository(AppDbContext content)
        {
            _content = content;
        }

        public async Task<Produto> CreateProduto(string nome, string descricao, bool perecivel, int idCategoriaProduto)
        {
            var produto = new Produto() { nome = nome, descricao = descricao, perecivel = perecivel, categoriaProduto = new CategoriaProduto() { id = idCategoriaProduto} };
            await _content.Produtos.AddAsync(produto);

            if (_content.SaveChanges() > 0)
            {
                return await _content.Produtos.FirstAsync(p => p.nome == produto.nome && p.descricao == produto.descricao && p.ativo == true);
            }
            else
            {
                throw new Exception("Erro ao cadastrar o produto " + produto.nome);
            }
        }

        public async Task<Produto> EditProduto(Produto produto)
        {
            _content.Produtos.Update(produto);

            if (await _content.SaveChangesAsync() > 0)
                return produto;
            else
                throw new DbUpdateException("Erro ao atualizar o produto " + produto.id.ToString("0") + " - " + produto.nome);
        }

        public async Task<IEnumerable<CategoriaProduto>> GetCategoriaProdutos()
        {
            return await _content.CategoriasProduto.ToListAsync();
        }

        public async Task<IEnumerable<Produto>> GetProdutos()
        {
            return await _content.Produtos.ToListAsync();
        }
    }
}
