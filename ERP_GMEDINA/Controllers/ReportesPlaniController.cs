﻿using ERP_GMEDINA.DataSet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ERP_GMEDINA.Models;

namespace ERP_GMEDINA.Controllers
{
    public class ReportesPlaniController : Controller
    {
		private ERP_GMEDINAEntities db = new ERP_GMEDINAEntities();

		// GET: ReportesPlani
		public ActionResult Index()
        {
            return View();
        }


		

	}
}