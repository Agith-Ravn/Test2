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
            }
        }
    }

    class BoardView
    {
        public static void Show(BoardModel m)
        {
            Console.WriteLine("    a b c  \n" +
                              "  ┌───────┐ \n" +
                              " 1│ " + UpdateCell(0, m) +"     │ \n" +
                              " 2│     o │ \n" +
                              " 3│ × ×   │ \n" +
                              "  └───────┘ \n" +
                              "");
        }

        private static object UpdateCell(int i, BoardModel m)
        {
            throw new NotImplementedException();
        }
    }
}
