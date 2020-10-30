using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leilao.Models
{
    public class PessoaModel
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public string IDADE { get; set; }
        public List<ProdutoModel> produtos { get; set; }
    }
}
