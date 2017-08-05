using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow
{
    public class User
    {
        string Username { get; set; }
        string Password { get; set; }
        Adress Adress { get; set; }
        String ContactNumber { get; set; }
        Gender Gender { get; set; }
        Name Name { get; set; }
    }



    public class Name
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

    }



    public enum Gender
    {
        Male,
        Female,
        TransGender
    }

    public class Adress
    {
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PinCode { get; set; }
    }

    public class Theatre
    {
        string Name { get; set; }
        Adress Location { get; set; }
        List<Screen> Screens { get; set; }

    }
    public class Movie
    {
        string Name { get; set; }
        DateTime Releasedate { get; set; }
    }

    public class Screen
    {
        string Id;
        List<SeatClass> Seats { get; set; }
        List<Movie> PlayingMovies { get; set; }
        List<TimeSlot> ShowTiming { get; set; }
    }

    public class TimeSlot
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }

    }

    public class SeatClass
    {
        int AvailableSeats { get; set; }

    }
}



