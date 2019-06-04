using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagrafeV2
{
    class persona
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string CF { get; set; }


        public string getNome { get { return nome; } }
        public string getCognome { get { return cognome; } }
        public string getCF { get { return CF; } }
    }
}
