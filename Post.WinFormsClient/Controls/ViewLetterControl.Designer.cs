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
			this.components = new System.ComponentModel.Container();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.UserFromLabel = new System.Windows.Forms.Label();
			this.AnswerButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.AttachesLabel = new System.Windows.Forms.Label();
			this.AttachesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DateLabel = new System.Windows.Forms.Label();
			this.TextLetterTextBox = new System.Windows.Forms.TextBox();
			this.SaveAttachDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// TitleLabel
			// 
			this.TitleLabel.BackColor = System.Drawing.Color.White;
			this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TitleLabel.Location = new System.Drawing.Point(18, 59);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(389, 27);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Title";
			// 
			// UserFromLabel
			// 
			this.UserFromLabel.BackColor = System.Drawing.Color.White;
			this.UserFromLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserFromLabel.Location = new System.Drawing.Point(18, 23);
			this.UserFromLabel.Name = "UserFromLabel";
			this.UserFromLabel.Size = new System.Drawing.Size(389, 27);
			this.UserFromLabel.TabIndex = 1;
			this.UserFromLabel.Text = "От";
			// 
			// AnswerButton
			// 
			this.AnswerButton.BackColor = System.Drawing.Color.White;
			this.AnswerButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AnswerButton.FlatAppearance.BorderSize = 0;
			this.AnswerButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.AnswerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.AnswerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.AnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AnswerButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AnswerButton.Location = new System.Drawing.Point(397, 318);
			this.AnswerButton.Name = "AnswerButton";
			this.AnswerButton.Size = new System.Drawing.Size(100, 37);
			this.AnswerButton.TabIndex = 3;
			this.AnswerButton.Text = "Ответить";
			this.AnswerButton.UseVisualStyleBackColor = false;
			this.AnswerButton.Click += new System.EventHandler(this.AnswerButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.BackColor = System.Drawing.Color.White;
			this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DeleteButton.FlatAppearance.BorderSize = 0;
			this.DeleteButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DeleteButton.Location = new System.Drawing.Point(275, 318);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(100, 37);
			this.DeleteButton.TabIndex = 4;
			this.DeleteButton.Text = "Удалить";
			this.DeleteButton.UseVisualStyleBackColor = false;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// AttachesLabel
			// 
			this.AttachesLabel.AutoSize = true;
			this.AttachesLabel.ContextMenuStrip = this.AttachesMenu;
			this.AttachesLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AttachesLabel.Location = new System.Drawing.Point(12, 318);
			this.AttachesLabel.Name = "AttachesLabel";
			this.AttachesLabel.Size = new System.Drawing.Size(77, 20);
			this.AttachesLabel.TabIndex = 6;
			this.AttachesLabel.Text = "Файлов: 0";
			this.AttachesLabel.Visible = false;
			// 
			// AttachesMenu
			// 
			this.AttachesMenu.Name = "AttachesMenu";
			this.AttachesMenu.Size = new System.Drawing.Size(61, 4);
			// 
			// DateLabel
			// 
			this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DateLabel.Location = new System.Drawing.Point(413, 23);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(92, 54);
			this.DateLabel.TabIndex = 8;
			this.DateLabel.Text = "Дата";
			// 
			// TextLetterTextBox
			// 
			this.TextLetterTextBox.Location = new System.Drawing.Point(16, 100);
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
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.TextLetterTextBox);
			this.Controls.Add(this.DateLabel);
			this.Controls.Add(this.AttachesLabel);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.AnswerButton);
			this.Controls.Add(this.UserFromLabel);
			this.Controls.Add(this.TitleLabel);
			this.Name = "ViewLetterControl";
			this.Size = new System.Drawing.Size(508, 361);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label UserFromLabel;
		private System.Windows.Forms.Button AnswerButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Label AttachesLabel;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.TextBox TextLetterTextBox;
		private System.Windows.Forms.ContextMenuStrip AttachesMenu;
		private System.Windows.Forms.SaveFileDialog SaveAttachDialog;
	}
}
