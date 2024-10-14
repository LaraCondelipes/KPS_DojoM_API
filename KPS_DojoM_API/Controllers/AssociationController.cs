using KPS_DojoM_API.Repository;
using KPS_DojoM_models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KPS_DojoM_API.Controllers
{
    [Route("api/[association]")]
    [ApiController]
    public class AssociationController : ControllerBase
    {
        private readonly IRepository<Association> _associationRepository;

        public AssociationController(IRepository<Association> associationRepository)
        {
            _associationRepository = associationRepository;
        }

        //Get
        [HttpGet]
        public IEnumerable<Association> GetAssociation()
        {
            return _associationRepository.All();
        }

        //Get : api/Association/id
        [HttpGet("{id}")]
        public Association GetAssociation(int id)
        {
            var association = _associationRepository.GetValue(id);
            return association;
        }

        //Put
        [HttpPut("{id}")]
        public void PutAssociation(int id, Association association)
        {
            if (id != association.Id)
            { 
                return;
            }
            try
            {
                _associationRepository.Update(association);
            }
            catch (DbUpdateConcurrencyException) 
            {
                throw;
            }

            return;
        }

        //Post
        [HttpPost]
        public async Task<ActionResult<Association>> PostAssociation(Association association)
        {
            _associationRepository.Add(association);
            return CreatedAtAction("GetAssociation", new { id = association.Id }, association);
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssociation(int id)
        { 
            _associationRepository.Delete(id);
            return NoContent();
        }

        private bool AssociationExists(int id)
        {
            return _associationRepository.All().Any(x => x.Id == id);
        }


    }
}
