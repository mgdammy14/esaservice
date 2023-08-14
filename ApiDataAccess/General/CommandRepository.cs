using ApiModel.General;
using ApiModel.Masters;
using ApiRepositories.General;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiModel.Encuestas;

namespace ApiDataAccess.General
{
    public class CommandRepository : Repository<Command>, ICommandRepository
    {
        public CommandRepository(string connectionString) : base(connectionString)
        {

        }
        public bool ActivarEncuesta(EncuestaActivacion encuesta)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@IdEncuesta", encuesta.IdEncuesta);
                parameters.Add("@FechaInicio", encuesta.FechaInicio);
                parameters.Add("@FechaFin", encuesta.FechaFin);
                parameters.Add("@Estado", encuesta.Estado);
                parameters.Add("@Success", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute(
                    "PA_ESA_ACTIVAR_ENCUESTA",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                int successValue = parameters.Get<int>("@Success");
                return successValue == 1;
            }
        }


    }
}
