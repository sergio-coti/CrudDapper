using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula03.Models
{
    /// <summary>
    /// Modelo de dados para retornar o somatório da quantidade
    /// de produtos de cada estoque.
    /// </summary>
    public class TotalQuantidadeEstoqueModel
    {
        public Guid IdEstoque { get; set; }
        public string NomeEstoque { get; set; }
        public int TotalQuantidade { get; set; }
    }
}
