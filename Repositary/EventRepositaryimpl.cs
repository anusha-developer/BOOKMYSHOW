using BOOKMYSHOW.Connections;
using BOOKMYSHOW.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BOOKMYSHOW.Repositary
{
    public class EventRepositaryimpl : IEventRepositary
    {
        SqlConnection con = null;
        public Event CreateEvent(Event Event)
        {
            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                //SqlCommand is a class
                SqlCommand cmd = new SqlCommand("INSERT INTO BMS_tbl_Events values('" + Event.Eventname + "','" + Event.Venue + "','" + Event.Location + "'," +
                    "'" + Event.Startdate + "','" + Event.Enddate + "','" + Event.Price + "','" + Event.Discription + "' )", con);
                cmd.ExecuteNonQuery();
                return Event;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
            return Event;
        }

        public string DeleteEvent(long event_id)
        {
            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete  from BMS_tbl_Events  WHERE Event_id=" + event_id, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return " Deleted Sucessfully:" + event_id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public List<Event> GetAllEvents()
        {
            List<Event> EventList = new List<Event>();
            try
            {
                Event theevent = new Event();
                con = DbConnections.CreateConnection();//DBConnection connection class
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from BMS_tbl_Events ", con);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    
                    theevent = new Event();
                    theevent.Event_id = Convert.ToInt32(sdr["Event_id"]);
                    theevent.Eventname = Convert.ToString(sdr["Eventname"]);
                    theevent.Venue = Convert.ToString(sdr["Venue"]);
                    theevent.Location = Convert.ToString(sdr["Location"]);
                    theevent.Startdate = Convert.ToDateTime(sdr["Startdate"]);
                    theevent.Enddate = Convert.ToDateTime(sdr["Enddate"]);
                    theevent.Price = Convert.ToDouble(sdr["Price"]);
                    theevent.Discription = Convert.ToString(sdr["Discription"]);
                    EventList.Add(theevent);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return EventList;

        }

        public Event GetEventBtId(long event_id)
        {
            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from  BMS_tbl_Events  where Event_id=" + event_id, con);
                Event theevent = new Event();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    theevent = new Event();
                    theevent.Event_id = Convert.ToInt32(sdr["Event_id"]);
                    theevent.Eventname = Convert.ToString(sdr["Eventname"]);
                    theevent.Venue = Convert.ToString(sdr["Venue"]);
                    theevent.Location = Convert.ToString(sdr["Location"]);
                    theevent.Startdate = Convert.ToDateTime(sdr["Startdate"]);
                    theevent.Enddate = Convert.ToDateTime(sdr["Enddate"]);
                    theevent.Price = Convert.ToDouble(sdr["Price"]);
                    theevent.Discription = Convert.ToString(sdr["Discription"]);
                  
                    con.Close();

                    return theevent;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public Event UpdateEvent(long event_id, Event theEvent)
        {
            try
            {
                con = DbConnections.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update BMS_tbl_Events SET  Eventname = '" + theEvent.Eventname + "', Venue = '" + theEvent.Venue + "', Location = '" + theEvent.Location + "', Startdate = '" + theEvent.Startdate + "', Enddate = '" + theEvent.Enddate + "',  Price = '" + theEvent.Price + "', Discription = '" + theEvent.Discription + "' WHERE Event_id =" + event_id, con);

                SqlDataReader sdr = cmd.ExecuteReader();
                return theEvent;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}