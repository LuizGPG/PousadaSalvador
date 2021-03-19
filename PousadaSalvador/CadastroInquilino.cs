using PousadaSalvador.Services;
using System;
using System.Windows.Forms;

namespace PousadaSalvador
{
    public partial class CadastroInquilino : Form
    {
        public CadastroInquilino()
        {
            InitializeComponent();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            var service = new CadastraInquilinoServices();

            var nome = nomeTextBox.Text;
            var telefone = telefoneTextBox.Text;
            var dataEntrada = dataEntradaCalendar.SelectionEnd;
            var aindaEhInquilino = aindaEhInquilinoCheckBox.Checked;
            var observacoes = observacoesTextBox.Text;

            var retorno = service.CadastrarInquilino(nome, telefone, dataEntrada, aindaEhInquilino, observacoes);

            if (retorno)
                Dispose();
        }

        private void limpar_Click(object sender, EventArgs e) =>
            LimparCampos();

        private void LimparCampos()
        {
            nomeTextBox.Clear();
            telefoneTextBox.Clear();
            aindaEhInquilinoCheckBox.Checked = false;
        }

        private void labelLinkApartamento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void voltarButton_Click(object sender, EventArgs e) =>
            Dispose();
    }
}
