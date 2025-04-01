using LivrariaAPI.Models;

namespace LivrariaAPI.Services.Autor {
    public interface IAutorInterface {

        Task<ResponseModel<AutorModel>> BuscarAutorPorId(int IdAutor);
        Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro);
        Task<ResponseModel<List<AutorModel>>> ListarAutores();
    }
}
