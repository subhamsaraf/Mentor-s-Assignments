using System;
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
                person[i] = new Person();
                Console.WriteLine("Enter the salutation name and DOB");
                person[i].Name.Salutation = Console.ReadLine();
                person[i].Name.FirstName = Console.ReadLine();
                person[i].Name.MiddleName = Console.ReadLine();
                person[i].Name.LastName = Console.ReadLine();
                person[i].DateOfBirth = Convert.ToDateTime(Console.ReadLine());
               // person[i].Gender = Gender.

                }
            BikeClub bikers = new BikeClub();
            for (int i = 0; i < members; i++)
            {
                bikers.Enroll(person[i]);
                bikers.DisplayMembers();
            }


            Console.ReadKey();
        }
        }

}
