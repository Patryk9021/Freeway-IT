using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FreewayIT.Test.DAL;

namespace FreewayIT.Test.Controllers
{
    public class CityController : Controller
    {
        private TestFreewayITEntities db = new TestFreewayITEntities();

        //
        // GET: /City/

        public ActionResult Index()
        {
            return View(db.Cities.ToList());
        }
    }
}