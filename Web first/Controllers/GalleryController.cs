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
        private ImageCommentRepository _imageCommentRepository;

        public GalleryController(ImageRepository imageRepository, ImageCommentRepository imageCommentRepository)
        {
            _imageRepository = imageRepository;
            _imageCommentRepository = imageCommentRepository;
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
                Id=dbImage.Id,
                Url = dbImage.Url,
                Comments = dbImage.Comments.Select(x => x.Comment).ToList()
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

            var adminComment = new ImageComment
            {
                Comment = "First comment (admin)",
                
            };

            dbImage.Comments = new List<ImageComment>
            {
                adminComment
            };

            _imageRepository.Save(dbImage);

            return View();
        }
        public IActionResult AddComment(int imageId, string text)
        {
            var image = _imageRepository.Get(imageId);
            var comment = new ImageComment
            {
                Comment = text,
                Image = image
            };

            _imageCommentRepository.Save(comment);
            return RedirectToAction("ShowImage", new {id = imageId});
        }
    }
}
