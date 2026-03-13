using First_API_.Net.Models;
using Microsoft.AspNetCore.Mvc;

namespace First_API_.Net.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("api/person")]
        public ActionResult<Person> ListPerson()
        {
            PersonContext context = new PersonContext();
            List <Person> listPerson = context.ListPerson();
            return Ok(listPerson);
        }
    }
}
