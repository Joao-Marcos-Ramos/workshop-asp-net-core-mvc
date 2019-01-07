using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Service;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        // DINÂMICA MVC.
                        // 1- É feita a chamada do controlador.
        public IActionResult Index()
        {
            // Vai retornar uma lista de Seller.
            // 2- Controlador acessou meu Model.
            var list = _sellerService.FindAll();

            // 3- Depois encaminha os dados para minha view.
            return View(list);
        }
    }
}