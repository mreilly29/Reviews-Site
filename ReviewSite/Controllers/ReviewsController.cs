using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Controllers
{
    public class ReviewsController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
