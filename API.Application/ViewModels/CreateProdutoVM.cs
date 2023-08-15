using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Application.ViewModels
{
    public class CreateProdutoVM
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public bool perecivel { get; set; }
        public int idCategoriaProduto { get; set; }
    }
}
