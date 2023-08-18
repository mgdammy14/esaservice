using ApiBusinessLogic.Interfaces.Resultado;
using ApiModel.ResponseDTO.General;
using ApiModel.Resultados;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/reultado")]
    public class ResultadoController : Controller
    {
        private ResponseDTO _responseDTO = null;
        private IResultadoLogic _logic;

        public ResultadoController(IResultadoLogic logic)
        {
            _logic = logic;
        }

        [HttpPost]
        [Route("filtrar")]
        public IActionResult GetAllResultado(EncuestaResultadoFilter filter)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetAllResultado(filter));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPut]
        [Route("resetear")]
        public IActionResult ResetearEncuestaUsuario(EncuestaReseteoUsuario encuestaReseteoUsuario)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.ResetearEncuestaUsuario(encuestaReseteoUsuario));
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
