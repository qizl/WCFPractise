using System.Web.Mvc;

namespace WcfClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var studentOperation = new StudentOperation.StudentOperation();
            var students = studentOperation.GetStudents();

            return View(students);
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
    }
}