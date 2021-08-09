using System;

namespace Oppgave19._5
{
    class Program
    {
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
            Console.WriteLine($"{text}");

        }
    }
}
