using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikersClubEnrollment
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class Person
    {
        public Name Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Age{ get { return (DateTime.Now.DayOfYear - DateOfBirth.DayOfYear);} }
        public Gender Gender { get; set; }
       

    }

    public class Name
    {
        public string Salutation { get; set;}
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
}
