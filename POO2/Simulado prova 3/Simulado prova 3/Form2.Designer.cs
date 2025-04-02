namespace Simulado_prova_3
{
    partial class Form2
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
            label1 = new Label();
            textBox_nome = new TextBox();
            num_idade = new NumericUpDown();
            label2 = new Label();
            btn_cadCliente = new Button();
            cb_cidades = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)num_idade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // textBox_nome
            // 
            textBox_nome.Location = new Point(12, 27);
            textBox_nome.Name = "textBox_nome";
            textBox_nome.Size = new Size(207, 23);
            textBox_nome.TabIndex = 1;
            // 
            // num_idade
            // 
            num_idade.Location = new Point(12, 83);
            num_idade.Name = "num_idade";
            num_idade.Size = new Size(120, 23);
            num_idade.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Idade:";
            // 
            // btn_cadCliente
            // 
            btn_cadCliente.Location = new Point(11, 224);
            btn_cadCliente.Name = "btn_cadCliente";
            btn_cadCliente.Size = new Size(107, 23);
            btn_cadCliente.TabIndex = 4;
            btn_cadCliente.Text = "Cadastrar cliente";
            btn_cadCliente.UseVisualStyleBackColor = true;
            btn_cadCliente.Click += btn_cadCliente_Click;
            // 
            // cb_cidades
            // 
            cb_cidades.FormattingEnabled = true;
            cb_cidades.Location = new Point(11, 142);
            cb_cidades.Name = "cb_cidades";
            cb_cidades.Size = new Size(208, 23);
            cb_cidades.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 124);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Cidade:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 259);
            Controls.Add(label3);
            Controls.Add(cb_cidades);
            Controls.Add(btn_cadCliente);
            Controls.Add(label2);
            Controls.Add(num_idade);
            Controls.Add(textBox_nome);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            FormClosed += Form2_FormClosed;
            ((System.ComponentModel.ISupportInitialize)num_idade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_nome;
        private NumericUpDown num_idade;
        private Label label2;
        private Button btn_cadCliente;
        private ComboBox cb_cidades;
        private Label label3;
    }
}