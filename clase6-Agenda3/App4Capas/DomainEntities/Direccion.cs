using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities
{
    public class Direccion
    {
        public int id { get; set; }
        public Pais pais { get; set; }

        public Provincia provincia { get; set; }

        public string calle { get; set; }

        public int altura { get; set; }

        public int piso { get; set; }

        public int departamento { get; set; }

        public Localidad localidad { get; set; }

        public Contacto contacto { get; set; }

    }
}
