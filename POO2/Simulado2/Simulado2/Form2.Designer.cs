namespace Simulado2
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
            cb_cidades = new ComboBox();
            label5 = new Label();
            idade = new NumericUpDown();
            label2 = new Label();
            button1 = new Button();
            nome_cliente = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)idade).BeginInit();
            SuspendLayout();
            // 
            // cb_cidades
            // 
            cb_cidades.FormattingEnabled = true;
            cb_cidades.Location = new Point(383, 32);
            cb_cidades.Name = "cb_cidades";
            cb_cidades.Size = new Size(179, 23);
            cb_cidades.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(383, 14);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 19;
            label5.Text = "Cidade:";
            // 
            // idade
            // 
            idade.Location = new Point(231, 32);
            idade.Name = "idade";
            idade.Size = new Size(120, 23);
            idade.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 14);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 17;
            label2.Text = "Idade:";
            // 
            // button1
            // 
            button1.Location = new Point(229, 84);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 16;
            button1.Text = "Cadastrar cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nome_cliente
            // 
            nome_cliente.Location = new Point(12, 32);
            nome_cliente.Name = "nome_cliente";
            nome_cliente.Size = new Size(193, 23);
            nome_cliente.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 14;
            label1.Text = "Nome:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 152);
            Controls.Add(cb_cidades);
            Controls.Add(label5);
            Controls.Add(idade);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(nome_cliente);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)idade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_cidades;
        private Label label5;
        private NumericUpDown idade;
        private Label label2;
        private Button button1;
        private TextBox nome_cliente;
        private Label label1;
    }
}