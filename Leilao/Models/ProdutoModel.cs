using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leilao.Models
{
    public class ProdutoModel
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public double VALOR { get; set; }
        public double ULTIMOLANCE { get; set; }
        public string ULTIMAPESSOANOME { get; set; }
        public PessoaModel ULTIMAPESSOA { get; set; }
    }
}
