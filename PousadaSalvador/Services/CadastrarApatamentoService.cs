using PousadaSalvador.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PousadaSalvador.Services
{
    class CadastrarApatamentoService
    {
        public CadastrarApatamentoService()
        {

        }

        public bool CadastrarApartamento(int numero, string observacoes)
        {
            var inquilino = Apartamento.CadastraApartamento(numero, observacoes);


            return true;
        }
    }
}
