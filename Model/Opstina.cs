using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Opstina
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public int GradId { get; set; }
        public Grad Grad { get; set; }
    }
}
