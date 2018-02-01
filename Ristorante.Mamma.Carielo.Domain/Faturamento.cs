using System;

namespace Ristorante.Mamma.Carielo.Domain
{
    public class Faturamento
    {
        public int FaturamentoId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public FormaPagamentoEnum FormaPagamento { get; set; }
        public string Observacao { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
