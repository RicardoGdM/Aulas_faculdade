namespace Atividade_01
{
    partial class Form1
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
            titulo = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            salvarNota = new Button();
            progressBar1 = new ProgressBar();
            label7 = new Label();
            buscarAluno = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 20F);
            titulo.ImageAlign = ContentAlignment.TopCenter;
            titulo.Location = new Point(273, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(271, 37);
            titulo.TabIndex = 0;
            titulo.Text = "Fechamento de notas";
            titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do aluno: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "R.A.: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(576, 70);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Disciplina: ";
            label3.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Banco de Dados", "Computação Embarcada", "POO 2", "Segurança de Redes" });
            comboBox1.Location = new Point(576, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Selecione a discilpina...";
            comboBox1.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Atividade 01", "Prova 01", "Atividade 02", "Prova 02" });
            comboBox2.Location = new Point(576, 157);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 23);
            comboBox2.TabIndex = 7;
            comboBox2.Text = "Selecione a atividade...";
            comboBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 139);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 8;
            label4.Text = "Atividade / Prova";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 204);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Nota: ";
            label5.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(576, 222);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 23);
            textBox3.TabIndex = 10;
            textBox3.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(576, 276);
            label6.Name = "label6";
            label6.Size = new Size(134, 15);
            label6.TabIndex = 11;
            label6.Text = "Observações: (opcional)";
            label6.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(576, 294);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 23);
            textBox4.TabIndex = 12;
            textBox4.Visible = false;
            // 
            // salvarNota
            // 
            salvarNota.Location = new Point(652, 485);
            salvarNota.Name = "salvarNota";
            salvarNota.Size = new Size(125, 25);
            salvarNota.TabIndex = 13;
            salvarNota.Text = "Adicionar nota";
            salvarNota.UseVisualStyleBackColor = true;
            salvarNota.Visible = false;
            salvarNota.Click += salvarNota_Click;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.GreenYellow;
            progressBar1.Location = new Point(12, 222);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(244, 7);
            progressBar1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 204);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 15;
            label7.Text = "Nota total";
            // 
            // buscarAluno
            // 
            buscarAluno.Location = new Point(12, 487);
            buscarAluno.Name = "buscarAluno";
            buscarAluno.Size = new Size(139, 23);
            buscarAluno.TabIndex = 16;
            buscarAluno.Text = "Buscar aluno";
            buscarAluno.UseVisualStyleBackColor = true;
            buscarAluno.Click += buscarAluno_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(12, 114);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 17;
            label8.Text = "Nome inválido!";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(12, 183);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 18;
            label9.Text = "R.A. inválido!";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(576, 114);
            label10.Name = "label10";
            label10.Size = new Size(168, 15);
            label10.TabIndex = 19;
            label10.Text = "Por favor, selecione a isciplina!";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(576, 183);
            label11.Name = "label11";
            label11.Size = new Size(173, 15);
            label11.TabIndex = 20;
            label11.Text = "Por favor, selecione a atividade!";
            label11.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(576, 248);
            label12.Name = "label12";
            label12.Size = new Size(180, 15);
            label12.TabIndex = 21;
            label12.Text = "Por favor, insira uma nota válida!";
            label12.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 522);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(buscarAluno);
            Controls.Add(label7);
            Controls.Add(progressBar1);
            Controls.Add(salvarNota);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(titulo);
            Name = "Form1";
            Text = "Atividade 01";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Button salvarNota;
        private ProgressBar progressBar1;
        private Label label7;
        private Button buscarAluno;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
