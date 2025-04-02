namespace Simulado_prova_3
{
    partial class Form3
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
            textBox_cidade = new TextBox();
            label2 = new Label();
            textBox_uf = new TextBox();
            btn_cadCidade = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cidade:";
            // 
            // textBox_cidade
            // 
            textBox_cidade.Location = new Point(12, 27);
            textBox_cidade.Name = "textBox_cidade";
            textBox_cidade.Size = new Size(216, 23);
            textBox_cidade.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 2;
            label2.Text = "UF:";
            // 
            // textBox_uf
            // 
            textBox_uf.Location = new Point(12, 87);
            textBox_uf.Name = "textBox_uf";
            textBox_uf.Size = new Size(216, 23);
            textBox_uf.TabIndex = 3;
            // 
            // btn_cadCidade
            // 
            btn_cadCidade.Location = new Point(12, 132);
            btn_cadCidade.Name = "btn_cadCidade";
            btn_cadCidade.Size = new Size(126, 23);
            btn_cadCidade.TabIndex = 4;
            btn_cadCidade.Text = "Cadastrar cidade";
            btn_cadCidade.UseVisualStyleBackColor = true;
            btn_cadCidade.Click += btn_cadCidade_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 213);
            Controls.Add(btn_cadCidade);
            Controls.Add(textBox_uf);
            Controls.Add(label2);
            Controls.Add(textBox_cidade);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_cidade;
        private Label label2;
        private TextBox textBox_uf;
        private Button btn_cadCidade;
    }
}