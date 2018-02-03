namespace Post.WinFormsClient.Forms
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.SettingsButton = new System.Windows.Forms.Button();
			this.WriteLetterButton = new System.Windows.Forms.Button();
			this.UserExitButton = new System.Windows.Forms.Button();
			this.CurrentUserLabel = new System.Windows.Forms.Label();
			this.UserSearchButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.SettingsButton);
			this.panel1.Controls.Add(this.WriteLetterButton);
			this.panel1.Controls.Add(this.UserExitButton);
			this.panel1.Controls.Add(this.CurrentUserLabel);
			this.panel1.Controls.Add(this.UserSearchButton);
			this.panel1.Location = new System.Drawing.Point(-6, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(352, 87);
			this.panel1.TabIndex = 0;
			// 
			// SettingsButton
			// 
			this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SettingsButton.FlatAppearance.BorderSize = 0;
			this.SettingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
			this.SettingsButton.Location = new System.Drawing.Point(173, 46);
			this.SettingsButton.Name = "SettingsButton";
			this.SettingsButton.Size = new System.Drawing.Size(75, 35);
			this.SettingsButton.TabIndex = 1;
			this.SettingsButton.UseVisualStyleBackColor = true;
			this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
			// 
			// WriteLetterButton
			// 
			this.WriteLetterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WriteLetterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.WriteLetterButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WriteLetterButton.FlatAppearance.BorderSize = 0;
			this.WriteLetterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.WriteLetterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.WriteLetterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WriteLetterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.WriteLetterButton.Image = ((System.Drawing.Image)(resources.GetObject("WriteLetterButton.Image")));
			this.WriteLetterButton.Location = new System.Drawing.Point(11, 44);
			this.WriteLetterButton.Name = "WriteLetterButton";
			this.WriteLetterButton.Size = new System.Drawing.Size(75, 35);
			this.WriteLetterButton.TabIndex = 4;
			this.WriteLetterButton.UseVisualStyleBackColor = true;
			this.WriteLetterButton.Click += new System.EventHandler(this.WriteLetterButton_Click);
			// 
			// UserExitButton
			// 
			this.UserExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UserExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UserExitButton.FlatAppearance.BorderSize = 0;
			this.UserExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.UserExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.UserExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UserExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserExitButton.Image = ((System.Drawing.Image)(resources.GetObject("UserExitButton.Image")));
			this.UserExitButton.Location = new System.Drawing.Point(254, 43);
			this.UserExitButton.Name = "UserExitButton";
			this.UserExitButton.Size = new System.Drawing.Size(75, 38);
			this.UserExitButton.TabIndex = 3;
			this.UserExitButton.UseVisualStyleBackColor = true;
			this.UserExitButton.Click += new System.EventHandler(this.UserExitButton_Click);
			// 
			// CurrentUserLabel
			// 
			this.CurrentUserLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CurrentUserLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CurrentUserLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.CurrentUserLabel.Location = new System.Drawing.Point(3, 0);
			this.CurrentUserLabel.Name = "CurrentUserLabel";
			this.CurrentUserLabel.Size = new System.Drawing.Size(349, 30);
			this.CurrentUserLabel.TabIndex = 2;
			this.CurrentUserLabel.Text = "Пользователь";
			this.CurrentUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UserSearchButton
			// 
			this.UserSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UserSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UserSearchButton.FlatAppearance.BorderSize = 0;
			this.UserSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.UserSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UserSearchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("UserSearchButton.Image")));
			this.UserSearchButton.Location = new System.Drawing.Point(92, 46);
			this.UserSearchButton.Name = "UserSearchButton";
			this.UserSearchButton.Size = new System.Drawing.Size(75, 35);
			this.UserSearchButton.TabIndex = 0;
			this.UserSearchButton.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(0, 93);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(346, 403);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(352, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(578, 495);
			this.panel3.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(925, 492);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Post";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label CurrentUserLabel;
		private System.Windows.Forms.Button SettingsButton;
		private System.Windows.Forms.Button UserSearchButton;
		private System.Windows.Forms.Button WriteLetterButton;
		private System.Windows.Forms.Button UserExitButton;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
	}
}