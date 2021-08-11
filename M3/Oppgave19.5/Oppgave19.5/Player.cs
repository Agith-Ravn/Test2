using System.Collections.Generic;

namespace Oppgave19._5
{
    public class Player
    {
        public string Navn { get; set; }
        private List<string> Har { get; set; }
        public Rom Rom { get; set; }

        public Player(string navn, Rom rom)
        {
            Navn = navn;
            Har = new List<string>();
            Rom = rom;
        }

        public string Inventory()
        {
            return string.Join("\n", Har);
        }

        public string getRoomName()
        {
            return $"{Rom.Navn}";
        }
    }
}