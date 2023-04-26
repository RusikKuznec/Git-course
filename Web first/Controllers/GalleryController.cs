using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Web_first.Models;



namespace Web_first.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var listImages = new List<ImageIndexViewModel>()
            {
                new ImageIndexViewModel()
                {
                    Id = 1,
                    Name = "White"
                },
                new ImageIndexViewModel()
                {
                    Id=2,
                    Name = "Dark"
                }


            };
            
            return View(listImages);
        }


        public IActionResult AddImage(int id)
        {
            var model = new ImageUrlIndexViewModel();
            switch(id){
                case 1: model.Url = "/images/gallery/white.jpg";
                    break;
                case 2: model.Url = "/images/gallery/dark.jpg";
                    break;

            }

            return View(model);
        }

    }
}
