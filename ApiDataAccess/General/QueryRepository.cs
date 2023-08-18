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
using ApiModel.Resultados;

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

        public List<EncuestaDTO> GetAllEncuesta(EncuestaFilter encuestaFilter)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@IdTipoEncuesta", encuestaFilter.IdTipoEncuesta);
                parameters.Add("@Periodo", encuestaFilter.Periodo);
                parameters.Add("@Programa", encuestaFilter.Programa);

                return connection.Query<EncuestaDTO>(
                    "PA_ESA_GET_LIST_ENCUESTA",
                    parameters,
                    commandType: CommandType.StoredProcedure)
                    .ToList();
            }
        }

        public List<Poblacion> GetPoblacion(PoblacionFilter filter)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@Periodo", filter.Periodo);
                parameters.Add("@Programa", filter.Programa);
                parameters.Add("@Modalidad", filter.Modalidad);
                parameters.Add("@Sede", filter.Sede);
                parameters.Add("@Facultad", filter.Facultad);
                parameters.Add("@Carrera", filter.Carrera);
                parameters.Add("@Curso", filter.Curso);
                parameters.Add("@Pagina", filter.Pagina);
                parameters.Add("@Tamanio", filter.Tamanio);

                return connection.Query<Poblacion>(
                    "PA_ESA_GET_POBLACION",
                    parameters,
                    commandType: CommandType.StoredProcedure)
                    .ToList();
            }
        }

        public List<EncuestaResultado> GetAllResultado(EncuestaResultadoFilter filter)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@Periodo", filter.Periodo);
                parameters.Add("@Programa", filter.Programa);
                parameters.Add("@IdEncuesta", filter.IdEncuesta);
                parameters.Add("@IdUsuario", filter.IdUsuario);
                parameters.Add("@NombreUsuario", filter.NombreUsuario);
                parameters.Add("@Pagina", filter.Pagina);
                parameters.Add("@Tamanio", filter.Tamanio);

                return connection.Query<EncuestaResultado>(
                    "PA_ESA_GET_LIST_RESULTADO",
                    parameters,
                    commandType: CommandType.StoredProcedure)
                    .ToList();
            }
        }
        public List<ApiModel.Encuestas.EncuestaUsuario> GetEncuestaByEvaluadoAndCurso(string idUsuario, string idEvaluado, string idCurso)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@IdUsuario", idUsuario);
                parameters.Add("@IdEvaluado", idEvaluado);
                parameters.Add("@IdCurso", idCurso);

                return connection.Query<EncuestaUsuario>(
                    "PA_ESA_GET_ENCUESTA_BY_IDEVALUADO_IDCURSO",
                    parameters,
                    commandType: CommandType.StoredProcedure)
                    .ToList();
            }
        }

        public List<ApiModel.Encuestas.EncuestaUsuario> GetEncuestaByIdUsuario(string idUsuario)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@IdUsuario", idUsuario);

                return connection.Query<EncuestaUsuario>(
                    "PA_ESA_GET_ENCUESTA_BY_IDUSUARIO",
                    parameters,
                    commandType: CommandType.StoredProcedure)
                    .ToList();
            }
        }
    }
}
