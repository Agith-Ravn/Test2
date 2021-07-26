using System;

namespace Oppgave19._2
{
    public class TwelveMatches
    {
        private Match[] matches;


        public TwelveMatches(string betsText)
        {
            var bets = betsText.Split(' ');

            //Lager tom match array og legger til 12 objekter inni + sender dine bets
            matches = new Match[12];
            for (var i = 0; i < 12; i++)
            {
                matches[i] = new Match(bets[i]);
            }
        }


        public void AddGoal(int matchNo, bool b)
        {
            var selectedIndex = matchNo - 1;
            var selectedMatch = matches[selectedIndex];

            if (b) { selectedMatch.AddGoal("H"); }
            else if (!b) { selectedMatch.AddGoal("B"); }
        }

        public void ShowAllScores()
        {
            for (var index = 0; index < matches.Length; index++)
            {
                var match = matches[index];
                var matchNo = index + 1;
                var isBetCorrect = match.IsBetCorrect();
                var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
                Console.WriteLine($"Kamp {matchNo}: {match.GetScore()} - {isBetCorrectText}");
            }
        }

        public void ShowCorrectCount()
        {
            var correctCount = 0;
            foreach (var match in matches)
            {
                if (match.IsBetCorrect()) correctCount++;
            }
            Console.WriteLine($"Du har {correctCount} rette.");
        }
    }
}