namespace Simulado2
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
            lstClientes = new ListBox();
            menuStrip1 = new MenuStrip();
            cadastrarClientesToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCidadesToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            listarClientesToolStripMenuItem = new ToolStripMenuItem();
            listarCidadesToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(12, 82);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(570, 184);
            lstClientes.TabIndex = 12;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarClientesToolStripMenuItem, consultarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(612, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarClientesToolStripMenuItem
            // 
            cadastrarClientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, cadastrarCidadesToolStripMenuItem });
            cadastrarClientesToolStripMenuItem.Name = "cadastrarClientesToolStripMenuItem";
            cadastrarClientesToolStripMenuItem.Size = new Size(69, 20);
            cadastrarClientesToolStripMenuItem.Text = "Cadastrar";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(169, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar Clientes";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // cadastrarCidadesToolStripMenuItem
            // 
            cadastrarCidadesToolStripMenuItem.Name = "cadastrarCidadesToolStripMenuItem";
            cadastrarCidadesToolStripMenuItem.Size = new Size(169, 22);
            cadastrarCidadesToolStripMenuItem.Text = "Cadastrar Cidades";
            cadastrarCidadesToolStripMenuItem.Click += cadastrarCidadesToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listarClientesToolStripMenuItem, listarCidadesToolStripMenuItem });
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(70, 20);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // listarClientesToolStripMenuItem
            // 
            listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            listarClientesToolStripMenuItem.Size = new Size(147, 22);
            listarClientesToolStripMenuItem.Text = "Listar Clientes";
            // 
            // listarCidadesToolStripMenuItem
            // 
            listarCidadesToolStripMenuItem.Name = "listarCidadesToolStripMenuItem";
            listarCidadesToolStripMenuItem.Size = new Size(147, 22);
            listarCidadesToolStripMenuItem.Text = "Listar Cidades";
            // 
            // button1
            // 
            button1.Location = new Point(12, 38);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 302);
            Controls.Add(button1);
            Controls.Add(lstClientes);
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
        private ListBox lstClientes;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarClientesToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem cadastrarCidadesToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem listarClientesToolStripMenuItem;
        private ToolStripMenuItem listarCidadesToolStripMenuItem;
        private Button button1;
    }
}
