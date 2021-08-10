using System.Linq;
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

            var RomA = new Rom("A", "rød nøkkel", true);
            var RomB = new Rom("B", "grønn nøkkel");
            var RomC = new Rom("C", "hvit nøkkel");
            var RomD = new Rom("D", "blue nøkkel");
            var RomE = new Rom("E", "grå nøkkel");
            var RomF = new Rom("F", false);
            Rom = new[] {RomA, RomB, RomC, RomD, RomE, RomF};

            Dører = new[]
            {
                new Door(RomB, RomA, "rød", false),
                new Door(RomD, RomA, "grønn", false),
                new Door(RomC, RomB, "grå", false),
                new Door(RomE, RomB, "blå", false),
                new Door(RomF, RomE, "hvit", false )
            };
        }

        public string door()
        {
            //Rom spiller er i
            var rom = Spiller.Rom;

            //?????
            var dørerIRommet = Dører.Where(d => d.A == rom || d.B == rom);

            //Forklar hva dette betyr??
            var txt = "";
            foreach (var dør in dørerIRommet)
            {
                var til = dør.A == rom ? dør.B : dør.A;
                txt += dør.Åpent
                    ? $"Gå til {til.Navn}\n"
                    : $"Låse opp {dør.Farge}\n";
            }
            return txt;


        }
    }
}