using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IUrunHizmet _urunHizmet;
        public HomeController(IUrunHizmet urunHizmet)
        {
            _urunHizmet = urunHizmet;
        }
        public IActionResult Index()
        {
            return View(_urunHizmet.GetAll());
        }
    }
}
