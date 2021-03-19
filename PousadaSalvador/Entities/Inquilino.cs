using System;

namespace PousadaSalvador.Entities
{
    public class Inquilino
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataEntrada { get; set; }
        public bool AindaEhInquilino { get; set; }

        public static Inquilino CriaInquilino(string nome, string telefone, DateTime dataEntrada, 
            bool aindaEhInquilino = false, string observacoes = "")
        {
            var inquilino = new Inquilino();
            inquilino.Nome = nome;
            inquilino.Telefone = telefone;
            inquilino.DataEntrada = dataEntrada;
            inquilino.AindaEhInquilino = aindaEhInquilino;
            inquilino.Observacoes = observacoes;

            return inquilino;
        }
    }
}

