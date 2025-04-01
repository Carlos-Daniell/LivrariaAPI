namespace LivrariaAPI.Models {
    public class ResponseModel<T> {

        //Modelo de Resposta
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Status { get; set; } = true;
    }
}
