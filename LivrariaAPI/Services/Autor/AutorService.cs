using LivrariaAPI.Data;
using LivrariaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrariaAPI.Services.Autor {
    public class AutorService : IAutorInterface {

        private readonly AppDbContext _context;

        public AutorService(AppDbContext context) {
            _context = context;

        }

        public async Task<ResponseModel<AutorModel>> BuscarAutorPorId(int idAutor) {

            ResponseModel<AutorModel> resposta = new ResponseModel<AutorModel>();

            try {
                var autor = await _context.Autores.FirstOrDefaultAsync(autorBanco => autorBanco.Id == idAutor);

                if (autor != null) {
                    resposta.Dados = autor;
                    resposta.Mensagem = "Autor encontrado!";
                    return resposta;
                }
                else {
                    resposta.Mensagem = "Autor não encontrado!";
                    resposta.Status = false;
                    return resposta;
                }

            }
            catch (Exception ex) {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
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
