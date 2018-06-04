using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CallingCard.Controllers
{
    public class CallController : Controller
    {
        [HttpGet]
        [Route("{firstName}/{lastName}/{age}/{color}")]
        public IActionResult ReturnJson(string firstName, string lastName, int age, string color)
        {
            var AnonObject = new 
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Color = color
            };
            return Json(AnonObject);
        }
    }
}