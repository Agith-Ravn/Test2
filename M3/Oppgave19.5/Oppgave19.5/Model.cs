using System.Runtime.InteropServices.ComTypes;

namespace Oppgave19._5
{
    public class Model
    {
        public Player Spiller { get; set; }
        private Door[] Dører { get; set; }
        private Rom[] Rom { get; set; }

        public Model(string name)
        {
            Spiller = new Player(name);
            Dører = new[]
            {
                new Door("romB", "romA", "rød", false),
                new Door("romD", "romA", "grønn", false),
                new Door("romC", "romB", "grå", false),
                new Door("romE", "romB", "blå", false),
                new Door("romF", "romE", "hvit", false )
            };

            var RomA = new Rom("A", "rød nøkkel", true);
            var RomB = new Rom("B", "grønn nøkkel");
            var RomC = new Rom("C", "hvit nøkkel");
            var RomD = new Rom("D", "blue nøkkel");
            var RomE = new Rom("E", "grå nøkkel");
            var RomF = new Rom("F", false);

            Rom = new[] {RomA, RomB, RomC, RomD, RomE, RomF};
        }
    }
}