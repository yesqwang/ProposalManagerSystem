using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProposalManageSystem.Controllers
{
    public class MineController : Controller
    {
        // GET: Mine
        public ActionResult Index()
        {
            return View("mine");
        }
    }
}