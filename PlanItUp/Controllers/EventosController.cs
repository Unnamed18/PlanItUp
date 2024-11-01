//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using PayPalCheckoutSdk.Orders;
//using PlanItUp.Data;

//namespace PlanItUp.Controllers
//{
//    public class EventosController : Controller
//    {
//        private readonly AppDbContext _context;

//        public EventosController(AppDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Eventos>>> GetEventos()
//        {
//            return await _context.Eventos.Include(e => e.Participants).ToListAsync();
//        }

//        [HttpPost]
//        public async Task<IActionResult> CreateEvent(Event event)
//    {
//            _context.Events.Add(event);
//        await _context.SaveChangesAsync();
//        return CreatedAtAction(nameof(GetEvents), new { id = event.Id }, event);
//        }

//        [HttpPut("{id}")]
//        public async Task<IActionResult> UpdateEvent(int id, Event updatedEvent)
//        {
//            if (id != updatedEvent.Id)
//            {
//                return BadRequest();
//            }

//            _context.Entry(updatedEvent).State = EntityState.Modified;
//            await _context.SaveChangesAsync();
//            return NoContent();
//        }
//    }
//}
