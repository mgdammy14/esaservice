using ApiModel.General;
using ApiModel.Poblacion;
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
using ApiModel.Masters;

namespace ApiDataAccess.General
{
    public class QueryRepository : Repository<Query>, IQueryRepository
    {
        public QueryRepository(string connectionString) : base(connectionString)
        {

        }
        public List<ApiModel.TipoEncuesta.TipoEncuesta> GetTipoEncuesta()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Query<ApiModel.TipoEncuesta.TipoEncuesta>(
                    "PA_ESA_GET_LIST_TIPOENCUESTA",
                    commandType: CommandType.StoredProcedure)
                    .ToList();
            }
        }

        public List<PoblacionToFile> GetPoblacionToFile(int IdEncuesta)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@IdEncuesta", IdEncuesta);

                return connection.Query<PoblacionToFile>(
                    "PA_ESA_GET_POBLACION_BY_ID_ENCUESTA",
                    parameters,
                    commandType: CommandType.StoredProcedure)
                    .ToList();
            }
        }

        public List<ApiModel.Periodos.Periodo> GetByUnidadAcademica(string UnidadAcademica)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@UnidadAcademica", UnidadAcademica);

                return connection.Query<ApiModel.Periodos.Periodo>(
                    "PA_ESA_GET_PERIODO_BY_UND_ACAD",
                    parameters,
                    commandType: CommandType.StoredProcedure)
                    .ToList();
            }
        }

        public List<EncuestaQuery> GetEncuestaById(int IdEncuesta)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@IdEncuesta", IdEncuesta);

                return connection.Query<EncuestaQuery>(
                    "PA_ESA_GET_ENCUESTA_BY_ID",
                    parameters,
                    commandType: CommandType.StoredProcedure)
                    .ToList();
            }
        }

        public List<Master> GetMasterById(int listId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@ListId", listId);

                return connection.Query<Master>(
                    "PA_ESA_GET_MASTER_BY_ID",
                    parameters,
                    commandType: CommandType.StoredProcedure)
                    .ToList();
            }
        }
    }
}
