namespace Post.WinFormsClient.Controls
{
	partial class ChangePasswordControl
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.PassTextBox = new System.Windows.Forms.TextBox();
			this.PassAgainTextBox = new System.Windows.Forms.TextBox();
			this.SaveNewPassButton = new System.Windows.Forms.Button();
			this.ErrorsLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(78, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Пароль";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(3, 165);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Пароль еще раз";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(119, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 30);
			this.label3.TabIndex = 2;
			this.label3.Text = "Смена пароля";
			// 
			// PassTextBox
			// 
			this.PassTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PassTextBox.BackColor = System.Drawing.Color.White;
			this.PassTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PassTextBox.Location = new System.Drawing.Point(183, 99);
			this.PassTextBox.Name = "PassTextBox";
			this.PassTextBox.Size = new System.Drawing.Size(217, 33);
			this.PassTextBox.TabIndex = 3;
			// 
			// PassAgainTextBox
			// 
			this.PassAgainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PassAgainTextBox.BackColor = System.Drawing.Color.White;
			this.PassAgainTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PassAgainTextBox.Location = new System.Drawing.Point(183, 162);
			this.PassAgainTextBox.Name = "PassAgainTextBox";
			this.PassAgainTextBox.Size = new System.Drawing.Size(217, 33);
			this.PassAgainTextBox.TabIndex = 4;
			// 
			// SaveNewPassButton
			// 
			this.SaveNewPassButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveNewPassButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SaveNewPassButton.FlatAppearance.BorderSize = 0;
			this.SaveNewPassButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.SaveNewPassButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.SaveNewPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveNewPassButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SaveNewPassButton.Location = new System.Drawing.Point(124, 254);
			this.SaveNewPassButton.Name = "SaveNewPassButton";
			this.SaveNewPassButton.Size = new System.Drawing.Size(128, 37);
			this.SaveNewPassButton.TabIndex = 5;
			this.SaveNewPassButton.Text = "Сохранить";
			this.SaveNewPassButton.UseVisualStyleBackColor = true;
			this.SaveNewPassButton.Click += new System.EventHandler(this.SaveNewPassButton_Click);
			// 
			// ErrorsLabel
			// 
			this.ErrorsLabel.AutoSize = true;
			this.ErrorsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ErrorsLabel.ForeColor = System.Drawing.Color.Red;
			this.ErrorsLabel.Location = new System.Drawing.Point(121, 217);
			this.ErrorsLabel.Name = "ErrorsLabel";
			this.ErrorsLabel.Size = new System.Drawing.Size(75, 17);
			this.ErrorsLabel.TabIndex = 6;
			this.ErrorsLabel.Text = "ErrorsLabel";
			this.ErrorsLabel.Visible = false;
			// 
			// ChangePasswordControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.ErrorsLabel);
			this.Controls.Add(this.SaveNewPassButton);
			this.Controls.Add(this.PassAgainTextBox);
			this.Controls.Add(this.PassTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ChangePasswordControl";
			this.Size = new System.Drawing.Size(414, 308);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PassTextBox;
		private System.Windows.Forms.TextBox PassAgainTextBox;
		private System.Windows.Forms.Button SaveNewPassButton;
		private System.Windows.Forms.Label ErrorsLabel;
	}
}
