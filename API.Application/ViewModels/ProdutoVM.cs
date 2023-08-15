using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.ViewModels
{
    public class ProdutoVM
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public bool ativo { get; set; }
        public bool perecivel { get; set; }
        public CategoriaProdutoVM categoriaProduto { get; set; }
    }
}
