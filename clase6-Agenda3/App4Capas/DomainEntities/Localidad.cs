using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities
{
    public class Localidad
    {
        public int id { get; set; }
        public Provincia provincia { get; set; }

        public string descripcion { get; set; }


        public List<Direccion> direccionList { get; set; } = new List<Direccion>();



    }
}
