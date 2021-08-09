namespace Oppgave19._5
{
    public class Rom
    {
        public string Navn { get; set; }
        private string[] Innhold { get; set; }

        //For å vite om du starter og har vunnet
        public bool Start { get; set; }
        public bool Vunnet { get; set; }

        public Rom(string navn, string nøkkel, bool start)
        {
            Navn = navn;
            Innhold = new string[] {nøkkel};
            Start = start;
        }

        public Rom(string navn, string nøkkel)
        {
            Navn = navn;
            Innhold = new string[] { nøkkel };
        }

        public Rom(string navn, bool vunnet)
        {
            Navn = navn;
            Vunnet = vunnet;
        }

    }
}