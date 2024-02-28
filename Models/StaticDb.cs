using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace Scarpe___Co.Models
{
    public static class StaticDb
    {
        private static int _maxId = 3;
        private static List<Shoes> _shoes = [
            new Shoes() { ShoesId = 1, Name = "Nike", Price= 150, Description = "Scarpe sportive", ImgCopertina = "Img", Img1 = "img", Img2 = "img", },
            new Shoes() { ShoesId = 2, Name = "Adidas", Price = 1500, Description = "Trekking", ImgCopertina = "Img", Img1 = "Img", Img2 = "Img", },
            new Shoes() { ShoesId = 2, Name = "Nike", Price = 1500, Description = "Total90, calcetto", ImgCopertina = "Img", Img1 = "Img", Img2 = "Img", },

            ];
        public static List<Shoes> GetAll()
        {
            foreach (var shoe in _shoes)
            {
            }
            return _shoes;
        }
        public static Shoes Add(string Name, int Price, string Description, string ImgCopertina, string Img1, string Img2)
        {
            _maxId++;
            var shoes = new Shoes() { ShoesId = _maxId, Name = Name, Description = Description, Price = Price, ImgCopertina = ImgCopertina, Img1 = Img1, Img2 = Img2 };
            _shoes.Add(shoes);
            return shoes;
        }
        [HttpGet]
        public static Edit([FromRoute] int? ShoesId)
        {
            if(ShoesId is null) return RedirectToAction("Index", "Shoes");
        }
}
