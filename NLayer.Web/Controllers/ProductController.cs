﻿using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Services;

namespace NLayer.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _services;

        public ProductController(IProductService services)
        {
            _services = services;
        }

        public async Task<IActionResult> Index()
        {
            var CustomResponse = await _services.GetProductsWithCategory();
            return View(CustomResponse.Data);
        }
    }
}
