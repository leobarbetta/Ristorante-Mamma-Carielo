using System;

namespace Ristorante.Mamma.Carielo.Domain
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;        
    }
}
