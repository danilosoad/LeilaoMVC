using Leilao.Data;
using Leilao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leilao.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _context;

        public ProdutoRepository(DataContext context)
        {
            _context = context;
        }
        public void Add(ProdutoModel produto)
        {
            if(produto.ULTIMAPESSOA == null)
            {
                produto.ULTIMAPESSOA = new PessoaModel() {NOME = "", IDADE = "", produtos = new List<ProdutoModel>() };
            }
            _context.Add(produto);

            _context.SaveChanges();
        }

        public IEnumerable<ProdutoModel> GetProducts()
        {
            return _context.Produtos;
        }

        public IEnumerable<ProdutoModel> GetProductsByNome(string nome)
        {
            return _context.Produtos.Where(x => x.ULTIMAPESSOANOME.Contains(nome));
        }

        public ProdutoModel getProdutoById(int id)
        {
            return _context.Produtos.FirstOrDefault(x => x.ID == id);
        }

        public void Update()
        {
            _context.SaveChanges();
        }
    }
}
