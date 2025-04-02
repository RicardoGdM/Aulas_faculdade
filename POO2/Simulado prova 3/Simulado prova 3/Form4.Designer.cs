namespace Simulado_prova_3
{
    partial class Form4
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
            busca_nome = new TextBox();
            lst_busca = new ListBox();
            btn_buscar = new Button();
            btn_apagar = new Button();
            atualizarCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Buscar nome:";
            // 
            // busca_nome
            // 
            busca_nome.Location = new Point(12, 26);
            busca_nome.Name = "busca_nome";
            busca_nome.Size = new Size(222, 23);
            busca_nome.TabIndex = 1;
            // 
            // lst_busca
            // 
            lst_busca.FormattingEnabled = true;
            lst_busca.ItemHeight = 15;
            lst_busca.Location = new Point(12, 66);
            lst_busca.Name = "lst_busca";
            lst_busca.Size = new Size(340, 274);
            lst_busca.TabIndex = 2;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(277, 26);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(75, 23);
            btn_buscar.TabIndex = 3;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_apagar
            // 
            btn_apagar.Location = new Point(12, 361);
            btn_apagar.Name = "btn_apagar";
            btn_apagar.Size = new Size(125, 23);
            btn_apagar.TabIndex = 4;
            btn_apagar.Text = "Apagar cadastro";
            btn_apagar.UseVisualStyleBackColor = true;
            btn_apagar.Click += btn_apagar_Click;
            // 
            // atualizarCliente
            // 
            atualizarCliente.Location = new Point(229, 361);
            atualizarCliente.Name = "atualizarCliente";
            atualizarCliente.Size = new Size(123, 23);
            atualizarCliente.TabIndex = 5;
            atualizarCliente.Text = "Atualizar cliente";
            atualizarCliente.UseVisualStyleBackColor = true;
            atualizarCliente.Click += atualizarCliente_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(atualizarCliente);
            Controls.Add(btn_apagar);
            Controls.Add(btn_buscar);
            Controls.Add(lst_busca);
            Controls.Add(busca_nome);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox busca_nome;
        private ListBox lst_busca;
        private Button btn_buscar;
        private Button btn_apagar;
        private Button atualizarCliente;
    }
}