using KPS_DojoM_API.Repository;
using KPS_DojoM_models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace KPS_DojoM_API.Controllers
{
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

        //Put
        [HttpPut("{id}")]
        public void PutChampionships(int id, Championships championships)
        {
            if (id != championships.Id)
            {
                return;
            }
            try
            {
                _championshipsRepository.Update(championships);
            }
            catch (DBConcurrencyException)
            {
                throw;
            }

            return;

        }

        //Post
        [HttpPost]
        public async Task<ActionResult<Championships>> PostChampionships(Championships championships)
        { 
            _championshipsRepository.Add(championships);
            return CreatedAtAction("GetChampionships", new { id = championships.Id }, championships);

        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampioships(int id)
        {
            _championshipsRepository.Delete(id);
            return NoContent();
        }

        public bool ChampionshipsExists(int id)
        { 
            return _championshipsRepository.All().Any(c => c.Id == id);
        }
    }
}
