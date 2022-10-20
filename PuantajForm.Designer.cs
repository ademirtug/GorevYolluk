namespace GorevYolluk
{
    partial class PuantajForm
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
			this.lbl_puantajFile = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.lbl_gorev = new System.Windows.Forms.Label();
			this.btn_hazırla = new System.Windows.Forms.Button();
			this.rtb_out = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// lbl_puantajFile
			// 
			this.lbl_puantajFile.AutoSize = true;
			this.lbl_puantajFile.Location = new System.Drawing.Point(172, 16);
			this.lbl_puantajFile.Name = "lbl_puantajFile";
			this.lbl_puantajFile.Size = new System.Drawing.Size(16, 15);
			this.lbl_puantajFile.TabIndex = 1;
			this.lbl_puantajFile.Text = "...";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(154, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Puantaj Dosyası Seç...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(154, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Görev Listesi Seç...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// lbl_gorev
			// 
			this.lbl_gorev.AutoSize = true;
			this.lbl_gorev.Location = new System.Drawing.Point(172, 45);
			this.lbl_gorev.Name = "lbl_gorev";
			this.lbl_gorev.Size = new System.Drawing.Size(16, 15);
			this.lbl_gorev.TabIndex = 4;
			this.lbl_gorev.Text = "...";
			// 
			// btn_hazırla
			// 
			this.btn_hazırla.Enabled = false;
			this.btn_hazırla.Location = new System.Drawing.Point(12, 70);
			this.btn_hazırla.Name = "btn_hazırla";
			this.btn_hazırla.Size = new System.Drawing.Size(154, 23);
			this.btn_hazırla.TabIndex = 5;
			this.btn_hazırla.Text = "Hazırla";
			this.btn_hazırla.UseVisualStyleBackColor = true;
			this.btn_hazırla.Click += new System.EventHandler(this.btn_hazırla_Click);
			// 
			// rtb_out
			// 
			this.rtb_out.Location = new System.Drawing.Point(12, 99);
			this.rtb_out.Name = "rtb_out";
			this.rtb_out.Size = new System.Drawing.Size(776, 339);
			this.rtb_out.TabIndex = 6;
			this.rtb_out.Text = "";
			// 
			// puantaj
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rtb_out);
			this.Controls.Add(this.btn_hazırla);
			this.Controls.Add(this.lbl_gorev);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lbl_puantajFile);
			this.Name = "puantaj";
			this.ShowInTaskbar = false;
			this.Text = "puantaj";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Label lbl_puantajFile;
        private Button button1;
        private Button button2;
        private Label lbl_gorev;
        private Button btn_hazırla;
        private RichTextBox rtb_out;
    }
}