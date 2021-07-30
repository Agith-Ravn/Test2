using System;

namespace Oppgave19._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardModel = new BoardModel();
            while (true)
            {
                BoardView.Show(boardModel);
                Console.WriteLine("Skrive inn hvor du vil sette kryss (Eksempel a1, c3 osv)");
                var position = Console.ReadLine();
                boardModel.SetPlayer1(position);
                boardModel.SetPlayer2();
                
            }

        }
    }

    class BoardView
    {
        public static void Show(BoardModel m)
        {
            Console.WriteLine("    a b c  \n" +
                              "  ┌───────┐ \n" +
                              " 1│ " + UpdateCell(0, m) + " " + UpdateCell(1, m) + " " + UpdateCell(2, m) + " │ \n" +
                              " 2│ " + UpdateCell(3, m) + " " + UpdateCell(4, m) + " " + UpdateCell(5, m) + " │ \n" +
                              " 3│ " + UpdateCell(6, m) + " " + UpdateCell(7, m) + " " + UpdateCell(8, m) + " │ \n" +
                              "  └───────┘ \n" +
                              "");
        }

        private static string UpdateCell(int i, BoardModel m)
        {
            return m.GetCellModel(i);
        }
    }
}
