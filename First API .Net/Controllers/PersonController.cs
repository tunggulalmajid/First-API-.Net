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

        [HttpGet("api/person/{idPerson}")]
        public ActionResult<Person> GetDataPerson(int idPerson)
        {
            PersonContext context = new PersonContext();
            Person data = context.GetDataPerson(idPerson);
            if (data != null) 
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
