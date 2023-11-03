using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimerRepoDotNet.DTOs;

namespace PrimerRepoDotNet.Controllers
{
    [Route("api/[controller]")] //La ruta en postman es /api/Users porque es el nombre del controller
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet] //Indica el tipo de llamado
        public ActionResult GetAll() //ActionResult indica el tipo de dato en este caso hace referencia a que en el return voy a tener el Ok
        {
            return Ok("Hola!"); //Ok devuelve un 200
        }
        
        [HttpGet("{id}")] //En este caso el get envía un dato id
        public ActionResult GetUser(int id)
        {
            return Ok(id); //Devuelve el id que pase por parámetro. Lo agrego en la ruta /Users/200
        }

        [HttpGet()] //
        [Route("ObtenerUsuario")]
        public ActionResult ObtenerUsuario(int id)
        {
            return Ok(id); //Ok devuelve un 200
        }

        [HttpPost] //Le tengo que enviar la data por body
        public ActionResult PostUser(UserLoginDTO userLoginDTO)
        {
            return Ok(userLoginDTO); 
        }

        [HttpPut] //
        public ActionResult UserEdit(UserLoginDTO userLoginDTO)
        {
            return Ok(userLoginDTO);
        }

        [HttpDelete] //
        public ActionResult UserDelete(int id)
        {
            return Ok("Eliminado!"); //Ok devuelve un 200
        }

    }
}
