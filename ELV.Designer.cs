namespace wordNet
{
	partial class ELV
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textbox = new System.Windows.Forms.TextBox();
			this.checkbox = new System.Windows.Forms.CheckBox();
			this.combobox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// textbox
			// 
			this.textbox.Location = new System.Drawing.Point(0, 0);
			this.textbox.Name = "textbox";
			this.textbox.Size = new System.Drawing.Size(100, 20);
			this.textbox.TabIndex = 0;
			this.textbox.Visible = false;
			// 
			// checkbox
			// 
			this.checkbox.AutoSize = true;
			this.checkbox.Location = new System.Drawing.Point(0, 0);
			this.checkbox.Name = "checkbox";
			this.checkbox.Size = new System.Drawing.Size(104, 24);
			this.checkbox.TabIndex = 0;
			this.checkbox.Text = "checkBox1";
			this.checkbox.UseVisualStyleBackColor = true;
			this.checkbox.Visible = false;
			// 
			// combobox
			// 
			this.combobox.FormattingEnabled = true;
			this.combobox.Location = new System.Drawing.Point(0, 0);
			this.combobox.Name = "combobox";
			this.combobox.Size = new System.Drawing.Size(121, 21);
			this.combobox.TabIndex = 0;
			this.combobox.Visible = false;
			// 
			// ELV
			// 
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ELV_KeyDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ELV_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion

		private TextBox textbox;
		private CheckBox checkbox;
		private ComboBox combobox;
	}
}
