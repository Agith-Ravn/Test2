using System.Runtime.InteropServices.ComTypes;

namespace Oppgave19._5
{
    public class Model
    {
        private Player Spiler1 { get; set; }
        private Door[] Dører { get; set; }
        private Rom[] Rom { get; set; }

        public Model()
        {
            Spiler1 = new Player("FiksNavnSenere");
            Dører = new[]
            {
                new Door("romB", "romA", "rød", false),
                new Door("romD", "romA", "grønn", false),
                new Door("romC", "romB", "grå", false),
                new Door("romE", "romB", "blå", false),
                new Door("romF", "romE", "hvit", false )
            };

            Rom = new[]
            {
                new Rom(""),
                new Rom(),
                new Rom(),
                new Rom(),

            }
        }
    }
}