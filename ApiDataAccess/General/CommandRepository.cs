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
using ApiModel.TipoEncuesta;
using System.Text.Json;

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

        public bool InsertarTipoEncuesta(TipoEncuesta tipoencuesta)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@IdTipoEncuesta", tipoencuesta.IdTipoEncuesta);
                parameters.Add("@Codigo", tipoencuesta.Codigo);
                parameters.Add("@Nombre", tipoencuesta.Nombre);
                parameters.Add("@Descripcion", tipoencuesta.Descripcion);
                parameters.Add("@Success", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute(
                    "PA_ESA_INSERT_TIPOENCUESTA",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                int successValue = parameters.Get<int>("@Success");
                return successValue == 1;
            }
        }

        public bool InsertarEncuesta(Encuesta encuesta)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@IdEncuesta", encuesta.IdEncuesta);
                parameters.Add("@IdTipoEncuesta", encuesta.IdTipoEncuesta);
                parameters.Add("@Nombre", encuesta.Nombre);
                parameters.Add("@Descripcion", encuesta.Descripcion);
                parameters.Add("@Periodo", encuesta.Periodo);
                parameters.Add("@Programa", encuesta.Programa);
                parameters.Add("@PreguntaJson", JsonSerializer.Serialize(encuesta.Pregunta));
                parameters.Add("@CompetenciaJson", JsonSerializer.Serialize(encuesta.Competencia));
                parameters.Add("@Success", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute(
                    "PA_ESA_INSERT_ENCUESTA",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                int successValue = parameters.Get<int>("@Success");
                return successValue == 1;
            }
        }
    }
}
