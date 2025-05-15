using System.Text.Json.Serialization;

namespace LivrariaAPI.Models {
    public class AutorModel {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        //Diretiva para que ao criar um Autor, este atributo: <Lista de> Livros, não necessariamente precisa ser preenchido. (Ignora a propriedade).
        [JsonIgnore]
        public ICollection<LivroModel> Livros { get; set; }
    }
}
