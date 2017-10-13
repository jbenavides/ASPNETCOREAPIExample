using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.CityInfo.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>()
            {
                new  {id =1, Name = "City1" },
                new  {id =3, Name = "City2" }
            });
        }

    }
}
