using KPS_DojoM_API.Repository;
using KPS_DojoM_models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace KPS_DojoM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheResultsController : ControllerBase
    {
        public readonly IRepository<TheResults> _theresultsRepository;

        public TheResultsController(IRepository<TheResults> theresultsRepository)
        {
            _theresultsRepository = theresultsRepository;
        }

        //Get
        [HttpGet]
        public IEnumerable<TheResults> GetTheResults()
        { 
          return  _theresultsRepository.All();
        }

        //Get TheResults/id
        [HttpGet("{id}")]
        public TheResults GetTheResults(int id)
        { 
            var theresults = _theresultsRepository.GetValue(id);
            return theresults;
        }

        //Put
        [HttpPut("{id}")]
        public void PutTheResults(int id,TheResults theresults)
        {
            if (id != theresults.Id)
            {
                return;
            }
            try
            {
                _theresultsRepository.Update(theresults);
            }
            catch (DBConcurrencyException)
            {
                throw;
            }

            return;
        }

        //Post
        [HttpPost]
        public async Task<ActionResult<TheResults>> PostTheResults(TheResults theresults)
        { 
            _theresultsRepository.Add(theresults);
            return CreatedAtAction("GetTheRersults", new { id = theresults.Id}, theresults);
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTheResults(int id)
        {
            _theresultsRepository.Delete(id);
            return NoContent();
        }

        //public IActionResult TheResultsExists(int id)
        //{
        //    var exists = _theresultsRepository.All().Any(c => c.Id == id);
        //    if (exists)
        //    {
        //        return Ok();
        //    }
        //    return NotFound();
        //}



    }
}
