using BOOKMYSHOW.Models;
using BOOKMYSHOW.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOOKMYSHOW.Service
{
    public class Event_Service
    {
        private EventRepositaryimpl eventRepositaryimpl;
        public Event_Service()
        {
            eventRepositaryimpl = new EventRepositaryimpl();
        }
        public Event SaveEvent(Event Event)
        {
            return eventRepositaryimpl.CreateEvent(Event);
        }
        public Event GetEventBtId(long event_id)
        {
            return eventRepositaryimpl.GetEventBtId(event_id);
        }
        public List<Event> GetAllEvents()
        {
            return eventRepositaryimpl.GetAllEvents();

        }
         public Event UpdateEvent(long event_id, Event theEvent)
        {
            return eventRepositaryimpl.UpdateEvent(event_id, theEvent);
        }
        public string DeleteEvent(long event_id)
        {
            return eventRepositaryimpl.DeleteEvent(event_id);
        }
    }
}