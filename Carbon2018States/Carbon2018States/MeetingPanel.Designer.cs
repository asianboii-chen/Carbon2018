﻿namespace DontDeleteThisStefan
{
	partial class MeetingPanel
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.NameLabel = new System.Windows.Forms.Label();
			this.ParentGroupNameLabel = new System.Windows.Forms.Label();
			this.DescriptionSampleTextBox = new System.Windows.Forms.TextBox();
			this.EditButton = new System.Windows.Forms.Button();
			this.NameSampleTextBox = new System.Windows.Forms.TextBox();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameLabel.ForeColor = System.Drawing.Color.White;
			this.NameLabel.Location = new System.Drawing.Point(22, 38);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(572, 28);
			this.NameLabel.TabIndex = 0;
			this.NameLabel.Text = "Meeting!";
			// 
			// ParentGroupNameLabel
			// 
			this.ParentGroupNameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ParentGroupNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ParentGroupNameLabel.Location = new System.Drawing.Point(26, 71);
			this.ParentGroupNameLabel.Name = "ParentGroupNameLabel";
			this.ParentGroupNameLabel.Size = new System.Drawing.Size(600, 16);
			this.ParentGroupNameLabel.TabIndex = 1;
			this.ParentGroupNameLabel.Text = "In Group";
			// 
			// DescriptionSampleTextBox
			// 
			this.DescriptionSampleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
			this.DescriptionSampleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DescriptionSampleTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DescriptionSampleTextBox.ForeColor = System.Drawing.Color.LightGray;
			this.DescriptionSampleTextBox.Location = new System.Drawing.Point(28, 115);
			this.DescriptionSampleTextBox.Multiline = true;
			this.DescriptionSampleTextBox.Name = "DescriptionSampleTextBox";
			this.DescriptionSampleTextBox.Size = new System.Drawing.Size(597, 97);
			this.DescriptionSampleTextBox.TabIndex = 2;
			this.DescriptionSampleTextBox.Text = "bluh bluh bluh";
			// 
			// EditButton
			// 
			this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(81)))));
			this.EditButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.EditButton.FlatAppearance.BorderSize = 0;
			this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EditButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditButton.ForeColor = System.Drawing.Color.White;
			this.EditButton.Location = new System.Drawing.Point(561, 626);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(80, 30);
			this.EditButton.TabIndex = 5;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = false;
			this.EditButton.Click += new System.EventHandler(this.OnEditButtonClick);
			// 
			// NameSampleTextBox
			// 
			this.NameSampleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
			this.NameSampleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NameSampleTextBox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameSampleTextBox.ForeColor = System.Drawing.Color.White;
			this.NameSampleTextBox.Location = new System.Drawing.Point(29, 34);
			this.NameSampleTextBox.Name = "NameSampleTextBox";
			this.NameSampleTextBox.Size = new System.Drawing.Size(596, 37);
			this.NameSampleTextBox.TabIndex = 0;
			// 
			// DeleteButton
			// 
			this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(22)))), ((int)(((byte)(41)))));
			this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.DeleteButton.FlatAppearance.BorderSize = 0;
			this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButton.ForeColor = System.Drawing.Color.White;
			this.DeleteButton.Location = new System.Drawing.Point(16, 626);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(80, 30);
			this.DeleteButton.TabIndex = 6;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = false;
			this.DeleteButton.Click += new System.EventHandler(this.OnDeleteButtonClick);
			// 
			// MeetingPanel
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(32)))), ((int)(((byte)(51)))));
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.DescriptionSampleTextBox);
			this.Controls.Add(this.ParentGroupNameLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.NameSampleTextBox);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "MeetingPanel";
			this.Size = new System.Drawing.Size(655, 670);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label ParentGroupNameLabel;
		private System.Windows.Forms.TextBox DescriptionSampleTextBox;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.TextBox NameSampleTextBox;
		private System.Windows.Forms.Button DeleteButton;
	}
}
