﻿using ApiModel.Encuestas;
using ApiModel.General;
using ApiModel.Resultados;
using ApiModel.TipoEncuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRepositories.General
{
    public interface ICommandRepository : IRepository<Command>
    {
        public bool ActivarEncuesta(EncuestaActivacion encuesta);
        public bool InsertarTipoEncuesta(TipoEncuesta tipoencuesta);
        public bool InsertarEncuesta(Encuesta encuesta);
        public bool ClonarEncuesta(EncuestaClonacion encuesta);
        public bool ResetearEncuestaUsuario(EncuestaReseteoUsuario encuestaReseteoUsuario);
        public bool RegistrarEncuesta(ApiModel.Usuarios.EncuestaRespuestaUsuario encuestaUsuario);
    }
}
