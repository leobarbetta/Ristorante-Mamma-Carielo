using System;

namespace Ristorante.Mamma.Carielo.Domain
{
    public class Mercado
    {
        public int MercadoId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
