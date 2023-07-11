using IcecekOneriSitesi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.ViewComponents
{
    public class IcecekDetaySayfasi:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            IceceklerRepository ıceceklerRepository = new IceceklerRepository();
            var iceceklist = ıceceklerRepository.List(x => x.IcecekID == id);
            return View(iceceklist);
        }
    }
}
