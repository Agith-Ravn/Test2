using System;

namespace Oppgave19._5
{
    class Program
    {
        /*
         * Hvordan vil du programmet skal fungere?
         *  x Skrive navn
         *  - Tekst om hvilken rom du er i
         *  - Hvilken dør som tilgjengelig
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
            }
        }

        static void UpdateView(Model game)
        {
            var spiller = game.Spiller;
            var rom = spiller.Rom;
            var text = rom.Vunnet ? "Gratulerer, Du har fullført spillet! :)" : $"Du er i rom {rom.Navn}";
            
            Console.WriteLine(
                $"{text}\n\nI rommet ser du: {rom.hentInnhold()}\n\n" +
                $"{spiller.Navn} har: {spiller.Inventory()}\n\nDører tilgjengelig:\n{game.door()}");

        }
    }
}
