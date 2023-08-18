using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiModel.Encuestas
{
    public class EncuestaUsuario
    {
        public int IdEncuesta { get; set; }
        public int IdTipoEncuesta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Periodo { get; set; }
        public string Programa { get; set; }
        public string Modalidad { get; set; }
        public bool Estado { get; set; }
        public string IdUsuario { get; set; }
        public string IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public string IdEvaluado { get; set; }
        public string NombreEvaluado { get; set; }
        public int IdEncuestaUsuario { get; set; }
        public List<Pregunta> Pregunta { get; set; }
    }

    public class EncuestaUsuarioQuery
    {
        public int IdEncuesta { get; set; }
        public int IdTipoEncuesta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Periodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Estado { get; set; }
        public string Programa { get; set; }
        public string Modalidad { get; set; }
        public string IdUsuario { get; set; }
        public string IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public string IdEvaluado { get; set; }
        public string NombreEvaluado { get; set; }
        public int IdEncuestaUsuario { get; set; }
        public int IdPregunta { get; set; }
        public int IdTipoPregunta { get; set; }
        public int IdGrupoTipoPregunta { get; set; }
        public string GrupoTipoPregunta { get; set; }
        public int IdGrupoPregunta { get; set; }
        public string PreguntaNombre { get; set; }
        public bool EsRequerido { get; set; }
        public int PreguntaOrden { get; set; }
        public int IdOpcionRespuesta { get; set; }
        public string Opcion { get; set; }
        public string OpcionRespuestaDescripcion { get; set; }
        public int OpcionRespuestaOrden { get; set; }
    }

    public class GetByIdUsuarioQueryRequest
    {
        public string IdUsuario { get; set; }
    }
}
