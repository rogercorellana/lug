using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities
{
    public class Provincia
    {
        public int id { get; set; }

        public Pais pais { get; set; }

        public string descripcion { get; set; }

        public List<Localidad> localidadesList { get; set; } = new List<Localidad>();

    }
}
