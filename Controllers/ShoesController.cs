using Microsoft.AspNetCore.Mvc;
using Scarpe___Co.Models;

namespace Scarpe___Co.Controllers
{
    public class ShoesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(StaticDb.GetAll());
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(string Name, int Price, string Description, string ImgCopertina, string Img1, string Img2)
        {
            var Shoes = StaticDb.Add(Name, Price, Description, ImgCopertina, Img1, Img2);
            return View(Shoes);
        }
        public IActionResult Edit(Shoes shoes)
        {
            var upadateShoes = StaticDb.Modify(shoes);
            if (upadateShoes is null) return View("Error");

            return RedirectToAction("Details", new { id = upadateShoes.ShoesId });

        }
    }
}
