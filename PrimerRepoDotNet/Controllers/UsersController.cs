using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimerRepoDotNet.DTOs;
using PrimerRepoDotNet.Services;

namespace PrimerRepoDotNet.Controllers
{
    [Route("/api/[controller]")] //La ruta en postman es /api/Users porque es el nombre del controller
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _unitOfWork.UserRepository.GetAllUsers());
        }

        //[HttpGet] //Indica el tipo de llamado
        //public ActionResult GetAll() //ActionResult indica el tipo de dato en este caso hace referencia a que en el return voy a tener el Ok
        //{
        //    return Ok("Hola!"); //Ok devuelve un 200
        //}
        
        //[HttpGet("{id}")] //En este caso el get envía un dato id
        //public ActionResult GetUser(int id)
        //{
        //    return Ok(id); //Devuelve el id que pase por parámetro. Lo agrego en la ruta /Users/200
        //}

        //[HttpGet()] //
        //[Route("ObtenerUsuario")]
        //public ActionResult ObtenerUsuario(int id)
        //{
        //    return Ok(id); //Ok devuelve un 200
        //}

        [HttpPost] //Le tengo que enviar la data por body
        [Route("Register")]
        public async Task<ActionResult> Register(UserRegisterDTO userRegisterDTO)
        {
            var result = await _unitOfWork.UserRepository.InsertUser(userRegisterDTO);
            if (result)
            {
                await _unitOfWork.Complete();
                return Ok("Se guardó correctamente");
            }
            return BadRequest("Error");
        }

        //[HttpPut] //
        //public ActionResult UserEdit(UserLoginDTO userLoginDTO)
        //{
        //    return Ok(userLoginDTO);
        //}
        [HttpPut] 
        [Route("Update")]
        public async Task<ActionResult> Update(int id, UserRegisterDTO userRegisterDTO)
        {
            var result = await _unitOfWork.UserRepository.UpdateUser(userRegisterDTO, id);
            if (result)
            {
                await _unitOfWork.Complete();
                return Ok("Se actualizó correctamente");
            }
            return BadRequest("Error");
        }

        //[HttpDelete] //
        //public ActionResult UserDelete(int id)
        //{
        //    return Ok("Eliminado!"); //Ok devuelve un 200
        //}
        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _unitOfWork.UserRepository.DeleteUser(id);
            if (result)
            {
                await _unitOfWork.Complete();
                return Ok("Se eliminó correctamente");
            }
            return BadRequest("Error");
        }

    }
}
