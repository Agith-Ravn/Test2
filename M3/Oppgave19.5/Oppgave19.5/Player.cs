using System.Collections.Generic;

namespace Oppgave19._5
{
    public class Player
    {
        private string Navn { get; set; }
        private List<string> Har { get; set; }
        public Rom Rom { get; set; }

        public Player(string navn)
        {
            Navn = navn;
            Har = new List<string>();
        }

        public void inventory()
        {

        }
    }
}