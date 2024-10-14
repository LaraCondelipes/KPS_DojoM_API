using KPS_DojoM_API.Repository;
using KPS_DojoM_models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace KPS_DojoM_API.Controllers
{
    [Route("api/[parents]")]
    [ApiController]
    public class ParentsController : ControllerBase
    {
        public readonly IRepository<Parents> _parentsRepository;

        public ParentsController(IRepository<Parents> parentsRepository)
        {
            _parentsRepository = parentsRepository;

        }

        //Get
        [HttpGet]
        public IEnumerable<Parents> GetParents()
        { 
           return _parentsRepository.All();
        }

        //Get Parents/id
        [HttpGet("{id}")]
        public Parents GetParents(int id)
        {
            var parents = _parentsRepository.GetValue(id);
            return parents;
        }

        //Put
        [HttpPut("{id}")]
        public void PutParents(int id, Parents parents)
        {
            if (id != parents.Id)
            {
                return;
            }
            try
            {
                _parentsRepository.Update(parents);
            }
            catch (DBConcurrencyException)
            {
                throw;
            }

            return;
        }

        //Post
        [HttpPost]
        public async Task<ActionResult<Parents>> PostParents(Parents parents)
        {
            _parentsRepository.Add(parents);
            return CreatedAtAction("GetParents", new { id = parents.Id }, parents);
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteParents(int id)
        { 
            _parentsRepository.Delete(id);
            return NoContent();
        }

        private bool ParentsExists(int id)
        { 
            return _parentsRepository.All().Any(p => p.Id == id);
        }
    }
}
