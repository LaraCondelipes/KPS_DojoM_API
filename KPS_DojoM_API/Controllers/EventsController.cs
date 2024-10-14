using KPS_DojoM_API.Repository;
using KPS_DojoM_models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace KPS_DojoM_API.Controllers
{
    [Route("api/[events]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        public readonly IRepository<Events> _eventsRepository;

        public EventsController(IRepository<Events> eventsRepository)
        { 
            _eventsRepository = eventsRepository;
        }

        //Get
        [HttpGet]
        public IEnumerable<Events> GetEvents()
        { 
            return _eventsRepository.All();

        }

        //Get Events/id
        [HttpGet("{id}")]
        public Events GetEvents(int id)
        {
            var events = _eventsRepository.GetValue(id);
            return events;
        }

        //Put
        [HttpPut("{id}")]
        public void PutEvents(int id, Events events)
        {
            if (id != events.Id)
            {
                return;
            }
            try
            {
                _eventsRepository.Update(events);
            }
            catch (DBConcurrencyException)
            {
                throw;
            }

            return;
        }

        //Post
        [HttpPost]
        public async Task<ActionResult<Events>> PostEvents(Events events)
        { 
            _eventsRepository.Add(events);
            return CreatedAtAction("GetEvents", new { id = events.Id }, events);
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvents(int id)
        {
            _eventsRepository.Delete(id);   
            return NoContent();
        }

        private bool EventsExits(int id)
        { 
            return _eventsRepository.All().Any(e => e.Id == id);
        }
    }
}
