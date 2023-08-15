using API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetProdutos();
        Task<Produto> CreateProduto(string nome, string descricao, bool perecivel, int idCategoriaProduto);
        Task<Produto> EditProduto(Produto produto);
        Task<IEnumerable<CategoriaProduto>> GetCategoriaProdutos();
    }
}