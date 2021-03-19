using System;
using System.Windows.Forms;

namespace PousadaSalvador
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarApartamentoButton_Click(object sender, EventArgs e)
        {
            var cadastroApartamentoForm = new CadastroDeApartamento();
            cadastroApartamentoForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cadastroInquilino = new CadastroInquilino();
            cadastroInquilino.Show();
        }

        private void botaoDataGrid_Click(object sender, EventArgs e)
        {
            desocupadosDataGridView1.Rows.Add("ap");
        }

        private void ocupadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
