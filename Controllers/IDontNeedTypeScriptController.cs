﻿using Microsoft.AspNetCore.Mvc;

namespace TestProject.Web.Controllers
{
    public class IDontNeedTypeScriptController : Controller
    {
        /// <summary>
        /// SPA entry point
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}