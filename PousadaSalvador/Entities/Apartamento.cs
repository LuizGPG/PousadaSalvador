namespace PousadaSalvador.Entities
{
    class Apartamento
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Observacoes { get; set; }

        public static Apartamento CadastraApartamento(int numero, string observacoes = "")
        {
            var apartamento = new Apartamento();
            apartamento.Numero = numero;
            apartamento.Observacoes = observacoes;

            return apartamento;
        }
    }
}
