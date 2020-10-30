using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Leilao.Models;
using Leilao.Data;
using Leilao.Repository;
using X.PagedList;
using Leilao.Services;

namespace Leilao.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IPessoaRepository _pessoaRepo;
        public IProdutoRepository _produtoRepo;
        private Lance _lance;

        public HomeController(ILogger<HomeController> logger, IPessoaRepository pessoaRepo, IProdutoRepository produtoRepo, Lance lance)
        {
            _logger = logger;
            _pessoaRepo = pessoaRepo;
            _produtoRepo = produtoRepo;
            _lance = lance;
        }

        public IActionResult Index(string keyword, int pagina = 1)
        {
            IEnumerable<ProdutoModel> result;
            ViewBag.Keyword = keyword;

            if (keyword != null)
            {
                result = _produtoRepo.GetProductsByNome(keyword);
            }
            else
            {
                result = _produtoRepo.GetProducts();
            }
            return View(result.ToPagedList(pagina, 10));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CadastroProduto()
        {
            return View();
        }

        public IActionResult CadastroPessoa()
        {
            return View();
        }


        #region Actions para Regras de Negócios

        public IActionResult DarLance(LanceViewModel model)
        {
            try
            {
                var result = _lance.DarLance(model);

                if (result)
                    return Json("ok");
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            return Content("teste");
        }

        public IActionResult CadastrarProduto(ProdutoModel model)
        {
            try
            {
                _produtoRepo.Add(model);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            return RedirectToAction("Index");
        }

        public IActionResult CadastrarPessoa(PessoaModel model)
        {
            try
            {
                _pessoaRepo.Add(model);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            return RedirectToAction("Index");
        }

        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
