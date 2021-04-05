
namespace ServerObserver
{
	partial class AddNewMonitorForm
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
			this.SecretIDBox = new System.Windows.Forms.ComboBox();
			this.RegionBox = new System.Windows.Forms.ComboBox();
			this.InstanceIDBox = new System.Windows.Forms.ComboBox();
			this.MetricBox = new System.Windows.Forms.ComboBox();
			this.SecretIDLabel = new System.Windows.Forms.Label();
			this.SecretKeyLabel = new System.Windows.Forms.Label();
			this.RegionLabel = new System.Windows.Forms.Label();
			this.MetricLabel = new System.Windows.Forms.Label();
			this.InstanceIDLabel = new System.Windows.Forms.Label();
			this.SubmitButton = new System.Windows.Forms.Button();
			this.RegionUpdateButton = new System.Windows.Forms.Button();
			this.InstanceButton = new System.Windows.Forms.Button();
			this.SecretKeyBox = new System.Windows.Forms.TextBox();
			this.SaveAPIKeyButton = new System.Windows.Forms.Button();
			this.MetricButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SecretIDBox
			// 
			this.SecretIDBox.FormattingEnabled = true;
			this.SecretIDBox.Location = new System.Drawing.Point(77, 12);
			this.SecretIDBox.Name = "SecretIDBox";
			this.SecretIDBox.Size = new System.Drawing.Size(121, 20);
			this.SecretIDBox.TabIndex = 0;
			this.SecretIDBox.SelectedIndexChanged += new System.EventHandler(this.SecretIDBox_SelectedIndexChanged);
			// 
			// RegionBox
			// 
			this.RegionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RegionBox.FormattingEnabled = true;
			this.RegionBox.Location = new System.Drawing.Point(77, 66);
			this.RegionBox.Name = "RegionBox";
			this.RegionBox.Size = new System.Drawing.Size(121, 20);
			this.RegionBox.TabIndex = 2;
			this.RegionBox.SelectedIndexChanged += new System.EventHandler(this.RegionBox_SelectedIndexChanged);
			// 
			// InstanceIDBox
			// 
			this.InstanceIDBox.FormattingEnabled = true;
			this.InstanceIDBox.Location = new System.Drawing.Point(77, 93);
			this.InstanceIDBox.Name = "InstanceIDBox";
			this.InstanceIDBox.Size = new System.Drawing.Size(121, 20);
			this.InstanceIDBox.TabIndex = 3;
			// 
			// MetricBox
			// 
			this.MetricBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MetricBox.FormattingEnabled = true;
			this.MetricBox.Location = new System.Drawing.Point(77, 120);
			this.MetricBox.Name = "MetricBox";
			this.MetricBox.Size = new System.Drawing.Size(121, 20);
			this.MetricBox.TabIndex = 4;
			// 
			// SecretIDLabel
			// 
			this.SecretIDLabel.AutoSize = true;
			this.SecretIDLabel.Location = new System.Drawing.Point(12, 15);
			this.SecretIDLabel.Name = "SecretIDLabel";
			this.SecretIDLabel.Size = new System.Drawing.Size(53, 12);
			this.SecretIDLabel.TabIndex = 5;
			this.SecretIDLabel.Text = "SecretID";
			// 
			// SecretKeyLabel
			// 
			this.SecretKeyLabel.AutoSize = true;
			this.SecretKeyLabel.Location = new System.Drawing.Point(12, 42);
			this.SecretKeyLabel.Name = "SecretKeyLabel";
			this.SecretKeyLabel.Size = new System.Drawing.Size(59, 12);
			this.SecretKeyLabel.TabIndex = 6;
			this.SecretKeyLabel.Text = "SecretKey";
			// 
			// RegionLabel
			// 
			this.RegionLabel.AutoSize = true;
			this.RegionLabel.Location = new System.Drawing.Point(12, 69);
			this.RegionLabel.Name = "RegionLabel";
			this.RegionLabel.Size = new System.Drawing.Size(29, 12);
			this.RegionLabel.TabIndex = 7;
			this.RegionLabel.Text = "地区";
			// 
			// MetricLabel
			// 
			this.MetricLabel.AutoSize = true;
			this.MetricLabel.Location = new System.Drawing.Point(12, 123);
			this.MetricLabel.Name = "MetricLabel";
			this.MetricLabel.Size = new System.Drawing.Size(53, 12);
			this.MetricLabel.TabIndex = 8;
			this.MetricLabel.Text = "监控指标";
			// 
			// InstanceIDLabel
			// 
			this.InstanceIDLabel.AutoSize = true;
			this.InstanceIDLabel.Location = new System.Drawing.Point(12, 96);
			this.InstanceIDLabel.Name = "InstanceIDLabel";
			this.InstanceIDLabel.Size = new System.Drawing.Size(41, 12);
			this.InstanceIDLabel.TabIndex = 9;
			this.InstanceIDLabel.Text = "实例ID";
			// 
			// SubmitButton
			// 
			this.SubmitButton.Location = new System.Drawing.Point(226, 37);
			this.SubmitButton.Name = "SubmitButton";
			this.SubmitButton.Size = new System.Drawing.Size(75, 23);
			this.SubmitButton.TabIndex = 10;
			this.SubmitButton.Text = "添加监控";
			this.SubmitButton.UseVisualStyleBackColor = true;
			this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
			// 
			// RegionUpdateButton
			// 
			this.RegionUpdateButton.Location = new System.Drawing.Point(226, 64);
			this.RegionUpdateButton.Name = "RegionUpdateButton";
			this.RegionUpdateButton.Size = new System.Drawing.Size(75, 23);
			this.RegionUpdateButton.TabIndex = 11;
			this.RegionUpdateButton.Text = "更新地区";
			this.RegionUpdateButton.UseVisualStyleBackColor = true;
			this.RegionUpdateButton.Click += new System.EventHandler(this.RegionUpdateButton_Click);
			// 
			// InstanceButton
			// 
			this.InstanceButton.Location = new System.Drawing.Point(226, 91);
			this.InstanceButton.Name = "InstanceButton";
			this.InstanceButton.Size = new System.Drawing.Size(75, 23);
			this.InstanceButton.TabIndex = 12;
			this.InstanceButton.Text = "查询实例";
			this.InstanceButton.UseVisualStyleBackColor = true;
			this.InstanceButton.Click += new System.EventHandler(this.InstanceButton_Click);
			// 
			// SecretKeyBox
			// 
			this.SecretKeyBox.Location = new System.Drawing.Point(77, 39);
			this.SecretKeyBox.Name = "SecretKeyBox";
			this.SecretKeyBox.Size = new System.Drawing.Size(121, 21);
			this.SecretKeyBox.TabIndex = 13;
			// 
			// SaveAPIKeyButton
			// 
			this.SaveAPIKeyButton.Location = new System.Drawing.Point(226, 10);
			this.SaveAPIKeyButton.Name = "SaveAPIKeyButton";
			this.SaveAPIKeyButton.Size = new System.Drawing.Size(75, 23);
			this.SaveAPIKeyButton.TabIndex = 14;
			this.SaveAPIKeyButton.Text = "保存密钥";
			this.SaveAPIKeyButton.UseVisualStyleBackColor = true;
			// 
			// MetricButton
			// 
			this.MetricButton.Location = new System.Drawing.Point(226, 118);
			this.MetricButton.Name = "MetricButton";
			this.MetricButton.Size = new System.Drawing.Size(75, 23);
			this.MetricButton.TabIndex = 15;
			this.MetricButton.Text = "更新指标";
			this.MetricButton.UseVisualStyleBackColor = true;
			this.MetricButton.Click += new System.EventHandler(this.MetricButton_Click);
			// 
			// AddNewMonitorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 275);
			this.Controls.Add(this.MetricButton);
			this.Controls.Add(this.SaveAPIKeyButton);
			this.Controls.Add(this.SecretKeyBox);
			this.Controls.Add(this.InstanceButton);
			this.Controls.Add(this.RegionUpdateButton);
			this.Controls.Add(this.SubmitButton);
			this.Controls.Add(this.InstanceIDLabel);
			this.Controls.Add(this.MetricLabel);
			this.Controls.Add(this.RegionLabel);
			this.Controls.Add(this.SecretKeyLabel);
			this.Controls.Add(this.SecretIDLabel);
			this.Controls.Add(this.MetricBox);
			this.Controls.Add(this.InstanceIDBox);
			this.Controls.Add(this.RegionBox);
			this.Controls.Add(this.SecretIDBox);
			this.Name = "AddNewMonitorForm";
			this.Text = "添加新监视";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox SecretIDBox;
		private System.Windows.Forms.ComboBox RegionBox;
		private System.Windows.Forms.ComboBox InstanceIDBox;
		private System.Windows.Forms.ComboBox MetricBox;
		private System.Windows.Forms.Label SecretIDLabel;
		private System.Windows.Forms.Label SecretKeyLabel;
		private System.Windows.Forms.Label RegionLabel;
		private System.Windows.Forms.Label MetricLabel;
		private System.Windows.Forms.Label InstanceIDLabel;
		private System.Windows.Forms.Button SubmitButton;
		private System.Windows.Forms.Button RegionUpdateButton;
		private System.Windows.Forms.Button InstanceButton;
		private System.Windows.Forms.TextBox SecretKeyBox;
		private System.Windows.Forms.Button SaveAPIKeyButton;
		private System.Windows.Forms.Button MetricButton;
	}
}