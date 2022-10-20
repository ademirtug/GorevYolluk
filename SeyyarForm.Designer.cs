namespace GorevYolluk
{
    partial class SeyyarForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tv_personel = new System.Windows.Forms.TreeView();
            this.lv_gorevler = new System.Windows.Forms.ListView();
            this.order = new System.Windows.Forms.ColumnHeader();
            this.gorev_no = new System.Windows.Forms.ColumnHeader();
            this.gorev_yeri = new System.Windows.Forms.ColumnHeader();
            this.gorev_baslangic = new System.Windows.Forms.ColumnHeader();
            this.gorev_donus = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tv_personel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lv_gorevler);
            this.splitContainer1.Size = new System.Drawing.Size(918, 561);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 0;
            // 
            // tv_personel
            // 
            this.tv_personel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_personel.Location = new System.Drawing.Point(0, 0);
            this.tv_personel.Name = "tv_personel";
            this.tv_personel.Size = new System.Drawing.Size(258, 561);
            this.tv_personel.TabIndex = 0;
            this.tv_personel.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_personel_NodeMouseClick);
            // 
            // lv_gorevler
            // 
            this.lv_gorevler.CheckBoxes = true;
            this.lv_gorevler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.order,
            this.gorev_no,
            this.gorev_yeri,
            this.gorev_baslangic,
            this.gorev_donus});
            this.lv_gorevler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_gorevler.Location = new System.Drawing.Point(0, 0);
            this.lv_gorevler.Name = "lv_gorevler";
            this.lv_gorevler.Size = new System.Drawing.Size(656, 561);
            this.lv_gorevler.TabIndex = 1;
            this.lv_gorevler.UseCompatibleStateImageBehavior = false;
            this.lv_gorevler.View = System.Windows.Forms.View.Details;
            // 
            // order
            // 
            this.order.Text = "#";
            // 
            // gorev_no
            // 
            this.gorev_no.Text = "Görev No";
            this.gorev_no.Width = 160;
            // 
            // gorev_yeri
            // 
            this.gorev_yeri.Text = "Görev Yeri";
            this.gorev_yeri.Width = 100;
            // 
            // gorev_baslangic
            // 
            this.gorev_baslangic.Text = "Görev Başlangıç";
            this.gorev_baslangic.Width = 150;
            // 
            // gorev_donus
            // 
            this.gorev_donus.Text = "Görev Dönüş";
            this.gorev_donus.Width = 150;
            // 
            // SeyyarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SeyyarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SeyyarForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView tv_personel;
        private ListView lv_gorevler;
        private ColumnHeader order;
        private ColumnHeader gorev_no;
        private ColumnHeader gorev_yeri;
        private ColumnHeader gorev_baslangic;
        private ColumnHeader gorev_donus;
    }
}