﻿using ApiModel.Encuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Interfaces.Encuesta
{
    public interface IEncuestaLogic
    {
        public List<EncuestaQuery> GetEncuestaById(int IdEncuesta);
        public bool ActivarEncuesta(EncuestaActivacion encuesta);
    }
}