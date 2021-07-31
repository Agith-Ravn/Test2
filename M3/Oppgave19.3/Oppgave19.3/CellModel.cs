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

        public void ChangeCellContent(string NewValue)
        {
            if (CellContent == "Empty")
            {
                CellContent = NewValue;
            }
        }

        public bool CheckIfEmpty()
        {
            if (CellContent == "Empty") return true;
            else return false;
        }

    }
}