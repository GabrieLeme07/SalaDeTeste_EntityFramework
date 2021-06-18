using System;

namespace SalaDeTeste_EF.API.Model
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public bool Ativo { get; set; }
    }
}
