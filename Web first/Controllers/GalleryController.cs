using Microsoft.AspNetCore.Mvc;
using System;
using Web_first.Models;


namespace Web_first.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var day = new GalleryIndexVeiwModel();

            day.MounthName = DateTime.Now.ToString("MMM");
            day.DayOfWeek =(int)DateTime.Now.DayOfWeek;
            day.Seconds =DateTime.Now.Second;

            return View(day);
        }
    }
}
