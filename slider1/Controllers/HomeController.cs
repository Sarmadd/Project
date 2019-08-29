using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace slider1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Umrah()
        {
            ViewBag.Message = "Your Umrah page.";

            return View();
        }

        public ActionResult Hajj()
        {
            ViewBag.Message = "Your Hajj page.";

            return View();
        }


        public ActionResult Ziyarat()
        {
            ViewBag.Message = "Your Ziyarat page.";

            return View();
        }

        public ActionResult LocalTour()
        {
            ViewBag.Message = "Your Local Tour page.";

            return View();
        }

        public ActionResult InternationalTour()
        {
            ViewBag.Message = "Your International Tour page.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Your Services page.";

            return View();
        }

        public ActionResult Branches()
        {
            ViewBag.Message = "Your Branches page.";

            return View();
        }

        public ActionResult Ticket()
        {
            ViewBag.Message = "Ticket Page";
            return View();
        }

        public ActionResult SearchUmrah()
        {
            ViewBag.Message = "Your Search Umrah page.";

            return View();
        }

        public ActionResult UmrahRegistration()
        {
            ViewBag.Message = "Your Umrah Registration page.";

            return View();
        }

        public ActionResult SearchHajj()
        {
            ViewBag.Message = "Your Hajj Registration page.";

            return View();
        }

        public ActionResult SearchZiyarat()
        {
            ViewBag.Message = "Your Hajj Registration page.";

            return View();
        }

        public ActionResult SearchLocalTour()
        {
            ViewBag.Message = "Your Local Registration page.";

            return View();
        }

        public ActionResult SearchInternationalTour()
        {
            ViewBag.Message = "Your International Registration page.";

            return View();
        }

        public ActionResult DashboardAgentUmrahView()
        {
            ViewBag.Message = "Your Dashboard page.";

            return View();
        }

        public ActionResult DashboardAgentHajjView()
        {
            ViewBag.Message = "Your Dashboard page.";

            return View();
        }

        public ActionResult DashboardAgentZiyaratView()
        {
            ViewBag.Message = "Your Dashboard page.";

            return View();
        }

        public ActionResult DashboardAgentLocalView()
        {
            ViewBag.Message = "Your Dashboard page.";

            return View();
        }

        public ActionResult DashboardAgentInternationalView()
        {
            ViewBag.Message = "Your Dashboard page.";

            return View();
        }

        public ActionResult Registration()
        {
            ViewBag.Message = "Your Register page.";

            return View();
        }

        public ActionResult DashboardAdminUmrahView()
        {
            ViewBag.Message = "Your Register page.";

            return View();
        }

        public ActionResult DashboardAdminHajjView()
        {
            ViewBag.Message = "Your Register page.";

            return View();
        }

        public ActionResult DashboardAdminZiyaratView()
        {
            ViewBag.Message = "Your Register page.";

            return View();
        }

    }
}