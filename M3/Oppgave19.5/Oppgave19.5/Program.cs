using System;

namespace Oppgave19._5
{
    class Program
    {
        /*
         * Hvordan vil du programmet skal fungere?
         *  x Skrive navn
         *  - Starte på Rom A
         *  - plukk opp tilgjengelig nøkkel
         *  - 
         *
        */


        static void Main(string[] args)
        {
            Console.WriteLine("Skriv navnet på spiller: ");
            string name = Console.ReadLine();
            var game = new Model(name);

            while (true)
            {
                UpdateView(game);
                if (game.Rom[5].Vunnet) break;

                var command = Console.ReadLine();
                //if (command == "pick")
            }
        }

        static void UpdateView(Model game)
        {
            var spiller = game.Spiller;
            var rom = spiller.Rom;
            var text = rom.Vunnet
                ? "Gratulerer, Du har fullført spillet! :)"
                : $"{spiller.Navn} er i rom {spiller.getRoomName()}";
            
            Console.Clear();
            Console.WriteLine(
                $"{text}\n\nI rommet ser du: {rom.hentInnhold()}\n\n" +
                $"{spiller.Navn} har: {spiller.Inventory()}\n\nDører tilgjengelig:\n{game.door()}");

            while(true)
            {
                Console.WriteLine("\nSkriv \"1\" for å plukke opp nøkler ");
                var command = Console.ReadLine();
                
                Console.WriteLine("\nFor å åpne dør, skriv \"2\" (game.door() eller \"B\" for å plukke opp dør ");
                var command2 = Console.ReadLine();
                break;
            }

        }
    }
}
