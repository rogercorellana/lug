using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities
{
    public class Contacto
    {
        public int id { get; set; }

        public string nombre { get; set; }
        public string segundoNombre { get; set; }
        public string apellido { get; set; }

        public Agenda agenda { get; set; }

        public List<Telefono> telefonoList { get; set; } = new List<Telefono>();

        public List<Direccion> direccionList { get; set; } = new List<Direccion>();


    }
}
