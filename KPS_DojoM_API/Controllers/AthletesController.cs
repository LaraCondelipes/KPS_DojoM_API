using KPS_DojoM_API.Repository;
using KPS_DojoM_models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KPS_DojoM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AthletesController : ControllerBase
    {
        private readonly IRepository<Athletes> _athletesRepository;

        public AthletesController(IRepository<Athletes> athletesRepository)
        {
            _athletesRepository = athletesRepository;
        }

        //Get 
        [HttpGet]
        public IEnumerable<Athletes> GetAthletes()
        {
            return _athletesRepository.All();
        }

        //Get : Athletes/id
        [HttpGet("{id}")]
        public Athletes GetAthlete(int id)
        {
            var atheletes = _athletesRepository.GetValue(id);
            return atheletes;
        }

        //Put
        [HttpPut("{id}")]
        public void PutAthletes(int id, Athletes athletes)
        {
            if (id != athletes.AthletesId)
            {
                return;
            }
            try
            {
                _athletesRepository.Update(athletes);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return;
        }

        //Post
        [HttpPost]
        public async Task<ActionResult<Athletes>> PostAthletes(Athletes athletes)
        {
         _athletesRepository.Add(athletes);
        return CreatedAtAction("GetAthletes", new { id = athletes.AthletesId}, athletes);
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAthletes(int id)
        {
            _athletesRepository.Delete(id);
            return NoContent();
        }

        //public IActionResult AthletesExists(int id)
        //{
        //    var exists = _athletesRepository.All().Any(c => c.Id == id);
        //    if (exists)
        //    {
        //        return Ok();
        //    }
        //    return NotFound();
        //}


    }

}

        
