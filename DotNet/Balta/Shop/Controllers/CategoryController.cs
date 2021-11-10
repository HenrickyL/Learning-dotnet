using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;

namespace Shop.Controllers
{
    [Route("categories")]
    [ApiController]
    public class CategoryController : ControllerBase{
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Get([FromServices] DataContext context){
            try
            {
                 var categories = await context.Categories.AsNoTracking().toListAsync();
                 return Ok(categories);
            }
            catch (Exception)
            {
                
                return BadRequest(new {message = "Não foi possível atualizar a categoria!"});

            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Category>> GetById(int id,[FromServices] DataContext context){
            try
            {
                 var product = await context.Categories.find();
                 return Ok();
            }
            catch (System.Exception)
            {
                
               return BadRequest(new {message = "Não foi possível atualizar a categoria!"});
            }
        
        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Category>> Post([FromBody]Category model, [FromServices] DataContext context){
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
                try{

                    context.Categories.Add(model);
                    await context.SaveChangesAsync();
                    return Ok(model);
                }catch{
                    return BadRequest(new {message = "Não foi possível criar a categoria"});
                }
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Category>> Put(int id, [FromBody]Category model, [FromServices] DataContext context){
            if(id != model.Id)
                return NotFound(new {message= "Categoria não encontrada"});
            if( !ModelState.IsValid)
                return BadRequest(ModelState);
                try
                {
                     context.Entry<Category>(model).State = EntityState.Modified;
                     await context.SaveChangesAsync();
                     return Ok(model);
                }catch(DbUpdateConcurrencyException){
                    
                    return BadRequest(new {message = "Este registro já foi atualizado!"});
                }catch (Exception){
                    return BadRequest(new {message = "Não foi possível atualizar a categoria!"});

                }
                
            return Ok(model);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Category>> Delete(int id,[FromServices] DataContext context){
            try
            {
                var Category = await context.Categories.FirstOrDefaultAsync(x=>x.Id == id);
                if(Category == null)
                    return NotFound(new {message = "Categria não encontrada"});

                context.Categories.Remove(Category);
                await context.SaveChangesAsync();

                return Ok(Category);//model.Id == id?  model: null;
            }
            catch (Exception)
            {
                
                return BadRequest(new {message = "Não foi possível deletar a categoria!"});

            }
            
        }







    }
   
}