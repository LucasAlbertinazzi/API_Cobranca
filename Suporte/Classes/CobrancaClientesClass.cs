namespace API_AppCobranca.Suporte.Classes
{
    public class CobrancaClientesClass
    {
        public long? Codcliente { get; set; }
        public string? Codpedido { get; set; }
        public int? Codusuario { get; set; }
        public DateOnly? Vencimento { get; set; }
        public char? Pago { get; set; }
        public int? Tipovenda { get; set; }
        public char? Cancelado { get; set; }
        public DateTime? Datacontato { get; set; }
        public string? Descricao { get; set; }
        public bool? ClienteProcessado { get; set; }
        public string? Usuario { get; set; }
        public char? Pricontato { get; set; }
        public char? Segcontato { get; set; }
        public DateOnly? Pgtopara { get; set; }
        public DateOnly? Agendacobranca { get; set; }
    }
}
