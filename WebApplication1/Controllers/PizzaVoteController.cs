using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaVoteController : ControllerBase
    {
        private DatabaseContext _dbContext;
        public PizzaVoteController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/<PizzaVoteController>
        [HttpGet]
        public async Task<ActionResult<List<PizzaVote>>> Get()
        {
            
            return await _dbContext.PizzaVotes.ToListAsync();
        }

        // GET api/<PizzaVoteController>/{email}
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<PizzaVote>> Get(string id)
        {
            return await _dbContext.PizzaVotes.FindAsync(id);
        }

        // POST api/<PizzaVoteController>
        [Authorize]
        [HttpPost]
        public async Task Post(PizzaVote model)
        {
            await _dbContext.AddAsync(model);
            await _dbContext.SaveChangesAsync();
        }

        // PUT api/<PizzaVoteController>/5
        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, PizzaVote model)
        {
            var exists = await _dbContext.PizzaVotes.AnyAsync(f => f.Id == id);
            if (!exists)
            {
                return NotFound();
            }

            _dbContext.PizzaVotes.Update(model);

            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        // DELETE api/<PizzaVoteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
