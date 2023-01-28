using Amazon.Runtime.Internal.Util;
using IdentityServer3.Core.ViewModels;
using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portifolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {

            return View();
        }

        public ActionResult Projetos()
        {

            return View();
        }

        public ActionResult Skills()
        {

            return View();
        }

        public ActionResult Contato()
        {

            return View();
        }

        public ActionResult Jornada()
        {

            return View();
        }

    }
}