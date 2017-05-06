﻿using Collections.Portal.Infrastructure;
using Collections.Portal.Services.Interfaces;
using Collections.Portal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Portal.Controllers.Web
{
    public class CollectionController : Controller
    {
        private readonly ICollectionService collectionService;

        public CollectionController(ICollectionService collectionService)
        {
            this.collectionService = collectionService;
        }

        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(MovieViewModel model)
        {
            return View();
        }

        public IActionResult Books()
        {
            return View();
        }

        public IActionResult Games()
        {
            return View();
        }

        public IActionResult Albums()
        {
            return View();
        }
    }
}
