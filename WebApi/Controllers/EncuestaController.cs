using ApiBusinessLogic.Interfaces.Encuesta;
using ApiBusinessLogic.Interfaces.Poblacion;
using ApiModel.Encuestas;
using ApiModel.Poblacion;
using ApiModel.ResponseDTO.General;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApi.Controllers
{
    [Route("api/encuestas")]
    public class EncuestaController : Controller
    {
        private ResponseDTO _responseDTO = null;
        private IEncuestaLogic _logic;

        public EncuestaController(IEncuestaLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetEncuestaById(int id)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetEncuestaById(id));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPut]
        [Route("activar")]
        public IActionResult ActivarEncuesta([FromBody]EncuestaActivacion encuesta)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.ActivarEncuesta(encuesta));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPost]
        public IActionResult InsertarEncuesta([FromBody] Encuesta encuesta)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.InsertEncuesta(encuesta));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPost]
        [Route("filtrar")]
        public IActionResult GetAll([FromBody] EncuestaFilter encuestaFilter)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetAllEncuesta(encuestaFilter));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPost]
        [Route("clonar")]
        public IActionResult ClonarEncuesta([FromBody] EncuestaClonacion encuesta)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.ClonarEncuesta(encuesta));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPost]
        [Route("poblacion")]
        public IActionResult PoblacionEncuesta([FromBody] PoblacionFilter filter)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetPoblacion(filter));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }
    }
}
