
namespace ServerObserver
{
    partial class ConnectionForm
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
			this.APIGroup = new System.Windows.Forms.GroupBox();
			this.PrimaryKeyLabel = new System.Windows.Forms.Label();
			this.PrimaryKeyText = new System.Windows.Forms.TextBox();
			this.PrimaryKeyButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.SecretIDText = new System.Windows.Forms.ComboBox();
			this.InfoLabel = new System.Windows.Forms.Label();
			this.CautionInfo = new System.Windows.Forms.Label();
			this.CreateButton = new System.Windows.Forms.Button();
			this.SecretKeyLabel = new System.Windows.Forms.Label();
			this.SecretKeyText = new System.Windows.Forms.TextBox();
			this.SecretIDLabel = new System.Windows.Forms.Label();
			this.APIGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// APIGroup
			// 
			this.APIGroup.Controls.Add(this.PrimaryKeyLabel);
			this.APIGroup.Controls.Add(this.PrimaryKeyText);
			this.APIGroup.Controls.Add(this.PrimaryKeyButton);
			this.APIGroup.Controls.Add(this.DeleteButton);
			this.APIGroup.Controls.Add(this.EditButton);
			this.APIGroup.Controls.Add(this.SecretIDText);
			this.APIGroup.Controls.Add(this.InfoLabel);
			this.APIGroup.Controls.Add(this.CautionInfo);
			this.APIGroup.Controls.Add(this.CreateButton);
			this.APIGroup.Controls.Add(this.SecretKeyLabel);
			this.APIGroup.Controls.Add(this.SecretKeyText);
			this.APIGroup.Controls.Add(this.SecretIDLabel);
			this.APIGroup.Location = new System.Drawing.Point(13, 13);
			this.APIGroup.Name = "APIGroup";
			this.APIGroup.Size = new System.Drawing.Size(420, 159);
			this.APIGroup.TabIndex = 0;
			this.APIGroup.TabStop = false;
			this.APIGroup.Text = "API密钥";
			// 
			// PrimaryKeyLabel
			// 
			this.PrimaryKeyLabel.AutoSize = true;
			this.PrimaryKeyLabel.Location = new System.Drawing.Point(25, 77);
			this.PrimaryKeyLabel.Name = "PrimaryKeyLabel";
			this.PrimaryKeyLabel.Size = new System.Drawing.Size(47, 12);
			this.PrimaryKeyLabel.TabIndex = 14;
			this.PrimaryKeyLabel.Text = "主密钥:";
			// 
			// PrimaryKeyText
			// 
			this.PrimaryKeyText.Location = new System.Drawing.Point(78, 74);
			this.PrimaryKeyText.Name = "PrimaryKeyText";
			this.PrimaryKeyText.ReadOnly = true;
			this.PrimaryKeyText.Size = new System.Drawing.Size(147, 21);
			this.PrimaryKeyText.TabIndex = 13;
			// 
			// PrimaryKeyButton
			// 
			this.PrimaryKeyButton.Location = new System.Drawing.Point(231, 15);
			this.PrimaryKeyButton.Name = "PrimaryKeyButton";
			this.PrimaryKeyButton.Size = new System.Drawing.Size(75, 23);
			this.PrimaryKeyButton.TabIndex = 12;
			this.PrimaryKeyButton.Text = "设为主密钥";
			this.PrimaryKeyButton.UseVisualStyleBackColor = true;
			this.PrimaryKeyButton.Click += new System.EventHandler(this.PrimaryKeyButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(321, 73);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteButton.TabIndex = 11;
			this.DeleteButton.Text = "删除";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(321, 44);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(75, 23);
			this.EditButton.TabIndex = 10;
			this.EditButton.Text = "更新";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// SecretIDText
			// 
			this.SecretIDText.FormattingEnabled = true;
			this.SecretIDText.Location = new System.Drawing.Point(78, 18);
			this.SecretIDText.Name = "SecretIDText";
			this.SecretIDText.Size = new System.Drawing.Size(147, 20);
			this.SecretIDText.TabIndex = 7;
			this.SecretIDText.TextChanged += new System.EventHandler(this.SecretIDText_TextChanged);
			// 
			// InfoLabel
			// 
			this.InfoLabel.AutoSize = true;
			this.InfoLabel.Location = new System.Drawing.Point(7, 106);
			this.InfoLabel.Name = "InfoLabel";
			this.InfoLabel.Size = new System.Drawing.Size(275, 24);
			this.InfoLabel.TabIndex = 6;
			this.InfoLabel.Text = "主密钥将被用于不指定特定API密钥专有信息的查询\r\n如：腾讯云的服务器地区列表查询等";
			// 
			// CautionInfo
			// 
			this.CautionInfo.AutoSize = true;
			this.CautionInfo.ForeColor = System.Drawing.Color.Red;
			this.CautionInfo.Location = new System.Drawing.Point(7, 130);
			this.CautionInfo.Name = "CautionInfo";
			this.CautionInfo.Size = new System.Drawing.Size(365, 12);
			this.CautionInfo.TabIndex = 5;
			this.CautionInfo.Text = "请注意：本应用采用明文XML方式存储API密钥，请自行衡量使用风险";
			// 
			// CreateButton
			// 
			this.CreateButton.Location = new System.Drawing.Point(321, 15);
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.Size = new System.Drawing.Size(75, 23);
			this.CreateButton.TabIndex = 4;
			this.CreateButton.Text = "新建";
			this.CreateButton.UseVisualStyleBackColor = true;
			this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// SecretKeyLabel
			// 
			this.SecretKeyLabel.AutoSize = true;
			this.SecretKeyLabel.Location = new System.Drawing.Point(7, 49);
			this.SecretKeyLabel.Name = "SecretKeyLabel";
			this.SecretKeyLabel.Size = new System.Drawing.Size(65, 12);
			this.SecretKeyLabel.TabIndex = 3;
			this.SecretKeyLabel.Text = "SecretKey:";
			// 
			// SecretKeyText
			// 
			this.SecretKeyText.Location = new System.Drawing.Point(78, 46);
			this.SecretKeyText.Name = "SecretKeyText";
			this.SecretKeyText.Size = new System.Drawing.Size(147, 21);
			this.SecretKeyText.TabIndex = 2;
			// 
			// SecretIDLabel
			// 
			this.SecretIDLabel.AutoSize = true;
			this.SecretIDLabel.Location = new System.Drawing.Point(13, 21);
			this.SecretIDLabel.Name = "SecretIDLabel";
			this.SecretIDLabel.Size = new System.Drawing.Size(59, 12);
			this.SecretIDLabel.TabIndex = 0;
			this.SecretIDLabel.Text = "SecretID:";
			// 
			// ConnectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 199);
			this.Controls.Add(this.APIGroup);
			this.Name = "ConnectionForm";
			this.Text = "连接信息";
			this.APIGroup.ResumeLayout(false);
			this.APIGroup.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox APIGroup;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label SecretKeyLabel;
        private System.Windows.Forms.TextBox SecretKeyText;
        private System.Windows.Forms.Label SecretIDLabel;
		private System.Windows.Forms.Label CautionInfo;
		private System.Windows.Forms.Label InfoLabel;
		private System.Windows.Forms.ComboBox SecretIDText;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Label PrimaryKeyLabel;
		private System.Windows.Forms.TextBox PrimaryKeyText;
		private System.Windows.Forms.Button PrimaryKeyButton;
		private System.Windows.Forms.Button DeleteButton;
	}
}