using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using muster.Models;

namespace muster.Controllers
{
    public class MusterController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View(_db.Camps.ToList());
        }

        public ActionResult Monitor()
        {
            return View(_db.Camps.ToList());
        }

        public JsonResult StartMuster(int campId)
        {
            Camp camp = _db.Camps.Find(campId);
            camp.ActiveMuster = new MusterEvent
            {
                Camp = camp,
                CampId = camp.Id,
                StartTime = DateTime.Now
            };
            return Json(camp);
        }
    }
}