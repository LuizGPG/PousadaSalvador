
namespace PousadaSalvador
{
    partial class CadastroDeApartamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.numeroApartamentoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE APARTAMENTO";
            // 
            // numeroApartamentoTextBox
            // 
            this.numeroApartamentoTextBox.Location = new System.Drawing.Point(15, 71);
            this.numeroApartamentoTextBox.Name = "numeroApartamentoTextBox";
            this.numeroApartamentoTextBox.Size = new System.Drawing.Size(141, 23);
            this.numeroApartamentoTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número do Apartamento";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "CADASTRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "LIMPAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.Location = new System.Drawing.Point(15, 128);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(472, 212);
            this.observacoesTextBox.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 110);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(74, 15);
            this.label.TabIndex = 11;
            this.label.Text = "Observações";
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(100, 363);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(78, 23);
            this.voltarButton.TabIndex = 12;
            this.voltarButton.Text = "VOLTAR";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // CadastroDeApartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 398);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.observacoesTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeroApartamentoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CadastroDeApartamento";
            this.Text = "CadastroDeApartamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeroApartamentoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button voltarButton;
    }
}