namespace Asamblor
{
    partial class Asamblor
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainBox = new System.Windows.Forms.TextBox();
            this.openEmulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.executionToolStripMenuItem,
            this.openEmulatorToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filesToolStripMenuItem.Text = "Files...";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // executionToolStripMenuItem
            // 
            this.executionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileToolStripMenuItem,
            this.writeOutToolStripMenuItem});
            this.executionToolStripMenuItem.Name = "executionToolStripMenuItem";
            this.executionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.executionToolStripMenuItem.Text = "Execution...";
            this.executionToolStripMenuItem.Click += new System.EventHandler(this.executionToolStripMenuItem_Click);
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.compileToolStripMenuItem.Text = "Compile...";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // writeOutToolStripMenuItem
            // 
            this.writeOutToolStripMenuItem.Name = "writeOutToolStripMenuItem";
            this.writeOutToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.writeOutToolStripMenuItem.Text = "Write Out...";
            this.writeOutToolStripMenuItem.Click += new System.EventHandler(this.writeOutToolStripMenuItem_Click);
            // 
            // mainBox
            // 
            this.mainBox.Location = new System.Drawing.Point(12, 27);
            this.mainBox.Multiline = true;
            this.mainBox.Name = "mainBox";
            this.mainBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainBox.Size = new System.Drawing.Size(776, 411);
            this.mainBox.TabIndex = 1;
            this.mainBox.Text = "mainBox";
            // 
            // openEmulatorToolStripMenuItem
            // 
            this.openEmulatorToolStripMenuItem.Name = "openEmulatorToolStripMenuItem";
            this.openEmulatorToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.openEmulatorToolStripMenuItem.Text = "Open Emulator...";
            this.openEmulatorToolStripMenuItem.Click += new System.EventHandler(this.openEmulatorToolStripMenuItem_Click);
            // 
            // Asamblor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Asamblor";
            this.Text = "Asamblor";
            this.Load += new System.EventHandler(this.Asamblor_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem executionToolStripMenuItem;
        private ToolStripMenuItem compileToolStripMenuItem;
        private ToolStripMenuItem writeOutToolStripMenuItem;
        private TextBox mainBox;
        private ToolStripMenuItem openEmulatorToolStripMenuItem;
    }
}