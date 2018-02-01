using System;

namespace Ristorante.Mamma.Carielo.Domain
{
    public class Despesa
    {
        public int DespesaId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public FormaPagamentoEnum FormaPagamento { get; set; }
        public string Observacao { get; set; }

        public int MercadoId { get; set; }
        public Mercado Mercado { get; set; }
    }
}
