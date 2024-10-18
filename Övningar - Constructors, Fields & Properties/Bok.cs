using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar___Constructors__Fields___Properties
{
    public class Bok
    {
        public string Titel { get; set; }
        public string Författare { get; set; }
        public int Sidantal { get; set; }

        public Bok(string titel, string författare, int sidantal)
        {
            Titel = titel;
            Författare = författare;
            Sidantal = sidantal;
        }

    }
}
