namespace API_AppCobranca.Suporte.Classes
{
    public class HistoricoClienteClass
    {
        public string? codpedido { get; set; }
        public long? prepedido { get; set; }
        public DateOnly? vencimento { get; set; }
        public Decimal? valor { get; set; }
        public Decimal? valorpago { get; set; }
        public Char? pago { get; set; }
        public Double? atraso { get; set; }
        public int? qtdpedido { get; set; }
        public Decimal? valorgasto { get; set; }
        public string? nomecliente { get; set; }
    }
}
