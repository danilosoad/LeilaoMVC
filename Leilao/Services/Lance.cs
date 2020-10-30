using Leilao.Models;
using Leilao.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leilao.Services
{
    public class Lance
    {
        private IProdutoRepository _product;

        public Lance(IProdutoRepository product)
        {
            _product = product;
        }

        public bool DarLance(LanceViewModel model)
        {
            var produto = _product.getProdutoById(model.id);

            if (produto != null)
            {
                if (model.valorLance > produto.ULTIMOLANCE)
                {
                    produto.ULTIMAPESSOANOME = model.responsavelLance;
                    produto.ULTIMOLANCE = model.valorLance;
                    _product.Update();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

    }
}
