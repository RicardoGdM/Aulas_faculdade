namespace Simulado2
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
            button2 = new Button();
            uf_estado = new TextBox();
            nome_cidade = new TextBox();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(214, 100);
            button2.Name = "button2";
            button2.Size = new Size(138, 23);
            button2.TabIndex = 14;
            button2.Text = "Cadastrar cidade";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // uf_estado
            // 
            uf_estado.Location = new Point(520, 35);
            uf_estado.Name = "uf_estado";
            uf_estado.Size = new Size(39, 23);
            uf_estado.TabIndex = 13;
            // 
            // nome_cidade
            // 
            nome_cidade.Location = new Point(12, 35);
            nome_cidade.Name = "nome_cidade";
            nome_cidade.Size = new Size(276, 23);
            nome_cidade.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 17);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 11;
            label4.Text = "UF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 17);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 10;
            label3.Text = "Cidade:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 135);
            Controls.Add(button2);
            Controls.Add(uf_estado);
            Controls.Add(nome_cidade);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox uf_estado;
        private TextBox nome_cidade;
        private Label label4;
        private Label label3;
    }
}