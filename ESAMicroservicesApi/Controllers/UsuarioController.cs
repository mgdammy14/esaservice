using ApiBusinessLogic.Interfaces.Usuario;
using ApiModel.Encuestas;
using ApiModel.ResponseDTO.General;
using ApiModel.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/usuarios")]
    public class UsuarioController : Controller
    {
        private ResponseDTO _responseDTO = null;
        private IUsuarioLogic _logic;

        public UsuarioController(IUsuarioLogic logic)
        {
            _logic = logic;
        }

        [HttpPost]
        [Route("encuestas")]
        public IActionResult GetEncuestaByIdUsuario([FromBody] GetByIdUsuarioQueryRequest request)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetEncuestaByIdUsuario(request.IdUsuario));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpGet]
        [Route("encuestas/{idUsuario}/{idEvaluado}/{idCurso}")]
        public IActionResult Fil1e(string idUsuario, string idEvaluado, string idCurso)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.GetEncuestaByEvaluadoAndCurso(idUsuario, idEvaluado, idCurso));
                return Ok(response);
            }
            catch (Exception e)
            {
                var response = _responseDTO.Failed(_responseDTO, e);
                return BadRequest(response);
            }
        }

        [HttpPost]
        [Route("registrar-encuesta")]
        public IActionResult RegistrarEncuesta([FromBody]EncuestaRespuestaUsuario encuestaRespuestaUsuario)
        {
            _responseDTO = new ResponseDTO();
            try
            {
                var response = _responseDTO.Success(_responseDTO, _logic.RegistrarEncuesta(encuestaRespuestaUsuario));
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
