using System;
using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;
using finalWS_2015233.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using finalWS_2015233.Models;

namespace finalWS_2015233.Controllers
{
    [Controller]
    [Route("[client]")]

    public class SolarisPrjController : ControllerBase
    {
        private DataContext dc;

        public SolarisPrjController(DataContext context)
        {
            this.dc = context;
        }

        [HttpPost("finalWS_2015233")]
        public async Task<ActionResult> register([FromBody] SolarisPrj s_prj)
        {
            dc.solaris_project.Add(s_prj);
            await dc.SaveChangesAsync();
            return Created("Project Object", s_prj);
        }

        [HttpGet("finalWS_2015233")]
        public async Task<ActionResult> list()
        {
            var data = await dc.solaris_project.ToListAsync();

            return Ok(data);
        }

        [HttpGet("finalWS_2015233/{project_Id}")]
        public SolarisPrj search(int id)
        {
            SolarisPrj c = dc.solaris_project.Find(id);

            return c;
        }

        [HttpPut("finalWS_2015233")]
        public async Task<ActionResult> edit([FromBody] SolarisPrj s_prj)
        {
            dc.solaris_project.Update(s_prj);
            await dc.SaveChangesAsync();
            return Ok(s_prj);
        }

        [HttpDelete("finalWS_2015233/{project_Id}")]
        public async Task<ActionResult> delete(int id)
        {
            SolarisPrj s_prj = search(id);
            if (s_prj == null)
            {
                return NotFound();
            }
            else
            {
                dc.solaris_project.Remove(s_prj);
                await dc.SaveChangesAsync();
                return Ok();
            }
        }
        
        // [HttpGet("test")]
        // public string test()
        // {
        //     return "I am testing the code again...";
        // }
    }
}

