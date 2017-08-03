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
            BikeClub bikeclub = new BikeClub();
            Console.WriteLine("How many members do you want to add : ");
            int members = Convert.ToInt32(Console.ReadLine());
            Person[] person = new Person[members];
            for (int i = 0; i < members; i++)
            {
                person[i].Name.FirstName = Console.ReadLine();
                person[i].Name.MiddleName = Console.ReadLine();
                person[i].Name.LastName = Console.ReadLine();
                person[i].DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                person[i].Gender = ConvertConsole.ReadLine();

            }
        }
    }


    public class Person
    {
        public Name Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Age{ get { return (DateTime.Today.Year - DateOfBirth.Year);} }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            string Details = $"{Name.Salutation}. {Name.FirstName} {Name.MiddleName} {Name.LastName}, {Gender}, Age {Age}";

            return base.ToString();
        }
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

    public class Club
    {
        public List<Person> Member { get; set; }
        public void Enroll(Person person)
        {
            Member.Add(person);
        }
            
    }

    public class BikeClub : Club
    {
        
        public void EnrollInBikeClub(Person person)
        {
            if(person.Age>=21)
            {
                this.Enroll(person);
            }
            
        }

        public void DisplayMembers()
        {
            foreach (var person in this.Member)
            {
                Member.ToString();
            }
        }
    }
    
}
