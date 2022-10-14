using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade_02.Models;

namespace Atividade_02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger){
            _logger = logger;
        }

        public IActionResult Index(){
            return View();
        }
        
        public IActionResult CadastroPedido(string descricao, double valorUnitario, double quantidade){
            Dados.PedidoAtual.NovoItem(descricao, valorUnitario, quantidade);
            return View();
        }

        public IActionResult ListaPedido(){            
            List<ItemPedido> pedido = Dados.PedidoAtual.ListaPedido();            
            return View(pedido);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
