using DataAccessLayer.Mappers;
using DomainEntities;
using DomainEntities.SharedInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Daos
{
    internal class ContactoDao : ICrud<Contacto> 
    {
        private string insertSp = "ContactoInsert";
        private string deleteSp = "ContactoDelete";
        private string update = "ContactoUpdate";
        private string selectAll = "ContactoSelectAll";



        SqlDb db = new SqlDb();
        public bool Add(Contacto entity)
        {
            SqlParameter varNombre = new SqlParameter() { ParameterName = "@varNombre" , Value = entity.nombre};
            SqlParameter varSegundoNombre = new SqlParameter() { ParameterName = "@varSegundoNombre", Value = entity.segundoNombre };
            SqlParameter varApellido = new SqlParameter() { ParameterName = "@varApellido", Value = entity.apellido };
            SqlParameter varAgenda = new SqlParameter() { ParameterName = "@varAgenda", Value = entity.agenda };

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(varNombre);
            parametros.Add(varSegundoNombre);
            parametros.Add(varApellido);
            parametros.Add(varAgenda);

            return db.ExecuteNonquery(insertSp, parametros);
        }


        public bool Delete(Contacto entity)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter() { ParameterName = "@intId", Value = entity.id });
            return db.ExecuteNonquery(deleteSp, parametros);
        }

        public List<Contacto> GetAll()
        {
            List<Contacto> contactoList = new List<Contacto>();

            using (SqlDataReader reader = db.ExecuteReader(selectAll, null))
            {
                while (reader.Read())
                {
                 
                    Contacto contacto = ContactoMapper.Map(reader);
                    contactoList.Add(contacto);
                }
            }

            return contactoList;
        }

        public bool Update(Contacto entity)
        {
            throw new NotImplementedException();
        }



    }
}
