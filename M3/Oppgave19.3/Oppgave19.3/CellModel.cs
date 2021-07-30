using System.ComponentModel.Design;

namespace Oppgave19._3
{
    public class CellModel
    {
        private string CellContent { get; set; }

        public CellModel()
        {
            CellContent = "Empty";
        }

        public string GetCellContent()
        {
            if (CellContent == "x") return "x";
            else if (CellContent == "o") return "o";
            else return " ";
        }
    }
}