using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar___Constructors__Fields___Properties
{
    internal class Bok
    {
        private string _titel;
        private string _författare;
        private int _sidantal;

        public Bok(string titel, string författare, int sidantal)
        {
            _titel = titel;
            _författare = författare;
            _sidantal = sidantal;
        }

    }
}
