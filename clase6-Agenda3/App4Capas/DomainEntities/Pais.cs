using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities
{
    public class Pais
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public List<Provincia> provinciasList { get; set; } = new List<Provincia>();

    }
}
