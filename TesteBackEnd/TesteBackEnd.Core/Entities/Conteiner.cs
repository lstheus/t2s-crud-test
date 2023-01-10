namespace TesteBackEnd.Core.Entities
{
    public class Conteiner
    {
        public string Codigo { get; set; }
        public int ClienteId { get; set; }
        public int Status { get; set; }
        public int Tipo { get; set; }
        public int Categoria { get; set; }
        public List<Movimentacao> movimentacoes { get; set; }
    }
}