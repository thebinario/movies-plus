using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movies_plus.Data;
using movies_plus.Models;
using System.Reflection;
using System;

namespace movies_plus.Controllers
{   
    [ApiController]
    [Route("v1/movies")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Movies>>> Get([FromServices] DataContext context)
        {
            var product = await context.Movies.ToListAsync();
            return product;
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Movies>> GetById([FromServices] DataContext context, int id)
        {
            var movies = await context.Movies
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
            return movies;
        }

        [HttpGet]
        [Route("search/{name}")]
        public async Task<ActionResult<IEnumerable<Movies>>> Search([FromServices] DataContext context, string name)
        {
            IQueryable<Movies> query = context.Movies;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.Name.Contains(name));
            }

            return await query.ToListAsync();
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Movies>> Post(
            [FromServices] DataContext context,
            [FromBody]Movies model)
        {
            if(ModelState.IsValid)
            {
                context.Movies.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        
        [HttpPut]
        [Route("")]
        public void Update(
            [FromServices] DataContext context,
            [FromBody]Movies model)
        {
            if(ModelState.IsValid)
            {
                context.Update(model);
            }
        }
        
        [HttpDelete]
        [Route("{id:int}")]
        public async Task Delete([FromServices] DataContext context, int id)
        {
            context.Remove(context.Movies.Single(a => a.Id == 1));
            context.SaveChanges();
        }
        
    }
}