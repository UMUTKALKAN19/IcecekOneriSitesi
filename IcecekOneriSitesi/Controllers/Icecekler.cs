using IcecekOneriSitesi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IcecekOneriSitesi.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace IcecekOneriSitesi.Controllers
{
    public class Icecekler : Controller
    {
        IceceklerRepository iceceklerRepository = new IceceklerRepository();
        Context c = new Context();
        public IActionResult Index(int page=1)
        {
            return View(iceceklerRepository.TList("Kategori").ToPagedList(page,4));
        }
        [HttpGet]
        public IActionResult IcecekEkle()
        {
            List<SelectListItem> values = (from x in c.Kategorilers.ToList().Where(x => x.KategoriDurum == true)
                                           select new SelectListItem
                                           {
                                               Text = x.KategoriAd,
                                               Value = x.KategoriID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }
        [HttpPost]
        public IActionResult IcecekEkle(Icecek p)
        {
            iceceklerRepository.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult IcecekSil(int id)
        {
            iceceklerRepository.TDelete(new Icecek { IcecekID = id });
            return RedirectToAction("Index");
        }

        public IActionResult IcecekGet(int id)
        {
            var x = iceceklerRepository.TGet(id);
            List<SelectListItem> values = (from y in c.Kategorilers.ToList().Where(x => x.KategoriDurum == true)
                                           select new SelectListItem
                                           {
                                               Text = y.KategoriAd,
                                               Value = y.KategoriID.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            Icecek p = new Icecek()
            {
                KategoriID=x.KategoriID,
                IcecekID=x.IcecekID,
                IcecekAd=x.IcecekAd,
                IcecekCesit=x.IcecekCesit,
                IcecekMalzeme=x.IcecekMalzeme,
                IcecekResim=x.IcecekResim,
                IcecekTarif=x.IcecekTarif,
                IcecekTarih=x.IcecekTarih
            };
            return View(p);
        }

        [HttpPost]
        public IActionResult IcecekGuncelle(Icecek p)
        {
            var x = iceceklerRepository.TGet(p.IcecekID);
            x.IcecekAd = p.IcecekAd;
            x.IcecekMalzeme = p.IcecekMalzeme;
            x.IcecekTarif = p.IcecekTarif;
            x.IcecekCesit = p.IcecekCesit;
            x.IcecekResim = p.IcecekResim;
            x.KategoriID = p.KategoriID;
            iceceklerRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
    }
}
