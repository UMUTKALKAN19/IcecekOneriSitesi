using IcecekOneriSitesi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.ViewComponents
{
    public class IcecekGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            IceceklerRepository ıceceklerRepository = new IceceklerRepository();
            var iceceklist = ıceceklerRepository.TList();
            return View(iceceklist);
        }
    }
}
