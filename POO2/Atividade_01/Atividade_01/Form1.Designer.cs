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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            titulo = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
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
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            nomeAluno = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 20F);
            titulo.ImageAlign = ContentAlignment.TopCenter;
            titulo.Location = new Point(298, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(271, 37);
            titulo.TabIndex = 0;
            titulo.Text = "Fechamento de notas";
            titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 136);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Busca:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(652, 67);
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
            comboBox1.Location = new Point(652, 85);
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
            comboBox2.Location = new Point(652, 154);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 23);
            comboBox2.TabIndex = 7;
            comboBox2.Text = "Selecione a atividade...";
            comboBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(652, 136);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 8;
            label4.Text = "Atividade / Prova";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(652, 201);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Nota: ";
            label5.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(652, 219);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 23);
            textBox3.TabIndex = 10;
            textBox3.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(652, 273);
            label6.Name = "label6";
            label6.Size = new Size(134, 15);
            label6.TabIndex = 11;
            label6.Text = "Observações: (opcional)";
            label6.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(652, 291);
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
            progressBar1.Location = new Point(12, 221);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(244, 7);
            progressBar1.TabIndex = 14;
            progressBar1.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 203);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 15;
            label7.Text = "Nota: ";
            label7.Visible = false;
            // 
            // buscarAluno
            // 
            buscarAluno.Location = new Point(367, 265);
            buscarAluno.Name = "buscarAluno";
            buscarAluno.Size = new Size(139, 23);
            buscarAluno.TabIndex = 16;
            buscarAluno.Text = "Buscar aluno";
            buscarAluno.UseVisualStyleBackColor = true;
            buscarAluno.Click += buscarAluno_Click;
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(652, 111);
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
            label11.Location = new Point(652, 180);
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
            label12.Location = new Point(652, 245);
            label12.Name = "label12";
            label12.Size = new Size(180, 15);
            label12.TabIndex = 21;
            label12.Text = "Por favor, insira uma nota válida!";
            label12.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(298, 203);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 19);
            radioButton1.TabIndex = 22;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nome";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(523, 203);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(46, 19);
            radioButton2.TabIndex = 23;
            radioButton2.Text = "R.A.";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // nomeAluno
            // 
            nomeAluno.AutoSize = true;
            nomeAluno.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            nomeAluno.Location = new Point(12, 154);
            nomeAluno.Name = "nomeAluno";
            nomeAluno.Size = new Size(58, 19);
            nomeAluno.TabIndex = 25;
            nomeAluno.Text = "Nome: ";
            nomeAluno.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(298, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 23);
            textBox2.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(298, 180);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 29;
            label2.Text = "Dados inválidos!";
            label2.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 180);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 30;
            label9.Text = "R.A.: ";
            label9.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 522);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(nomeAluno);
            Controls.Add(pictureBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
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
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(titulo);
            Name = "Form1";
            Text = "Atividade 01";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label label1;
        private TextBox textBox1;
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
        private Label label10;
        private Label label11;
        private Label label12;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label nomeAluno;
        private TextBox textBox2;
        private Label label2;
        private Label label9;
        private PictureBox pictureBox1;
    }
}
