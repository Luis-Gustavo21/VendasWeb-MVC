﻿using Microsoft.AspNetCore.Mvc;
using VendasWeb_MVC.Services;

namespace VendasWeb_MVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}