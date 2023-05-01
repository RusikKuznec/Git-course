using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Web_first.EfStuff;
using Web_first.EfStuff.DbModel;
using Web_first.Models;



namespace Web_first.Controllers
{
    public class GalleryController : Controller
    {
        private WebContext _webContext;

        public GalleryController(WebContext webContext)
        {
            _webContext = webContext;
        }

        public IActionResult Index()
        {
            var dbImages = _webContext.Images.ToList();
            var viewModel = dbImages.Select(dbImage => new ImageIndexViewModel
            {
                Id = dbImage.Id,
                Name = dbImage.Name
            }).ToList();
            
            return View(viewModel);
        }

        public IActionResult ShowImage(int id)
        {
            var dbImage = _webContext.Images.First(x => x.Id == id);
            var model = new ImageUrlIndexViewModel()
            {
                Url = dbImage.Url
            };
            

            return View(model);
        }

        [HttpGet]
        public IActionResult AddImage()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddImage(AddImageViewModel newImage)
        {
            var dbImage = new Image
            {
                Name = newImage.Name,
                Rate = newImage.Rate,
                Url = newImage.Url
            };

            _webContext.Add(dbImage);
            _webContext.SaveChanges();
            return View();
        }
    }
}
