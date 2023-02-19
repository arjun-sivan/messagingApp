using BackEnd.Context;
using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class UsersController : Controller
    {
        private readonly EmployeeDBContext _dbContext;
        public UsersController(EmployeeDBContext employeeDBContext)
        {
            _dbContext = employeeDBContext;
        }


        [HttpGet]
        public async  Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            var users = await _dbContext.User.ToListAsync();
            return users;
        }

        [HttpGet("{id}")]
        public async  Task<ActionResult<User>> GetUser(int id)
        {
          return   _dbContext.User.Find(id);           
        }
    }
}
