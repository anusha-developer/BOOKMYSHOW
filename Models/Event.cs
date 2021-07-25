using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BOOKMYSHOW.Models
{
    public class Event
    {
        private long event_id;
        private string eventname;
        private string venue;
        private string location;
        private DateTime startdate;
        private DateTime enddate;
        private double price;
        private string discription;

        public long Event_id { get => event_id; set => event_id = value; }
        public string Eventname { get => eventname; set => eventname = value; }
        public string Venue { get => venue; set => venue = value; }
        public string Location { get => location; set => location = value; }
        public DateTime Startdate { get => startdate; set => startdate = value; }
        public DateTime Enddate { get => enddate; set => enddate = value; }
        public double Price { get => price; set => price = value; }
        public string Discription { get => discription; set => discription = value; }
    }
}
