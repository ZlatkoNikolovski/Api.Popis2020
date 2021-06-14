using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Zhitel
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Maticen { get; set; }

        public int Godini { get; set; }
        public int OpstinaId { get; set; }
        public Opstina Opstina { get; set; }
    }
}
