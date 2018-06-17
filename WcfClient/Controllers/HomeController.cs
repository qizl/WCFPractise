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
    }
}