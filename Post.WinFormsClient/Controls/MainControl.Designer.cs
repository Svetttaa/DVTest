namespace Post.WinFormsClient.Controls
{
	partial class MainControl
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
			this.HelloLabel = new System.Windows.Forms.Label();
			this.ChangePasswButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// HelloLabel
			// 
			this.HelloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HelloLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.HelloLabel.Location = new System.Drawing.Point(0, 59);
			this.HelloLabel.Name = "HelloLabel";
			this.HelloLabel.Size = new System.Drawing.Size(530, 78);
			this.HelloLabel.TabIndex = 0;
			this.HelloLabel.Text = ":)";
			this.HelloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ChangePasswButton
			// 
			this.ChangePasswButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ChangePasswButton.BackColor = System.Drawing.Color.White;
			this.ChangePasswButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ChangePasswButton.FlatAppearance.BorderSize = 0;
			this.ChangePasswButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.ChangePasswButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.ChangePasswButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChangePasswButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ChangePasswButton.Location = new System.Drawing.Point(82, 127);
			this.ChangePasswButton.Name = "ChangePasswButton";
			this.ChangePasswButton.Size = new System.Drawing.Size(340, 63);
			this.ChangePasswButton.TabIndex = 1;
			this.ChangePasswButton.Text = "Сменить пароль";
			this.ChangePasswButton.UseVisualStyleBackColor = false;
			this.ChangePasswButton.Visible = false;
			this.ChangePasswButton.Click += new System.EventHandler(this.ChangePasswButton_Click);
			// 
			// MainControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.ChangePasswButton);
			this.Controls.Add(this.HelloLabel);
			this.Name = "MainControl";
			this.Size = new System.Drawing.Size(530, 278);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label HelloLabel;
		private System.Windows.Forms.Button ChangePasswButton;
	}
}
