using IcecekOneriSitesi.Models;
using IcecekOneriSitesi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.Controllers
{
    [AllowAnonymous]
    public class YorumYap : Controller
    {
        YorumlarRepository yorumlarRepository = new YorumlarRepository();
        public IActionResult Index(int id)
        {
            @ViewBag.id = id;
            return View(yorumlarRepository.List(x=>x.YorumOnay==true));
        }
        [HttpGet]
        public IActionResult YorumEkle(int id)
        {
            Yorum deneme = new Yorum();
            deneme.IcecekID = id;
            return View(deneme);
        }
        [HttpPost]
        public IActionResult YorumEkle(Yorum p)
        {
            if (!ModelState.IsValid)
            {
                return View("YorumEkle");
            }
            Yorum y = new Yorum();
            y.IcecekID = p.IcecekID;
            y.YorumIcerik = p.YorumIcerik;
            y.YorumMail = p.YorumMail;
            y.YorumOnay = false;
            y.YorumSahip = p.YorumSahip;

            yorumlarRepository.TAdd(y);
            return RedirectToAction("Index");
        }
    }
}
