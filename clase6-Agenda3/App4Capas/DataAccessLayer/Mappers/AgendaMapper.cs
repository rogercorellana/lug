using DomainEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappers
{
    public class AgendaMapper
    {

        public static Agenda Map(SqlDataReader reader)
        {
            Agenda agenda = new Agenda
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
                contactoList = new List<Contacto>() 
            };

            return agenda;
        }
    }
}
