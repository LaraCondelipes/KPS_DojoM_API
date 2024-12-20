﻿using KPS_DojoM_API.Repository;
using KPS_DojoM_models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KPS_DojoM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
      public readonly IRepository<Categories> _categoriesRepository;

      public CategoriesController(IRepository<Categories> categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        //Get
        [HttpGet]
        public IEnumerable<Categories> GetCategories()
        { 
            return _categoriesRepository.All();
        }

        //Get : Categories/id
        [HttpGet("{id}")]
        public Categories GetCategories(int id)
        { 
            var categories = _categoriesRepository.GetValue(id);
            return categories;
        }

        //Put 
        [HttpPut("{id}")]
        public void PutCategories(int id, Categories categories)
        {
            if (id != categories.CategoriesId)
            {
                return;
            }
            try
            {
                _categoriesRepository.Update(categories);

            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return;
        }

        //Post
        [HttpPost]
        public async Task<ActionResult<Categories>> PostCategories(Categories categories)
        { 
            _categoriesRepository.Add(categories);
            return CreatedAtAction("GetCategories", new { id = categories.CategoriesId }, categories);
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategories(int id)
        {
            _categoriesRepository.Delete(id);
            return NoContent();
        }

        //public IActionResult CategoriesExists(int id)
        //{
        //    var exists = _categoriesRepository.All().Any(c => c.Id == id);
        //    if (exists)
        //    {
        //        return Ok();
        //    }
        //    return NotFound();
        //}
    }
}
