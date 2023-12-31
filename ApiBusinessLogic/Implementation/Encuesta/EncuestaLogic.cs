﻿using ApiBusinessLogic.Interfaces.Encuesta;
using ApiModel.Encuestas;
using ApiModel.Poblacion;
using ApiUnitOfWork.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBusinessLogic.Implementation.Encuesta
{
    public class EncuestaLogic : IEncuestaLogic
    {
        private readonly IUnitOfWork _unitOfWork;

        public EncuestaLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<EncuestaQuery> GetEncuestaById(int IdEncuesta)
        {
            try
            {
                return _unitOfWork.IQuery.GetEncuestaById(IdEncuesta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ActivarEncuesta(EncuestaActivacion encuesta)
        {
            try
            {
                return _unitOfWork.ICommand.ActivarEncuesta(encuesta);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertEncuesta(ApiModel.Encuestas.Encuesta encuesta)
        {
            try
            {
                return _unitOfWork.ICommand.InsertarEncuesta(encuesta);
            }
            catch(Exception e) 
            {
                throw e;
            }
        }

        public List<EncuestaDTO> GetAllEncuesta(EncuestaFilter encuestaFilter)
        {
            try
            {
                return _unitOfWork.IQuery.GetAllEncuesta(encuestaFilter);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public bool ClonarEncuesta(EncuestaClonacion encuesta)
        {
            try
            {
                return _unitOfWork.ICommand.ClonarEncuesta(encuesta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ApiModel.Poblacion.Poblacion> GetPoblacion(PoblacionFilter filter)
        {
            try
            {
                return _unitOfWork.IQuery.GetPoblacion(filter);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
