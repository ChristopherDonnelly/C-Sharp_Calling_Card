using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace Calling_Card.Controllers
{
    public class CallingCardController : Controller
    {
        // A GET method
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "Hello World!";
        }

        [HttpGet]
        [Route("/{firstName}/{lastName}/{age}/{favColor}")]
        public JsonResult Method(string firstName, string lastName, string age, string favColor)
        {
            var AnonObject = new {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                FavoriteColor = favColor
            };

            return Json(AnonObject);
        }
      
    }
}