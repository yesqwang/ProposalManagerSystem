
using ProposalManageSystem.Models.Bean;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace ProposalManageSystem.Controllers {
    public class LayoutController : Controller {
        // GET: Demo01
        public ActionResult Index () {
            return View();
        }

        //接收Ajax测试
        public string getAboutData () {
            PageAbout pa = new PageAbout();
            
            return "hello world!";
        }
    }
}