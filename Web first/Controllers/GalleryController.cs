using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Web_first.EfStuff;
using Web_first.EfStuff.DbModel;
using Web_first.EfStuff.Repositories;
using Web_first.Models;



namespace Web_first.Controllers
{
    public class GalleryController : Controller
    {
        private ImageRepository _imageRepository;

        public GalleryController(ImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public IActionResult Index()
        {
            var dbImages = _imageRepository.GetAll();
            var viewModel = dbImages.Select(dbImage => new ImageIndexViewModel
            {
                Id = dbImage.Id,
                Name = dbImage.Name
            }).ToList();
            
            return View(viewModel);
        }

        public IActionResult ShowImage(int id)
        {
            var dbImage = _imageRepository.Get(id);
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

            _imageRepository.Save(dbImage);

            return View();
        }
    }
}
