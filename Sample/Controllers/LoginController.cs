using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sample.Data;
using Sample.Models;


namespace Sample.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]

        public async Task<IActionResult> Login(string email,string password)
        {
            try
            {
                LoginModel olduser = _context.SignUp.Where(user1 => user1.EmailId == email).FirstOrDefault()!; 

                if (olduser.EmailId == email && olduser != null)
                {
                    if (olduser.Password == password)
                    {
                        return Ok("{\"emailstatus\":true,\"passwordstatus\":true}");
                    }
                    else
                    {
                        return Ok("{\"emailstatus\":true,\"passwordstatus\":false}");
                    }
                }
            }
            catch (Exception ex)
            {
                return Ok("{\"emailstatus\":false,\"passwordstatus\":false}");

            }
            return Ok("{\"emailstatus\":false,\"passwordstatus\":false}");


        }



        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetSingle(int id)
        //{
        //    if (id == null)
        //    {
        //        return BadRequest();
        //    }
        //    var user = await _context.SignUp.FindAsync(id);
        //    if (user == null)
        //        return NotFound();
        //    return Ok(user);
        //}
    }
}

