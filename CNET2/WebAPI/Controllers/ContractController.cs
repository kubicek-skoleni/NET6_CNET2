using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        [HttpGet("GetAll")]
        public IEnumerable<Contract> GetAll()
        {
            var dataset = Data.Serialization.LoadFromXML(@"C:\Users\StudentEN\source\repos\kubicek-skoleni\PersonDataset\dataset.xml");
            return dataset.SelectMany(x => x.Contracts);
        }
    }
}
