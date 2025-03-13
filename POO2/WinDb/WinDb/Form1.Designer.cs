namespace WinDb
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
            Adicionar = new Button();
            Editar = new Button();
            Excluir = new Button();
            lstItens = new ListBox();
            txtDescricao = new TextBox();
            SuspendLayout();
            // 
            // Adicionar
            // 
            Adicionar.Location = new Point(12, 12);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(75, 23);
            Adicionar.TabIndex = 0;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // Editar
            // 
            Editar.Location = new Point(93, 12);
            Editar.Name = "Editar";
            Editar.Size = new Size(75, 23);
            Editar.TabIndex = 1;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // Excluir
            // 
            Excluir.Location = new Point(12, 185);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(75, 23);
            Excluir.TabIndex = 2;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            Excluir.Click += Excluir_Click;
            // 
            // lstItens
            // 
            lstItens.FormattingEnabled = true;
            lstItens.ItemHeight = 15;
            lstItens.Location = new Point(12, 70);
            lstItens.Name = "lstItens";
            lstItens.Size = new Size(156, 109);
            lstItens.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 41);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(156, 23);
            txtDescricao.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDescricao);
            Controls.Add(lstItens);
            Controls.Add(Excluir);
            Controls.Add(Editar);
            Controls.Add(Adicionar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Adicionar;
        private Button Editar;
        private Button Excluir;
        private ListBox lstItens;
        private TextBox txtDescricao;
    }
}
