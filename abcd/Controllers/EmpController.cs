using abcd.Data;
using abcd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace abcd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        
        
        private readonly EmpDbcontext empname;



        public EmpController(EmpDbcontext empname)
        {
            this.empname = empname;
        }

        [HttpGet]

        
        public async Task<ActionResult<IEnumerable<Emp>>> Getemp()
        {
            var getdata = await empname.tableemp.ToListAsync();
            return Ok(getdata);
        }


        [HttpPost]

        public async Task<Emp> postempuser(Emp objemp)
        {
            empname.tableemp.Add(objemp);
            await empname.SaveChangesAsync();
            return objemp;
        }


        [HttpGet]

        [Route("name")]

        public async Task<ActionResult<IEnumerable<Emp>>> Getsemp()
        {
            var getdata = await empname.tableemp.Select(s => new{ s.name ,s.id,s.phno} ).ToListAsync();
            return Ok(getdata);
        }

    }

    
}