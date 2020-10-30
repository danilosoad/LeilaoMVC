using Leilao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leilao.Repository
{
    public interface IProdutoRepository
    {
        void Add(ProdutoModel produto);
        void Update();
        IEnumerable<ProdutoModel> GetProducts();
        IEnumerable<ProdutoModel> GetProductsByNome(string nome);
        ProdutoModel getProdutoById(int id);
    }
}
