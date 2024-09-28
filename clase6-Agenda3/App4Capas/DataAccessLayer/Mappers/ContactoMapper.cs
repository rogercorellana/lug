using DomainEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappers
{
    public class ContactoMapper
    {
        public static Contacto Map(SqlDataReader reader)
        {
            Contacto contacto = new Contacto
            {
                id = reader.GetInt32(reader.GetOrdinal("Id")),
                nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                segundoNombre = reader.IsDBNull(reader.GetOrdinal("SegundoNombre")) ? null : reader.GetString(reader.GetOrdinal("SegundoNombre")),
                apellido = reader.GetString(reader.GetOrdinal("Apellido")),

                agenda = new Agenda
                {
                    Id = reader.GetInt32(reader.GetOrdinal("AgendaId")),
                    Descripcion = reader.GetString(reader.GetOrdinal("AgendaDescripcion"))
                },

                
                telefonoList = new List<Telefono>(), 
                direccionList = new List<Direccion>() 
            };

            return contacto;
        }
    }
}
