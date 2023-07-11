using IcecekOneriSitesi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IcecekOneriSitesi.Models;
namespace IcecekOneriSitesi.Controllers
{
    public class Kategoriler : Controller
    {
        KategorilerRepository kategorilerRepository = new KategorilerRepository();
        public IActionResult Index()
        {
            
            return View(kategorilerRepository.TList());
        }
        [HttpGet]
        public IActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KategoriEkle(Kategori p)
        {
            if(!ModelState.IsValid)
            {
                return View("KategoriEkle");
            }
            kategorilerRepository.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult KategoriGet(int id)
        {
            var x = kategorilerRepository.TGet(id);
            Kategori ct = new()
            {
                KategoriID = x.KategoriID,
                KategoriAd = x.KategoriAd,
                KategoriAdet = x.KategoriAdet,
                KategoriAciklama = x.KategoriAciklama,
                KategoriDurum = x.KategoriDurum
            };
            return View(ct);
        }
        [HttpPost]
        public IActionResult KategoriGüncelle(Kategori p)
        {
            var x = kategorilerRepository.TGet(p.KategoriID);
            x.KategoriAd = p.KategoriAd;
            x.KategoriAdet = p.KategoriAdet;
            x.KategoriAciklama = p.KategoriAciklama;
            kategorilerRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

        public IActionResult KategoriDurumTrue(int id)
        {
            var x = kategorilerRepository.TGet(id);
            x.KategoriDurum = true;
            kategorilerRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult KategoriDurumFalse(int id)
        {
            var x = kategorilerRepository.TGet(id);
            x.KategoriDurum = false;
            kategorilerRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
