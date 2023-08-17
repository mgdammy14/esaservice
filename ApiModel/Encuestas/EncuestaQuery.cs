using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiModel.Encuestas
{
    public class Encuesta
    {
        public int IdEncuesta { get; set; }
        public int IdTipoEncuesta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Periodo { get; set; }
        public string Programa { get; set; }
        public string Modalidad { get; set; }
        public bool Estado { get; set; }
        public int IdUsuarioCrea { get; set; }
        public List<Pregunta> Pregunta { get; set; }
        public List<Competencia> Competencia { get; set; }
    }

    public class Competencia
    {
        public int IdCompetencia { get; set; }
        public int IdEncuesta { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public int Orden { get; set; }
        public string JsonPregunta { get; set; }
    }

    public class Pregunta
    {
        public int IdPregunta { get; set; }
        public int IdEncuesta { get; set; }
        public int IdTipoPregunta { get; set; }
        public string Descripcion { get; set; }
        public bool EsRequerido { get; set; }
        public int Orden { get; set; }
        public bool EsNPS { get; set; }
        public int IdUsuarioCrea { get; set; }
    }
    public class EncuestaQuery
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
        public int IdPregunta { get; set; }
        public int IdTipoPregunta { get; set; }
        public string PreguntaNombre { get; set; }
        public bool EsRequerido { get; set; }
        public int PreguntaOrden { get; set; }
        public int IdCompetencia { get; set; }
        public string CompetenciaNombre { get; set; }
        public double CompetenciaValor { get; set; }
        public int CompetenciaOrden { get; set; }
    }
    public class EncuestaActivacion
    {
        public int IdEncuesta { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Estado { get; set; }
    }

    public class EncuestaClonacion
    {
        public int IdEncuesta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Periodo { get; set; }
    }

    public class EncuestaFilter
    {
        public int IdTipoEncuesta { get; set; }
        public string Periodo { get; set; }
        public string Programa { get; set; }
        public string Modalidad { get; set; }
    }

    public class EncuestaDTO
    {
        public int IdEncuesta { get; set; }
        public int IdTipoEncuesta { get; set; }
        public string TipoEncuesta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Periodo { get; set; }
        public string Programa { get; set; }
        public string Modalidad { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public bool Estado { get; set; }
        public int Avance { get; set; }
    }
}
