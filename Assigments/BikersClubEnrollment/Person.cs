using System;

namespace BikersClubEnrollment
{
    public class Person
    {
        public Person()
        {
            this.Name = new Name();
        }
        public Name Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Age { get { return (DateTime.Today.Year - DateOfBirth.Year); } }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            string Details = $"{Name.Salutation}. {Name.FirstName} {Name.MiddleName} {Name.LastName}, Gender, Age {Age}";
            return Details;
        }
    }

}
