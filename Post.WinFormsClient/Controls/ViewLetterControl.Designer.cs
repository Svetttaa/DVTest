namespace Post.WinFormsClient.Controls
{
	partial class ViewLetterControl
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
			this.TitleLabel = new System.Windows.Forms.Label();
			this.UserFromLabel = new System.Windows.Forms.Label();
			this.AnswerButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.AttachesLabel = new System.Windows.Forms.Label();
			this.AttachesPictureBox = new System.Windows.Forms.PictureBox();
			this.DateLabel = new System.Windows.Forms.Label();
			this.TextLetterTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.AttachesPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// TitleLabel
			// 
			this.TitleLabel.BackColor = System.Drawing.Color.White;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleLabel.Location = new System.Drawing.Point(18, 38);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(389, 27);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Title";
			// 
			// UserFromLabel
			// 
			this.UserFromLabel.BackColor = System.Drawing.Color.White;
			this.UserFromLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserFromLabel.Location = new System.Drawing.Point(18, 0);
			this.UserFromLabel.Name = "UserFromLabel";
			this.UserFromLabel.Size = new System.Drawing.Size(389, 27);
			this.UserFromLabel.TabIndex = 1;
			this.UserFromLabel.Text = "От";
			// 
			// AnswerButton
			// 
			this.AnswerButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AnswerButton.Location = new System.Drawing.Point(397, 301);
			this.AnswerButton.Name = "AnswerButton";
			this.AnswerButton.Size = new System.Drawing.Size(100, 37);
			this.AnswerButton.TabIndex = 3;
			this.AnswerButton.Text = "Ответить";
			this.AnswerButton.UseVisualStyleBackColor = true;
			this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DeleteButton.Location = new System.Drawing.Point(275, 301);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(100, 37);
			this.DeleteButton.TabIndex = 4;
			this.DeleteButton.Text = "Удалить";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// AttachesLabel
			// 
			this.AttachesLabel.AutoSize = true;
			this.AttachesLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AttachesLabel.Location = new System.Drawing.Point(52, 301);
			this.AttachesLabel.Name = "AttachesLabel";
			this.AttachesLabel.Size = new System.Drawing.Size(115, 20);
			this.AttachesLabel.TabIndex = 6;
			this.AttachesLabel.Text = "Прикрепляшки";
			this.AttachesLabel.Visible = false;
			// 
			// AttachesPictureBox
			// 
			this.AttachesPictureBox.Image = global::Post.WinFormsClient.Properties.Resources.attach;
			this.AttachesPictureBox.InitialImage = global::Post.WinFormsClient.Properties.Resources.attach;
			this.AttachesPictureBox.Location = new System.Drawing.Point(23, 289);
			this.AttachesPictureBox.Name = "AttachesPictureBox";
			this.AttachesPictureBox.Size = new System.Drawing.Size(33, 32);
			this.AttachesPictureBox.TabIndex = 7;
			this.AttachesPictureBox.TabStop = false;
			// 
			// DateLabel
			// 
			this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DateLabel.Location = new System.Drawing.Point(413, 6);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(92, 54);
			this.DateLabel.TabIndex = 8;
			this.DateLabel.Text = "Дата";
			// 
			// TextLetterTextBox
			// 
			this.TextLetterTextBox.Location = new System.Drawing.Point(16, 83);
			this.TextLetterTextBox.Multiline = true;
			this.TextLetterTextBox.Name = "TextLetterTextBox";
			this.TextLetterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextLetterTextBox.Size = new System.Drawing.Size(480, 206);
			this.TextLetterTextBox.TabIndex = 9;
			// 
			// ViewLetterControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TextLetterTextBox);
			this.Controls.Add(this.DateLabel);
			this.Controls.Add(this.AttachesPictureBox);
			this.Controls.Add(this.AttachesLabel);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.AnswerButton);
			this.Controls.Add(this.UserFromLabel);
			this.Controls.Add(this.TitleLabel);
			this.Name = "ViewLetterControl";
			this.Size = new System.Drawing.Size(508, 341);
			((System.ComponentModel.ISupportInitialize)(this.AttachesPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label UserFromLabel;
		private System.Windows.Forms.Button AnswerButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Label AttachesLabel;
		private System.Windows.Forms.PictureBox AttachesPictureBox;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.TextBox TextLetterTextBox;
	}
}
