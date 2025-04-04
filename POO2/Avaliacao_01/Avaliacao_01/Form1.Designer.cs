namespace Avaliacao_01
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
            menuStrip1 = new MenuStrip();
            novoClienteToolStripMenuItem = new ToolStripMenuItem();
            novoServiçoToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            lst_relatorio = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { novoClienteToolStripMenuItem, novoServiçoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // novoClienteToolStripMenuItem
            // 
            novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            novoClienteToolStripMenuItem.Size = new Size(88, 20);
            novoClienteToolStripMenuItem.Text = "Novo Cliente";
            novoClienteToolStripMenuItem.Click += novoClienteToolStripMenuItem_Click;
            // 
            // novoServiçoToolStripMenuItem
            // 
            novoServiçoToolStripMenuItem.Name = "novoServiçoToolStripMenuItem";
            novoServiçoToolStripMenuItem.Size = new Size(89, 20);
            novoServiçoToolStripMenuItem.Text = "Novo Serviço";
            novoServiçoToolStripMenuItem.Click += novoServiçoToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 1;
            label1.Text = "Ultimos trabalhos cadastrados:";
            // 
            // lst_relatorio
            // 
            lst_relatorio.FormattingEnabled = true;
            lst_relatorio.ItemHeight = 15;
            lst_relatorio.Location = new Point(12, 58);
            lst_relatorio.Name = "lst_relatorio";
            lst_relatorio.Size = new Size(776, 379);
            lst_relatorio.TabIndex = 2;
            lst_relatorio.SelectedIndexChanged += lst_relatorio_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lst_relatorio);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem novoClienteToolStripMenuItem;
        private ToolStripMenuItem novoServiçoToolStripMenuItem;
        private Label label1;
        private ListBox lst_relatorio;
    }
}
