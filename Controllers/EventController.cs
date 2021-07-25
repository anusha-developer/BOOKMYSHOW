using BOOKMYSHOW.Models;
using BOOKMYSHOW.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BOOKMYSHOW.Controllers
{
    public class EventController : ApiController
    {
        private Event_Service event_Service;
        public EventController()
        {
            event_Service = new Event_Service();
        }

        [HttpPost]
        [Route("api/Event/save")]
        public Event CreateEvent([FromBody]Event Event)
        {

            try
            {
                return event_Service.SaveEvent(Event);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Event;
        }
        [HttpGet]
        [Route("api/Event/GetById/{event_id}")]
        public Event GetEventBtId(long event_id)
        {

            try
            {
                return event_Service.GetEventBtId(event_id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        [HttpGet]
        [Route("api/Event/GetAllEvents")]
        public List<Event> GetAllEvents()
        {

            try
            {
                return event_Service.GetAllEvents();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        [HttpPut]
        [Route("api/Event/Update/{event_id}")]
        public Event UpdateEvent(long event_id, Event theEvent)
        {
            try
            {
                return event_Service.UpdateEvent(event_id, theEvent);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        [HttpDelete]
        [Route("api/Event/DeleteById/{event_id}")]
        public string DeleteEvent(long event_id)
        {
            try
            {
                return event_Service.DeleteEvent(event_id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
