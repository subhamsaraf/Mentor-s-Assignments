using System.Collections.Generic;

namespace BikersClubEnrollment
{
    public class BikeClub : Club
    {
        public List <Person> BikerMember { get; set; }
        public BikeClub()
        {
            BikerMember = new List<Person>();
        }
        public new void Enroll(Person person)
        {
            if (person.Age >= 21)
            {
               BikerMember.Add(person);
            }
        }
        public void DisplayMembers()
        {
            foreach (var person in BikerMember)
            {
                person.ToString();
            }
        }
    }

}
