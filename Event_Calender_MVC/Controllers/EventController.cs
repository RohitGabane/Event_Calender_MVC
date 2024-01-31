using Event_Calender_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Event_Calender_MVC.Controllers
{
    public class EventController : Controller
    {
        private readonly MyDbContext _context;
        public EventController(MyDbContext _context)
        {
            this._context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetEvents()
        {
            List<Event> events = _context.Event.ToList();
            return Json(events);
        }

        

        [HttpPost]
        public JsonResult SaveEvent(Event e)
        {
            var status = false;
            try
            {
                if (e.event_id > 0)
                {
                    // Update the event
                    var existingEvent = _context.Event.Find(e.event_id);
                    if (existingEvent != null)
                    {
                        existingEvent.event_name = e.event_name;
                        existingEvent.start_date = e.start_date;
                        existingEvent.isfullday = e.isfullday;
                        existingEvent.end_date = e.end_date ;
                        existingEvent.event_description = e.event_description;
                        existingEvent.themecolor = e.themecolor;


                        _context.Entry(existingEvent).State = EntityState.Modified;
                    }
                }
                else
                {
                    // Add a new event
                    _context.Event.Add(e);
                }

                _context.SaveChanges();
                status = true;
            }
            catch
            {
                status = false;
            }

            return new JsonResult(new { status = status });
        }

        [HttpPost]
        public JsonResult DeleteEvent(int eventId)
        {
            var status = false;
            try
            {
                var v = _context.Event.Where(a => a.event_id == eventId).FirstOrDefault();
                if (v != null)
                {
                    _context.Event.Remove(v);
                    _context.SaveChanges();
                    status = true;
                }
            }
            catch
            {
                status = false;
            }
            return new JsonResult(new { status = status });
        }
    }
}
