using System.Threading.Tasks;
using finalWS_2015233.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using finalWS_2015233.Models;


namespace finalWS_2015233.Controllers
{
    [Controller]
    [Route("[prj_to_client]")]
    
    public class ProjectToClientController
    {
        private DataContext dc;

        public ProjectToClientController (DataContext context)
        {
            this.dc = context;
        }

        [HttpPost("finalWS_2015233")]
        public async Task<ActionResult> register([FromBody] ProjectToClient ptc)
        {
            dc.prj_to_client.Add(ptc);
            await dc.SaveChangesAsync();
            return Created("Project Assigned Object", ptc); // 1 (?)
        }

        [HttpGet("finalWS_2015233")]
        public async Task<ActionResult> list()
        {
            var data = await dc.prj_to_client.ToListAsync();

            return Ok(data); // 2 (?)
        }

        [HttpGet("finalWS_2015233/{connection_Id}")]
        public ProjectToClient search(int id)
        {
            ProjectToClient ptc = dc.prj_to_client.Find(id);

            return ptc;
        }

        [HttpPut("finalWS_2015233")]
        public async Task<ActionResult> edit([FromBody] ProjectToClient ptc)
        {
            dc.prj_to_client.Update(ptc);
            await dc.SaveChangesAsync();
            return Ok(ptc); // 3 (?)
        }

        [HttpDelete("finalWS_2015233/{connection_Id}")]
        public async Task<ActionResult> delete(int id)
        {
            ProjectToClient ptc = search(id);
            if (ptc == null)
            {
                return NotFound(); //4 (?)
            }
            else
            {
                dc.prj_to_client.Remove(ptc);
                await dc.SaveChangesAsync();
                return Ok(); // 5 (?)
            }
        }

        // [HttpGet("test")]
        // public string test()
        // {
        //     return "I am testing the code one more time...";
        // }    
    }
}
