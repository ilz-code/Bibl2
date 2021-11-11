using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblio.Models
{
    public class Gramata
    {
        public int Id { get; set; }
        public string Nosaukums { get; set; }
        public int AutoraId { get; set; }
        public int Gads { get; set; }
        public int Lpp { get; set; }
    }
}
