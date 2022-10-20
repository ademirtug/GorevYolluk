namespace GorevYolluk
{
    partial class Main
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seyyarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puantajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.veriToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1044, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "main";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seyyarToolStripMenuItem,
            this.puantajToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // seyyarToolStripMenuItem
            // 
            this.seyyarToolStripMenuItem.Name = "seyyarToolStripMenuItem";
            this.seyyarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seyyarToolStripMenuItem.Text = "Seyyar...";
            this.seyyarToolStripMenuItem.Click += new System.EventHandler(this.seyyarToolStripMenuItem_Click);
            // 
            // puantajToolStripMenuItem
            // 
            this.puantajToolStripMenuItem.Name = "puantajToolStripMenuItem";
            this.puantajToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puantajToolStripMenuItem.Text = "Puantaj...";
            this.puantajToolStripMenuItem.Click += new System.EventHandler(this.puantajToolStripMenuItem_Click);
            // 
            // veriToolStripMenuItem
            // 
            this.veriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelListesiToolStripMenuItem});
            this.veriToolStripMenuItem.Name = "veriToolStripMenuItem";
            this.veriToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.veriToolStripMenuItem.Text = "Veri";
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.personelListesiToolStripMenuItem.Text = "Personel Listesi";
            this.personelListesiToolStripMenuItem.Click += new System.EventHandler(this.personelListesiToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 662);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Main";
            this.Text = "Görev Yolluk";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem seyyarToolStripMenuItem;
        private ToolStripMenuItem puantajToolStripMenuItem;
        private ToolStripMenuItem veriToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem personelListesiToolStripMenuItem;
    }
}