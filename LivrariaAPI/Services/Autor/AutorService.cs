using LivrariaAPI.Data;
using LivrariaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrariaAPI.Services.Autor {
    public class AutorService : IAutorInterface {

        private readonly AppDbContext _context;

        public AutorService(AppDbContext context) {
            _context = context;

        }

        public Task<ResponseModel<AutorModel>> BuscarAutorPorId(int IdAutor) {
            throw new NotImplementedException();
        }


        public Task<ResponseModel<AutorModel>> BuscarAutorPorIdLivro(int idLivro) {
            throw new NotImplementedException();
        }


        public async Task<ResponseModel<List<AutorModel>>> ListarAutores() {

            ResponseModel<List<AutorModel>> resposta = new ResponseModel<List<AutorModel>>();

            try {

                var autores = await _context.Autores.ToListAsync();

                resposta.Dados = autores;
                resposta.Mensagem = "Autores Coletados !";

                return resposta;

            }
            catch (Exception ex) {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }
    }
}
