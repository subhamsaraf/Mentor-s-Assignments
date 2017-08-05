using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikersClubEnrollment;

namespace BikeClubEnrollmentTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_For_The_Value_Entering_The_Bikers_Club()
        {
            BikeClub bikeclub = new BikeClub();
            Person person = new Person();
            person = new Person();
            person.Name.Salutation = "Mr";
            person.Name.FirstName = "Subham";
            person.Name.MiddleName = "Kumar";
            person.Name.LastName = "Saraf";
            person.DateOfBirth = Convert.ToDateTime("05/21/1995");
            BikeClub bikersClub = new BikeClub();
            bikersClub.Enroll(person);
            string temp = bikersClub.BikerMember[0].Name.FirstName;

            //bikers.DisplayMembers();
            Assert.AreEqual("Subham", temp);

        }
        [TestMethod]
        public void Test_For_The_Value_Not_Entering_The_Bikers_Club()
        {
            BikeClub bikeclub = new BikeClub();
            Person person = new Person();
            person = new Person();
            person.Name.Salutation = "Mr";
            person.Name.FirstName = "Sourav";
            person.Name.MiddleName = "Kumar";
            person.Name.LastName = "Saraf";
            person.DateOfBirth = Convert.ToDateTime("05/21/1999");
            BikeClub bikersClub = new BikeClub();
            bikersClub.Enroll(person);
            string temp1;
            //for(int i=0;i<bikersClub.BikerMember.Count;i++)
            //{
            //    temp1 = bikersClub.BikerMember[i].Name.FirstName;
            //}
            
            //    //bikers.DisplayMembers();
            //    //Assert.AreEqual("Sourav", temp1);
            //    Assert.IsNull(temp1);

        }

    }
}
