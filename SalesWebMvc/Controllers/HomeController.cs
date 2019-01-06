using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    // Todo controlador herda da classe controler.
    public class HomeController : Controller
    {
        // Conjunto de métodos:
        // IActionResult (resultado de uma ação)
        // O próprio nome do método é mapeado para ação.
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            // Acessou um objeto chamado view data,
            // Na chave "Message",
            // Depois recebendo o valor: "Your application description page.".
            ViewData["Message"] = "Site de vendas 'MVC' do curso C#.";
            ViewData["aluno"] = "JMR";
            ViewData["email"] = "jmramos625@gmail.com";

            // View é um method builder, que retorna um IActionResult do tipo View
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
