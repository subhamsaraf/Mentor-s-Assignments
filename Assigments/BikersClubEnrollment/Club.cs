using System.Collections.Generic;

namespace BikersClubEnrollment
{
    public class Club
    {
        public List<Person> Member { get; set; }
        public void Enroll(Person person)
        {
            Member.Add(person);
        }

    }

}
