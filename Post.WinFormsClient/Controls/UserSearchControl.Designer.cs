namespace Post.WinFormsClient.Controls
{
	partial class UserSearchControl
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
			this.NameLabel = new System.Windows.Forms.Label();
			this.WriteLetterButton = new System.Windows.Forms.Button();
			this.AccountLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(18, 9);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(50, 20);
			this.NameLabel.TabIndex = 1;
			this.NameLabel.Text = "label1";
			this.NameLabel.Click += new System.EventHandler(this.WriteLetterButton_Click);
			// 
			// WriteLetterButton
			// 
			this.WriteLetterButton.FlatAppearance.BorderSize = 0;
			this.WriteLetterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.WriteLetterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.WriteLetterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WriteLetterButton.Image = global::Post.WinFormsClient.Properties.Resources.contract__1_;
			this.WriteLetterButton.Location = new System.Drawing.Point(225, 9);
			this.WriteLetterButton.Name = "WriteLetterButton";
			this.WriteLetterButton.Size = new System.Drawing.Size(65, 50);
			this.WriteLetterButton.TabIndex = 0;
			this.WriteLetterButton.UseVisualStyleBackColor = true;
			this.WriteLetterButton.Click += new System.EventHandler(this.WriteLetterButton_Click);
			// 
			// AccountLabel
			// 
			this.AccountLabel.AutoSize = true;
			this.AccountLabel.Location = new System.Drawing.Point(18, 29);
			this.AccountLabel.Name = "AccountLabel";
			this.AccountLabel.Size = new System.Drawing.Size(50, 20);
			this.AccountLabel.TabIndex = 2;
			this.AccountLabel.Text = "label1";
			this.AccountLabel.Click += new System.EventHandler(this.WriteLetterButton_Click);
			// 
			// UserSearchControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.AccountLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.WriteLetterButton);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "UserSearchControl";
			this.Size = new System.Drawing.Size(293, 66);
			this.Click += new System.EventHandler(this.WriteLetterButton_Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button WriteLetterButton;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label AccountLabel;
	}
}
