using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esercitazioneesame.Data
{
    public class Reperto
    {
        public int id { get; set; }
        public string codice_reperto { get; set; }
        public string periodo { get; set; }
        public string tipologia { get; set; }
        public string descrizione { get; set; }
    }
}
