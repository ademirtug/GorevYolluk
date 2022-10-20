namespace GorevYolluk
{
    partial class PersonelListesiForm
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
            this.elvPl = new wordNet.ELV();
            this.no = new wordNet.ELVColumnHeader();
            this.name = new wordNet.ELVColumnHeader();
            this.title = new wordNet.ELVColumnHeader();
            this.SuspendLayout();
            // 
            // elvPl
            // 
            this.elvPl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.name,
            this.title});
            this.elvPl.defEditor = null;
            this.elvPl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elvPl.FullRowSelect = true;
            this.elvPl.Location = new System.Drawing.Point(0, 0);
            this.elvPl.Name = "elvPl";
            this.elvPl.Size = new System.Drawing.Size(800, 450);
            this.elvPl.TabIndex = 0;
            this.elvPl.UseCompatibleStateImageBehavior = false;
            this.elvPl.View = System.Windows.Forms.View.Details;
            // 
            // no
            // 
            this.no.DefaultEditColumn = false;
            this.no.Editable = false;
            this.no.EditControl = wordNet.ControlTypes.TextBox;
            this.no.Text = "#";
            // 
            // name
            // 
            this.name.DefaultEditColumn = true;
            this.name.Editable = true;
            this.name.EditControl = wordNet.ControlTypes.TextBox;
            this.name.Text = "Ad";
            this.name.Width = 200;
            // 
            // title
            // 
            this.title.DefaultEditColumn = false;
            this.title.Editable = true;
            this.title.EditControl = wordNet.ControlTypes.TextBox;
            this.title.Text = "Ünvan";
            this.title.Width = 200;
            // 
            // PersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elvPl);
            this.Name = "PersonelListesi";
            this.ShowInTaskbar = false;
            this.Text = "PersonelListesi";
            this.ResumeLayout(false);

        }

        #endregion

        private wordNet.ELV elvPl;
        private wordNet.ELVColumnHeader no;
        private wordNet.ELVColumnHeader name;
        private wordNet.ELVColumnHeader title;
    }
}