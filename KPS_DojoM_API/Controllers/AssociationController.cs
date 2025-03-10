﻿using KPS_DojoM_API.Repository;
using KPS_DojoM_models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KPS_DojoM_API.Controllers
{
    [Route("api/[controller]")]
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
            if (id != association.AssociationId)
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
            return CreatedAtAction("GetAssociation", new { id = association.AssociationId }, association);
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssociation(int id)
        { 
            _associationRepository.Delete(id);
            return NoContent();
        }

        //public IActionResult AssociationExists(int id)
        //{
        //    var exists = _associationRepository.All().Any(c => c.Id == id);
        //    if (exists)
        //    {
        //        return Ok();
        //    }
        //    return NotFound();
        //}


    }
}
