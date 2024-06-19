using System;
namespace patrick.Models
{
	public class vragen
	{
		public int id { get; set; }
        public string vraag { get; set; }
        public string antwoordA { get; set; }
        public string antwoordB { get; set; }
        public string antwoordC { get; set; }
        public string goedeantwoord { get; set; }
        public vragen(int id, string vraag, string antwoordA, string antwoordB, string antwoordC, string goedeantwoord)
		{
            this.id = id;
            this.vraag = vraag;
            this.antwoordA = antwoordA;
            this.antwoordB = antwoordB;
            this.antwoordC = antwoordC;
            this.goedeantwoord = goedeantwoord;

		}
	}
}

