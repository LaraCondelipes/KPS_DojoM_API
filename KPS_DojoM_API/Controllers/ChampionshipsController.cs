using KPS_DojoM_API.Repository;
using KPS_DojoM_models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.Data;
using System.Web.Http.OData;

namespace KPS_DojoM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionshipsController : ControllerBase
    {

        public readonly IRepository<Championships> _championshipsRepository;

        public ChampionshipsController(IRepository<Championships> championshipsRepository)
        {
            _championshipsRepository = championshipsRepository;
        }

        //Get
        [HttpGet]
        public IEnumerable<Championships> GetChampionships()
        {
            return _championshipsRepository.All();
        }

        //Get : Championships/id
        [HttpGet("{id}")]
        public Championships GetChampionships(int id)
        {
            var championships = _championshipsRepository.GetValue(id);
            return championships;
        }

        //Post
        [HttpPost]
        public async Task<ActionResult<Championships>> PostChampionships(Championships championships)
        {
            _championshipsRepository.Add(championships);
            return CreatedAtAction("GetChampionships", new { id = championships.ChampionshipsId }, championships);

        }



        //Put
        [HttpPut("{id}")]
        public void PutChampionships(int id, Championships championships)
        {
            if (id != championships.ChampionshipsId)
            {
                return;
            }
            try
            {
                _championshipsRepository.Update(championships);

            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return;
        }


        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampioships(int id)
        {
            _championshipsRepository.Delete(id);
            return NoContent();
        }

        //public IActionResult ChampionshipsExists(int id)
        //{ 
        //    var exists = _championshipsRepository.All().Any(c => c.Id == id);
        //    if (exists)
        //    { 
        //        return Ok();
        //    }
        //    return NotFound();
        //}
    }
}
