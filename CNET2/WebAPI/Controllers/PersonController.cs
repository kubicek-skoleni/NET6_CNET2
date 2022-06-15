using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        [HttpGet("GetAll")]
        public List<Person> GetPeople()
        {
            var dataset = Data.Serialization.LoadFromXML(@"C:\Users\StudentEN\source\repos\kubicek-skoleni\PersonDataset\dataset.xml");
            return dataset;
        }

    }
}
