using LivrariaAPI.Models;
using LivrariaAPI.Services.Autor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase {

        private readonly IAutorInterface _autorInterface;

        //Construtor recebendo a interface e atribuindo a variavel da classe(privada apenas leitura), para acessar os metodos.
        public AutorController(IAutorInterface autorInterface) {
            _autorInterface = autorInterface;
        }



        //EndPoints da API
        [HttpGet("ListarAutores")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores() {

            var autores = await _autorInterface.ListarAutores();
            return Ok(autores);
        }


        [HttpGet("BuscarAutorPorId/{idAutor}")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorId(int idAutor) {

            var autor = await _autorInterface.BuscarAutorPorId(idAutor);
            return Ok(autor);

        }






    }
}
