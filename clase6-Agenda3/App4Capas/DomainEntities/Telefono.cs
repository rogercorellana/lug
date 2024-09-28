using DomainEntities.SharedEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities
{
    public class Telefono
    {
        public int id { get; set; }
        public TelefonoTipo telefonoTipo { get; set; }
        public int numero { get; set;}
        public Contacto contacto { get; set; }


    }
}
