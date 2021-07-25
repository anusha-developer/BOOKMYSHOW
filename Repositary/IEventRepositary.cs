using BOOKMYSHOW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOKMYSHOW.Repositary
{
    interface IEventRepositary
    {
        // CREATE EVENT
        Event CreateEvent(Event Event);

        //DELETE EVENT

        string DeleteEvent(long event_id);

        //UPDATE EVENT BY EVENT ID

        Event UpdateEvent(long event_id, Event theEvent);

        //GET ALL EVENTS

        List<Event> GetAllEvents();

        //GET EVENT BY EVENT ID

        Event GetEventBtId(long event_id);

    }
}
