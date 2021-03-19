using PousadaSalvador.Entities;
using System;

namespace PousadaSalvador.Services
{
    class CadastraInquilinoServices
    {
        public CadastraInquilinoServices()
        {

        }
        public bool CadastrarInquilino(string nome, string telefone, DateTime dataEntrada,
            bool aindaEhInquilino, string observacoes)
        {
            var inquilino = Inquilino.CriaInquilino(nome, telefone, dataEntrada, aindaEhInquilino, observacoes);


            return true;
        }
    }


}
