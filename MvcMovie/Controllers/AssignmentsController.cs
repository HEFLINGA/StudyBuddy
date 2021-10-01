using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class AssignmentsController : Controller
    {
        // 
        // GET: /Assignments/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Assignments/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}