﻿namespace Menu
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            abreUmaJanelaToolStripMenuItem = new ToolStripMenuItem();
            abreUmaJanelaMDIToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { abreUmaJanelaToolStripMenuItem, abreUmaJanelaMDIToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(66, 20);
            toolStripMenuItem1.Text = "Arquivos";
            // 
            // abreUmaJanelaToolStripMenuItem
            // 
            abreUmaJanelaToolStripMenuItem.Name = "abreUmaJanelaToolStripMenuItem";
            abreUmaJanelaToolStripMenuItem.Size = new Size(185, 22);
            abreUmaJanelaToolStripMenuItem.Text = "Abre uma janela";
            abreUmaJanelaToolStripMenuItem.Click += abreUmaJanelaToolStripMenuItem_Click;
            // 
            // abreUmaJanelaMDIToolStripMenuItem
            // 
            abreUmaJanelaMDIToolStripMenuItem.Name = "abreUmaJanelaMDIToolStripMenuItem";
            abreUmaJanelaMDIToolStripMenuItem.Size = new Size(185, 22);
            abreUmaJanelaMDIToolStripMenuItem.Text = "Abre uma janela MDI";
            abreUmaJanelaMDIToolStripMenuItem.Click += abreUmaJanelaMDIToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Meu primeiro sistema";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem abreUmaJanelaToolStripMenuItem;
        private ToolStripMenuItem abreUmaJanelaMDIToolStripMenuItem;
    }
}
