namespace trajning
{
    partial class nav
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pagesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagesatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagesaToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pagesaToolStripMenuItem
            // 
            this.pagesaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagesatToolStripMenuItem});
            this.pagesaToolStripMenuItem.Name = "pagesaToolStripMenuItem";
            this.pagesaToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.pagesaToolStripMenuItem.Text = "Pagesa";
            // 
            // pagesatToolStripMenuItem
            // 
            this.pagesatToolStripMenuItem.Name = "pagesatToolStripMenuItem";
            this.pagesatToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.pagesatToolStripMenuItem.Text = "Pagesat";
            this.pagesatToolStripMenuItem.Click += new System.EventHandler(this.pagesatToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listatToolStripMenuItem});
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.listaToolStripMenuItem.Text = "Lista";
            // 
            // listatToolStripMenuItem
            // 
            this.listatToolStripMenuItem.Name = "listatToolStripMenuItem";
            this.listatToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.listatToolStripMenuItem.Text = "Listat ";
            this.listatToolStripMenuItem.Click += new System.EventHandler(this.listatToolStripMenuItem_Click);
            // 
            // nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "nav";
            this.Text = "nav";
            this.Load += new System.EventHandler(this.nav_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pagesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagesatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listatToolStripMenuItem;
    }
}