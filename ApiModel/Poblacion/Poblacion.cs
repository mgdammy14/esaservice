using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiModel.Poblacion
{
    public class Poblacion
    {
        public string Periodo { get; set; }
        public string Sede { get; set; }
        public string Facultad { get; set; }
        public string Carrera { get; set; }
        public string IdCurso { get; set; }
        public string Curso { get; set; }
        public string NRC { get; set; }
        public string Docente { get; set; }
        public string TipoJornada { get; set; }
        public bool Selected { get; set; }
    }

    public class PoblacionFilter
    {
        public string Programa { get; set; }
        public string Periodo { get; set; }
        public string Modalidad { get; set; }
        public string Sede { get; set; }
        public string Facultad { get; set; }
        public string Carrera { get; set; }
        public string Curso { get; set; }
        public int Pagina { get; set; }
        public int Tamanio { get; set; }
    }
}
