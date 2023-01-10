namespace TesteBackEnd.Core.Entities
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public string CodigoConteiner { get; set; }
        public int TipoMov { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFinal { get; set; }
        public int ClienteId { get; set; }
        public string ClienteNome { get; set; }
    }
}