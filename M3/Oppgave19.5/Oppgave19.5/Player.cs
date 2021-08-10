using System.Collections.Generic;

namespace Oppgave19._5
{
    public class Player
    {
        public string Navn { get; set; }
        private List<string> Har { get; set; }
        public Rom Rom { get; set; }

        public Player(string navn)
        {
            Navn = navn;
            Har = new List<string>();
        }

        public string Inventory()
        {
            return string.Join("\n", Har);
        }
    }
}