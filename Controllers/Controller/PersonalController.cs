﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProposalManageSystem.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        public ActionResult Index()
        {
            return View("personal");
        }
    }
}