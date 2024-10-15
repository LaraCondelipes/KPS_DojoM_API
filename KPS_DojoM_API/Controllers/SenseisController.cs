using KPS_DojoM_API.Repository;
using KPS_DojoM_models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace KPS_DojoM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SenseisController : ControllerBase
    {
        public readonly IRepository<Senseis> _senseisRepository;

        public SenseisController(IRepository<Senseis> senseisRepository)
        {
            _senseisRepository = senseisRepository;
        }

        //Get
        [HttpGet]
        public IEnumerable<Senseis> GetSenseis()
        {
            return _senseisRepository.All();

        }

        //Get : Senseis/id
        [HttpGet("{id}")]
        public Senseis GetSenseis(int id)
        { 
            var Senseis = _senseisRepository.GetValue(id);
            return Senseis;
        }

        //Put
        [HttpPut("{id}")]
        public void PutSenseis(int id, Senseis senseis)
        {
            if (id != senseis.Id)
            {
                return;
            }
            try
            {
                _senseisRepository.Update(senseis);
            }
            catch (DBConcurrencyException)
            {
                throw;
            }

            return;

        }

        //Post
        [HttpPost]
        public async Task<ActionResult<Senseis>> PostSenseis(Senseis senseis)
        { 
            _senseisRepository.Add(senseis);
            return CreatedAtAction("GetSenseis", new { id = senseis.Id }, senseis);
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSenseis(int id)
        {
            _senseisRepository.Delete(id);
            return NoContent();
        }

        //public IActionResult SenseisExists(int id)
        //{
        //    var exists = _senseisRepository.All().Any(c => c.Id == id);
        //    if (exists)
        //    {
        //        return Ok();
        //    }
        //    return NotFound();
        //}
    }
}
