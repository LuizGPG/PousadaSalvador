
namespace PousadaSalvador
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadastrarApartamentoButton = new System.Windows.Forms.Button();
            this.cadastrarInquilinoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.desocupadosDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.desocupadosDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocupadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastrarApartamentoButton
            // 
            this.cadastrarApartamentoButton.Location = new System.Drawing.Point(338, 355);
            this.cadastrarApartamentoButton.Name = "cadastrarApartamentoButton";
            this.cadastrarApartamentoButton.Size = new System.Drawing.Size(168, 31);
            this.cadastrarApartamentoButton.TabIndex = 0;
            this.cadastrarApartamentoButton.Text = "Cadastrar Apartamento";
            this.cadastrarApartamentoButton.UseVisualStyleBackColor = true;
            this.cadastrarApartamentoButton.Click += new System.EventHandler(this.cadastrarApartamentoButton_Click);
            // 
            // cadastrarInquilinoButton
            // 
            this.cadastrarInquilinoButton.Location = new System.Drawing.Point(12, 355);
            this.cadastrarInquilinoButton.Name = "cadastrarInquilinoButton";
            this.cadastrarInquilinoButton.Size = new System.Drawing.Size(168, 31);
            this.cadastrarInquilinoButton.TabIndex = 1;
            this.cadastrarInquilinoButton.Text = "Cadastrar Inquilino";
            this.cadastrarInquilinoButton.UseVisualStyleBackColor = true;
            this.cadastrarInquilinoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apartamentos ocupados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apartamentos desocupados";
            // 
            // desocupadosDataGridView1
            // 
            this.desocupadosDataGridView1.AllowUserToAddRows = false;
            this.desocupadosDataGridView1.AllowUserToDeleteRows = false;
            this.desocupadosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.desocupadosDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.desocupadosDataGridView1.Location = new System.Drawing.Point(281, 44);
            this.desocupadosDataGridView1.Name = "desocupadosDataGridView1";
            this.desocupadosDataGridView1.ReadOnly = true;
            this.desocupadosDataGridView1.RowTemplate.Height = 25;
            this.desocupadosDataGridView1.Size = new System.Drawing.Size(155, 194);
            this.desocupadosDataGridView1.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 300F;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Número";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 155;
            // 
            // ocupadosDataGridView
            // 
            this.ocupadosDataGridView.AllowUserToAddRows = false;
            this.ocupadosDataGridView.AllowUserToDeleteRows = false;
            this.ocupadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ocupadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.ocupadosDataGridView.Location = new System.Drawing.Point(12, 42);
            this.ocupadosDataGridView.Name = "ocupadosDataGridView";
            this.ocupadosDataGridView.ReadOnly = true;
            this.ocupadosDataGridView.RowTemplate.Height = 25;
            this.ocupadosDataGridView.Size = new System.Drawing.Size(155, 194);
            this.ocupadosDataGridView.TabIndex = 12;
            this.ocupadosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ocupadosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 300F;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Número";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 155;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 398);
            this.Controls.Add(this.ocupadosDataGridView);
            this.Controls.Add(this.desocupadosDataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadastrarInquilinoButton);
            this.Controls.Add(this.cadastrarApartamentoButton);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.desocupadosDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocupadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrarApartamentoButton;
        private System.Windows.Forms.Button cadastrarInquilinoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView desocupadosDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView ocupadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}