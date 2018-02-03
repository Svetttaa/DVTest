namespace Post.WinFormsClient.Controls
{
	partial class LoginControl
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
			this.BackToStartButton = new System.Windows.Forms.Button();
			this.LoginButton = new System.Windows.Forms.Button();
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.WarningLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BackToStartButton
			// 
			this.BackToStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BackToStartButton.BackColor = System.Drawing.Color.White;
			this.BackToStartButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BackToStartButton.FlatAppearance.BorderSize = 0;
			this.BackToStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BackToStartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BackToStartButton.ForeColor = System.Drawing.Color.RoyalBlue;
			this.BackToStartButton.Location = new System.Drawing.Point(-11, 164);
			this.BackToStartButton.Name = "BackToStartButton";
			this.BackToStartButton.Size = new System.Drawing.Size(163, 40);
			this.BackToStartButton.TabIndex = 2;
			this.BackToStartButton.Text = "Назад";
			this.BackToStartButton.UseVisualStyleBackColor = false;
			this.BackToStartButton.Click += new System.EventHandler(this.BackToStartButton_Click);
			// 
			// LoginButton
			// 
			this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LoginButton.BackColor = System.Drawing.Color.White;
			this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LoginButton.FlatAppearance.BorderSize = 0;
			this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoginButton.ForeColor = System.Drawing.Color.RoyalBlue;
			this.LoginButton.Location = new System.Drawing.Point(129, 164);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(163, 40);
			this.LoginButton.TabIndex = 2;
			this.LoginButton.Text = "Войти";
			this.LoginButton.UseVisualStyleBackColor = false;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LoginTextBox.BackColor = System.Drawing.Color.White;
			this.LoginTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoginTextBox.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.LoginTextBox.Location = new System.Drawing.Point(39, 21);
			this.LoginTextBox.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(200, 33);
			this.LoginTextBox.TabIndex = 0;
			this.LoginTextBox.Text = "Электронная почта";
			this.LoginTextBox.Enter += new System.EventHandler(this.LoginTextbox_Enter);
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PasswordTextBox.BackColor = System.Drawing.Color.White;
			this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PasswordTextBox.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.PasswordTextBox.Location = new System.Drawing.Point(39, 74);
			this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(5);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(200, 33);
			this.PasswordTextBox.TabIndex = 1;
			this.PasswordTextBox.Text = "Пароль";
			this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextbox_Enter);
			// 
			// WarningLabel
			// 
			this.WarningLabel.AutoSize = true;
			this.WarningLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.WarningLabel.ForeColor = System.Drawing.Color.Red;
			this.WarningLabel.Location = new System.Drawing.Point(35, 125);
			this.WarningLabel.Name = "WarningLabel";
			this.WarningLabel.Size = new System.Drawing.Size(83, 20);
			this.WarningLabel.TabIndex = 3;
			this.WarningLabel.Text = "Ошибочки";
			this.WarningLabel.Visible = false;
			this.WarningLabel.Click += new System.EventHandler(this.WarningLabel_Click);
			// 
			// LoginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.WarningLabel);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.LoginTextBox);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.BackToStartButton);
			this.Name = "LoginControl";
			this.Size = new System.Drawing.Size(274, 228);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BackToStartButton;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.TextBox LoginTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Label WarningLabel;
	}
}
