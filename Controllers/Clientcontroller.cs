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
    [Route("[solarprj]")]
        
    public class Clientcontroller : ControllerBase
    {
        private DataContext dc;

        public Clientcontroller(DataContext context)
        {
            this.dc = context;
        }

        [HttpPost("finalWS_2015233")]
        public async Task<ActionResult> register([FromBody] Client c)
        {
            dc.client.Add(c);
            await dc.SaveChangesAsync();
            return Created("Client Object", c);
        }

        [HttpGet("finalWS_2015233")]
        public async Task<ActionResult> list()
        {
            var data = await dc.client.ToListAsync();

            return Ok(data);
        }

        [HttpGet("finalWS_2015233/{client_Id}")]
        public Client search(int id)
        {
            Client c = dc.client.Find(id);

            return c;
        }

        [HttpPut("finalWS_2015233")]
        public async Task<ActionResult> edit([FromBody] Client c)
        {
            dc.client.Update(c);
            await dc.SaveChangesAsync();
            return Ok(c);
        }

        [HttpDelete("finalWS_2015233/{client_Id}")]
        public async Task<ActionResult> delete(int id)
        {
            Client c = search(id);
            if (c == null)
            {
                return NotFound();
            }
            else
            {
                dc.client.Remove(c);
                await dc.SaveChangesAsync();
                return Ok();
            }
        }

        // [HttpGet("test")]
        // public string test()
        // {
        //     return "I am testing the code";
        // }
    }
}