﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiModel.TipoEncuesta
{
    public class TipoEncuesta
    {
        public int IdTipoEncuesta { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set;}
        public string Descripcion { get; set;}
        public bool Estado { get; set; }
    }
}
