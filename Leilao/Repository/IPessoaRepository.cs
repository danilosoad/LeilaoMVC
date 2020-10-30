using Leilao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leilao.Repository
{
    public interface IPessoaRepository
    {
        void Add(PessoaModel pessoa);
    }
}
