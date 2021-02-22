using EcommerceBooks.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceBooks.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IProdutoRepository produtoRepository;

        public PedidoController(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public IActionResult Carrossel()
        {
            var ListaDeLivros = produtoRepository.GetProdutos();
            return View(ListaDeLivros);
        }
        public IActionResult Carrinho()
        {
            return View();
        }
        public IActionResult Resumo()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
