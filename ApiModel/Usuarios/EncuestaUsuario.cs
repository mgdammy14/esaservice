using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiModel.Usuarios
{
    public class EncuestaUsuario
    {
        public int IdEncuesta { get; set; }
        public string IdUsuario { get; set; }
        public string IdCurso { get; set; }
        public string IdEvaluado { get; set; }
        public int IdEncuestaUsuario { get; set; }
        public List<Pregunta> Pregunta { get; set; }
    }

    public class Pregunta
    {
        public int IdPregunta { get; set; }
        public int IdEncuesta { get; set; }
        public int IdTipoPregunta { get; set; }
        public int IdGrupoTipoPregunta { get; set; }
        public string Descripcion { get; set; }
        public bool EsNPS { get; set; }
        public List<OpcionRespuesta> OpcionRespuesta { get; set; }
    }

    public class OpcionRespuesta
    {
        public int IdOpcionRespuesta { get; set; }
        public int IdTipoPregunta { get; set; }
        public string Opcion { get; set; }
        public bool Checked { get; set; }
    }

    public class EncuestaRespuestaUsuario
    {
        public int IdEncuesta { get; set; }
        public int IdEncuestaUsuario { get; set; }
        public string IdUsuario { get; set; }
        public string IdCurso { get; set; }
        public string IdEvaluado { get; set; }
        public List<EncuestaRespuestaPregunta> EncuestaRespuestaPregunta { get; set; }
    }

    public class EncuestaRespuestaPregunta
    {
        public int IdPregunta { get; set; }
        public int IdOpcion { get; set; }
        public string Valor { get; set; }
    }
}
