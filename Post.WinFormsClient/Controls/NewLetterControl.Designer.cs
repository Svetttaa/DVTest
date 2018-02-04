﻿namespace Post.WinFormsClient.Controls
{
	partial class NewLetterControl
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
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.TextLetterTextBox = new System.Windows.Forms.TextBox();
			this.UserToDropDown = new System.Windows.Forms.ComboBox();
			this.AttachButton = new System.Windows.Forms.Button();
			this.SendButton = new System.Windows.Forms.Button();
			this.AttachesLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TitleTextBox
			// 
			this.TitleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleTextBox.Location = new System.Drawing.Point(26, 70);
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.Size = new System.Drawing.Size(547, 29);
			this.TitleTextBox.TabIndex = 0;
			// 
			// TextLetterTextBox
			// 
			this.TextLetterTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TextLetterTextBox.Location = new System.Drawing.Point(26, 113);
			this.TextLetterTextBox.Multiline = true;
			this.TextLetterTextBox.Name = "TextLetterTextBox";
			this.TextLetterTextBox.Size = new System.Drawing.Size(547, 240);
			this.TextLetterTextBox.TabIndex = 1;
			// 
			// UserToDropDown
			// 
			this.UserToDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.UserToDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserToDropDown.FormattingEnabled = true;
			this.UserToDropDown.Location = new System.Drawing.Point(26, 30);
			this.UserToDropDown.Name = "UserToDropDown";
			this.UserToDropDown.Size = new System.Drawing.Size(547, 29);
			this.UserToDropDown.TabIndex = 2;
			// 
			// AttachButton
			// 
			this.AttachButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AttachButton.FlatAppearance.BorderSize = 0;
			this.AttachButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.AttachButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.AttachButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.AttachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AttachButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AttachButton.Location = new System.Drawing.Point(26, 392);
			this.AttachButton.Name = "AttachButton";
			this.AttachButton.Size = new System.Drawing.Size(114, 43);
			this.AttachButton.TabIndex = 3;
			this.AttachButton.Text = "Прикрепить";
			this.AttachButton.UseVisualStyleBackColor = true;
			// 
			// SendButton
			// 
			this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SendButton.FlatAppearance.BorderSize = 0;
			this.SendButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.SendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.SendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SendButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SendButton.Location = new System.Drawing.Point(497, 392);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(114, 43);
			this.SendButton.TabIndex = 4;
			this.SendButton.Text = "Отправить";
			this.SendButton.UseVisualStyleBackColor = true;
			// 
			// AttachesLabel
			// 
			this.AttachesLabel.AutoSize = true;
			this.AttachesLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AttachesLabel.Location = new System.Drawing.Point(157, 406);
			this.AttachesLabel.Name = "AttachesLabel";
			this.AttachesLabel.Size = new System.Drawing.Size(98, 17);
			this.AttachesLabel.TabIndex = 5;
			this.AttachesLabel.Text = "Прикрепляшки";
			// 
			// NewLetterControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.AttachesLabel);
			this.Controls.Add(this.SendButton);
			this.Controls.Add(this.AttachButton);
			this.Controls.Add(this.UserToDropDown);
			this.Controls.Add(this.TextLetterTextBox);
			this.Controls.Add(this.TitleTextBox);
			this.Name = "NewLetterControl";
			this.Size = new System.Drawing.Size(662, 464);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.TextBox TextLetterTextBox;
		private System.Windows.Forms.ComboBox UserToDropDown;
		private System.Windows.Forms.Button AttachButton;
		private System.Windows.Forms.Button SendButton;
		private System.Windows.Forms.Label AttachesLabel;
	}
}
