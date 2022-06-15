using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PeopleContext _db;

        public PersonController(PeopleContext db)
        {
            _db = db;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Person> GetPeople()
        {
            return _db.Persons
                .Include(x => x.Contracts)
                .Include(x => x.HomeAddress);
        }

        // hledani osoby podle emailu
        [HttpGet("{id}")]
        public Person GetById(int id)
        {
            return _db.Persons.Include(x => x.Contracts)
                .Include(x => x.HomeAddress)
                .FirstOrDefault(p => p.Id == id);

        }

        // hledani osoby podle emailu
        [HttpGet("ByEmail/{email}")]
        public Person GetByEmail(string email)
        {
            return _db.Persons.Include(x => x.Contracts)
                .Include(x => x.HomeAddress)
                .Where(p => p.Email.ToLower() == email.ToLower()).FirstOrDefault();
        }

    }
}
