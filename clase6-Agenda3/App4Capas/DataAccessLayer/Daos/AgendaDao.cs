using System;
using DomainEntities;
using DomainEntities.SharedInterfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Mappers;

namespace DataAccessLayer.Daos
{
    internal class AgendaDao : ICrud<Agenda>
    {
        private string insertSp = "AgendaInsert";
        private string deleteSp = "AgendaDelete";
        private string update = "AgendaUpdate";
        private string selectAll = "AgendaSelectAll";



        SqlDb db = new SqlDb();


        public bool Add(Agenda entity)
        {
            SqlParameter varDescripcion = new SqlParameter() { ParameterName = "@varDescripcion", Value = entity.Descripcion };

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(varDescripcion);

            return db.ExecuteNonquery(insertSp, parametros);
        }

        public bool Delete(Agenda entity)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter() { ParameterName = "@intId", Value = entity.Id });
            return db.ExecuteNonquery(deleteSp, parametros);
        }

        public List<Agenda> GetAll()
        {
            List<Agenda> agendaList = new List<Agenda>();

            using (SqlDataReader reader = db.ExecuteReader(selectAll, null))
            {
                while (reader.Read())
                {
                    Agenda agenda = AgendaMapper.Map(reader);
                    agendaList.Add(agenda);
                }
            }

            return agendaList;
        }

        public bool Update(Agenda entity)
        {
            throw new NotImplementedException();
        }
    }
}
