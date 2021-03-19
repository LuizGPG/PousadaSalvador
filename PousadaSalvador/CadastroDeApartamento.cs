using PousadaSalvador.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PousadaSalvador
{
    public partial class CadastroDeApartamento : Form
    {
        public CadastroDeApartamento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var service = new CadastrarApatamentoService();
            var numero = Convert.ToInt32(numeroApartamentoTextBox.Text);
            var observacoes = observacoesTextBox.Text;

            var retorno = service.CadastrarApartamento(numero, observacoes);

            if (retorno)
                Dispose();
        }

        private void voltarButton_Click(object sender, EventArgs e) =>
            Dispose();
    }
}
