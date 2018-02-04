namespace Post.WinFormsClient.Controls
{
	partial class PreviewLetterControl
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
			this.DateLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.TextLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// DateLabel
			// 
			this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DateLabel.Location = new System.Drawing.Point(238, -1);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(84, 76);
			this.DateLabel.TabIndex = 0;
			this.DateLabel.Text = "Date";
			this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DateLabel.Click += new System.EventHandler(this.PreviewLetterControl_Click);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameLabel.Location = new System.Drawing.Point(13, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(43, 17);
			this.NameLabel.TabIndex = 1;
			this.NameLabel.Text = "Name";
			this.NameLabel.Click += new System.EventHandler(this.PreviewLetterControl_Click);
			// 
			// TextLabel
			// 
			this.TextLabel.AutoSize = true;
			this.TextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TextLabel.Location = new System.Drawing.Point(12, 47);
			this.TextLabel.Name = "TextLabel";
			this.TextLabel.Size = new System.Drawing.Size(78, 21);
			this.TextLabel.TabIndex = 2;
			this.TextLabel.Text = "TextLetter";
			this.TextLabel.Click += new System.EventHandler(this.PreviewLetterControl_Click);
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleLabel.Location = new System.Drawing.Point(13, 17);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(32, 17);
			this.TitleLabel.TabIndex = 3;
			this.TitleLabel.Text = "Title";
			this.TitleLabel.Click += new System.EventHandler(this.PreviewLetterControl_Click);
			// 
			// PreviewLetterControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.TextLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.DateLabel);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Name = "PreviewLetterControl";
			this.Size = new System.Drawing.Size(321, 74);
			this.Click += new System.EventHandler(this.PreviewLetterControl_Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label TextLabel;
		private System.Windows.Forms.Label TitleLabel;
	}
}
