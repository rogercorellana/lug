using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEntities
{
    public class Agenda
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public List<Contacto> contactoList { get; set; } = new List<Contacto>();



    }
}
