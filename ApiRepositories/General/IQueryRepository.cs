using ApiModel.Encuestas;
using ApiModel.General;
using ApiModel.Masters;
using ApiModel.Periodos;
using ApiModel.Poblacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRepositories.General
{
    public interface IQueryRepository : IRepository<Query>
    {
        public List<ApiModel.TipoEncuesta.TipoEncuesta> GetTipoEncuesta();
        public List<PoblacionToFile> GetPoblacionToFile(int IdEncuesta);
        public List<Periodo> GetByUnidadAcademica(string UnidadAcademica);
        public List<EncuestaQuery> GetEncuestaById(int IdEncuesta);
        public List<Master> GetMasterById(int listId);
        public List<EncuestaDTO> GetAllEncuesta(EncuestaFilter encuestaFilter);
    }
}
