namespace Avaliacao_01
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
            label2 = new Label();
            label3 = new Label();
            busca_tipo_trabalho = new ComboBox();
            data_trabalho = new DateTimePicker();
            busca_cliente = new ComboBox();
            add_trabalho = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 4;
            label3.Text = "Serviço Realizado:";
            // 
            // busca_tipo_trabalho
            // 
            busca_tipo_trabalho.FormattingEnabled = true;
            busca_tipo_trabalho.Location = new Point(12, 139);
            busca_tipo_trabalho.Name = "busca_tipo_trabalho";
            busca_tipo_trabalho.Size = new Size(241, 23);
            busca_tipo_trabalho.TabIndex = 5;
            // 
            // data_trabalho
            // 
            data_trabalho.Format = DateTimePickerFormat.Custom;
            data_trabalho.Location = new Point(12, 83);
            data_trabalho.Name = "data_trabalho";
            data_trabalho.Size = new Size(241, 23);
            data_trabalho.TabIndex = 6;
            data_trabalho.Value = new DateTime(2025, 4, 3, 0, 0, 0, 0);
            // 
            // busca_cliente
            // 
            busca_cliente.FormattingEnabled = true;
            busca_cliente.Location = new Point(12, 27);
            busca_cliente.Name = "busca_cliente";
            busca_cliente.Size = new Size(241, 23);
            busca_cliente.TabIndex = 7;
            // 
            // add_trabalho
            // 
            add_trabalho.Location = new Point(12, 204);
            add_trabalho.Name = "add_trabalho";
            add_trabalho.Size = new Size(75, 23);
            add_trabalho.TabIndex = 8;
            add_trabalho.Text = "Salvar";
            add_trabalho.UseVisualStyleBackColor = true;
            add_trabalho.Click += add_trabalho_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 307);
            Controls.Add(add_trabalho);
            Controls.Add(busca_cliente);
            Controls.Add(data_trabalho);
            Controls.Add(busca_tipo_trabalho);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Novo Serviço";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private ComboBox busca_tipo_trabalho;
        private DateTimePicker data_trabalho;
        private ComboBox busca_cliente;
        private Button add_trabalho;
    }
}