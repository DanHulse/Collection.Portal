using Collection.Portal.Infrastructure;
using Collection.Portal.Models;
using Collection.Portal.Services.Interfaces;
using Collection.Portal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Portal.Controllers.Web
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
            var movies = this.collectionService.Get<MoviesModel>();

            var moviesList = movies.ToList();

            ViewData["Movies"] = moviesList;

            return View();
        }

        [HttpPost]
        public IActionResult Movies(MovieViewModel model)
        {
            var modelList = new List<MovieViewModel>
            {
                model
            };

            var result = this.collectionService.PostAsync(modelList);
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
