using IcecekOneriSitesi.Models;
using IcecekOneriSitesi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.Controllers
{
    public class Yorumlar : Controller
    {
        YorumlarRepository yorumlarRepository = new YorumlarRepository();
        public IActionResult Index()
        {
            return View(yorumlarRepository.TList("Icecek"));
        }
        public IActionResult YorumlarGet(int id)
        {
            var x = yorumlarRepository.TGet(id);
            Yorum yr = new()
            {
                YorumID=x.YorumID,
                YorumSahip=x.YorumSahip,
                YorumMail=x.YorumMail,
                YorumTarih=x.YorumTarih,
                YorumOnay=x.YorumOnay,
                YorumIcerik=x.YorumIcerik,
                IcecekID=x.IcecekID
            };
            IceceklerRepository ıceceklerRepository = new IceceklerRepository();
            Icecek deneme = ıceceklerRepository.TGet(yr.IcecekID);
            ViewBag.ad = deneme.IcecekAd;
            return View(yr);
        }
        [HttpPost]
        public IActionResult YorumGüncelle(Yorum p)
        {
            var x = yorumlarRepository.TGet(p.YorumID);
            x.YorumSahip = p.YorumSahip;
            x.YorumMail = p.YorumMail;
            x.YorumOnay = p.YorumOnay;
            x.YorumIcerik = p.YorumIcerik;
            yorumlarRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult YorumDurumTrue(int id)
        {
            var x = yorumlarRepository.TGet(id);
            x.YorumOnay = true;
            yorumlarRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult YorumDurumFalse(int id)
        {
            var x = yorumlarRepository.TGet(id);
            x.YorumOnay = false;
            yorumlarRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

    }
}
