namespace Post.WinFormsClient.Controls
{
	partial class SearchControl
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
			this.SearchUserTextBox = new System.Windows.Forms.TextBox();
			this.SearchButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SearchUserTextBox
			// 
			this.SearchUserTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SearchUserTextBox.Location = new System.Drawing.Point(42, 39);
			this.SearchUserTextBox.Name = "SearchUserTextBox";
			this.SearchUserTextBox.Size = new System.Drawing.Size(245, 29);
			this.SearchUserTextBox.TabIndex = 0;
			// 
			// SearchButton
			// 
			this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SearchButton.FlatAppearance.BorderSize = 0;
			this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SearchButton.Image = global::Post.WinFormsClient.Properties.Resources._31914_200;
			this.SearchButton.Location = new System.Drawing.Point(302, 27);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(58, 50);
			this.SearchButton.TabIndex = 1;
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// SearchControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchUserTextBox);
			this.Name = "SearchControl";
			this.Size = new System.Drawing.Size(400, 103);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox SearchUserTextBox;
		private System.Windows.Forms.Button SearchButton;
	}
}
