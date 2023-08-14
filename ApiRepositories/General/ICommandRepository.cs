using ApiModel.Encuestas;
using ApiModel.General;
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
    }
}
