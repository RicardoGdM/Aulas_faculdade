namespace Avaliacao_01
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
            cliente_nome = new TextBox();
            label2 = new Label();
            cliente_empresa = new TextBox();
            cliente_email = new TextBox();
            label3 = new Label();
            add_cliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do cliente:";
            // 
            // cliente_nome
            // 
            cliente_nome.Location = new Point(12, 27);
            cliente_nome.Name = "cliente_nome";
            cliente_nome.Size = new Size(210, 23);
            cliente_nome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Empresa:";
            // 
            // cliente_empresa
            // 
            cliente_empresa.Location = new Point(12, 84);
            cliente_empresa.Name = "cliente_empresa";
            cliente_empresa.Size = new Size(210, 23);
            cliente_empresa.TabIndex = 3;
            // 
            // cliente_email
            // 
            cliente_email.Location = new Point(12, 143);
            cliente_email.Name = "cliente_email";
            cliente_email.Size = new Size(210, 23);
            cliente_email.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Email:";
            // 
            // add_cliente
            // 
            add_cliente.Location = new Point(12, 199);
            add_cliente.Name = "add_cliente";
            add_cliente.Size = new Size(75, 23);
            add_cliente.TabIndex = 6;
            add_cliente.Text = "Salvar";
            add_cliente.UseVisualStyleBackColor = true;
            add_cliente.Click += add_cliente_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 340);
            Controls.Add(add_cliente);
            Controls.Add(label3);
            Controls.Add(cliente_email);
            Controls.Add(cliente_empresa);
            Controls.Add(label2);
            Controls.Add(cliente_nome);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Adicionar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox cliente_nome;
        private Label label2;
        private TextBox cliente_empresa;
        private TextBox cliente_email;
        private Label label3;
        private Button add_cliente;
    }
}