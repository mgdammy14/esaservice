using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiModel.Resultados
{
    public class EncuestaResultado
    {
        public int IdEncuestaUsuario { get; set; }

        public int IdEncuesta { get; set; }

        public string Periodo { get; set; }

        public string IdUsuario { get; set; }

        public string NombreUsuario { get; set; }

        public string IdCurso { get; set; }

        public string NombreCurso { get; set; }

        public string IdEvaluado { get; set; }

        public string NombreEvaluado { get; set; }

        public DateTime FechaEncuestado { get; set; }
    }

    public class EncuestaResultadoFilter
    {
        public int IdTipoEncuesta { get; set; }
        public string Periodo { get; set; }
        public string Programa { get; set; }
        public int IdEncuesta { get; set; }
        public string IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public int Pagina { get; set; }
        public int Tamanio { get; set; }
    }
}
