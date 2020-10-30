using Leilao.Data;
using Leilao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leilao.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly DataContext _context;

        public PessoaRepository(DataContext context)
        {
            _context = context;
        }
        public void Add(PessoaModel pessoa)
        {
            _context.Add(pessoa);
            _context.SaveChanges();
        }
    }
}
