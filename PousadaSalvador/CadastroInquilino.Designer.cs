
namespace PousadaSalvador
{
    partial class CadastroInquilino
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataEntradaCalendar = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.aindaEhInquilinoCheckBox = new System.Windows.Forms.CheckBox();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.observacoesLabel = new System.Windows.Forms.Label();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.Location = new System.Drawing.Point(388, 361);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(112, 23);
            this.cadastrarButton.TabIndex = 0;
            this.cadastrarButton.Text = "CADASTRAR";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // limparButton
            // 
            this.limparButton.Location = new System.Drawing.Point(12, 361);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(130, 23);
            this.limparButton.TabIndex = 1;
            this.limparButton.Text = "LIMPAR";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limpar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 49);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CADASTRO DE INQUILINO";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(12, 52);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(473, 23);
            this.nomeTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(12, 113);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(189, 23);
            this.telefoneTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de Entrada";
            // 
            // dataEntradaCalendar
            // 
            this.dataEntradaCalendar.Location = new System.Drawing.Point(12, 173);
            this.dataEntradaCalendar.Name = "dataEntradaCalendar";
            this.dataEntradaCalendar.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ainda é inquilino";
            // 
            // aindaEhInquilinoCheckBox
            // 
            this.aindaEhInquilinoCheckBox.AutoSize = true;
            this.aindaEhInquilinoCheckBox.Location = new System.Drawing.Point(316, 114);
            this.aindaEhInquilinoCheckBox.Name = "aindaEhInquilinoCheckBox";
            this.aindaEhInquilinoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.aindaEhInquilinoCheckBox.TabIndex = 14;
            this.aindaEhInquilinoCheckBox.UseVisualStyleBackColor = true;
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.Location = new System.Drawing.Point(271, 173);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(229, 162);
            this.observacoesTextBox.TabIndex = 15;
            // 
            // observacoesLabel
            // 
            this.observacoesLabel.AutoSize = true;
            this.observacoesLabel.Location = new System.Drawing.Point(271, 149);
            this.observacoesLabel.Name = "observacoesLabel";
            this.observacoesLabel.Size = new System.Drawing.Size(74, 15);
            this.observacoesLabel.TabIndex = 16;
            this.observacoesLabel.Text = "Observações";
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(148, 361);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(130, 23);
            this.voltarButton.TabIndex = 17;
            this.voltarButton.Text = "VOLTAR";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // CadastroInquilino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 398);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.observacoesLabel);
            this.Controls.Add(this.observacoesTextBox);
            this.Controls.Add(this.aindaEhInquilinoCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataEntradaCalendar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.cadastrarButton);
            this.Name = "CadastroInquilino";
            this.Text = "CadastroInquilino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar dataEntradaCalendar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton aindaEsta;
        private System.Windows.Forms.CheckBox aindaEhInquilinoCheckBox;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.Label observacoesLabel;
        private System.Windows.Forms.Button voltarButton;
    }
}

