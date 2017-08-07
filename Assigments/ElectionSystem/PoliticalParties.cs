using System;
namespace ElectionSystem
{
    public class PoliticalParties
    {
        public string Name { get; set; }
        string Nominee { get; set; }
        string IdentificationMark { get; set; }
    }


    public class EVM
    {
        string Button { get; set; }
        string PartyName { get; set; }
        string PartySymbol { get; set; }
    }
    public class Voters
    {
        string VoterId { get; set; }

    }

    public class ElectionVenue : EVM
    {
        Voters voters = new Voters();

    }


}
