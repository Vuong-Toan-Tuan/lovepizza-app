﻿using Microsoft.AspNetCore.Mvc;
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
            //return new string[] { "value1", "value2" };
            return await _dbContext.PizzaVotes.ToListAsync();
        }

        // GET api/<PizzaVoteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PizzaVoteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PizzaVoteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PizzaVoteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
