
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
            this.SecretIDLabel = new System.Windows.Forms.Label();
            this.SecretIDText = new System.Windows.Forms.TextBox();
            this.SecretKeyText = new System.Windows.Forms.TextBox();
            this.SecretKeyLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.APIGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // APIGroup
            // 
            this.APIGroup.Controls.Add(this.SaveButton);
            this.APIGroup.Controls.Add(this.SecretKeyLabel);
            this.APIGroup.Controls.Add(this.SecretKeyText);
            this.APIGroup.Controls.Add(this.SecretIDText);
            this.APIGroup.Controls.Add(this.SecretIDLabel);
            this.APIGroup.Location = new System.Drawing.Point(13, 13);
            this.APIGroup.Name = "APIGroup";
            this.APIGroup.Size = new System.Drawing.Size(384, 159);
            this.APIGroup.TabIndex = 0;
            this.APIGroup.TabStop = false;
            this.APIGroup.Text = "API密钥";
            // 
            // SecretIDLabel
            // 
            this.SecretIDLabel.AutoSize = true;
            this.SecretIDLabel.Location = new System.Drawing.Point(7, 21);
            this.SecretIDLabel.Name = "SecretIDLabel";
            this.SecretIDLabel.Size = new System.Drawing.Size(59, 12);
            this.SecretIDLabel.TabIndex = 0;
            this.SecretIDLabel.Text = "SecretID:";
            // 
            // SecretIDText
            // 
            this.SecretIDText.Location = new System.Drawing.Point(72, 18);
            this.SecretIDText.Name = "SecretIDText";
            this.SecretIDText.Size = new System.Drawing.Size(147, 21);
            this.SecretIDText.TabIndex = 1;
            // 
            // SecretKeyText
            // 
            this.SecretKeyText.Location = new System.Drawing.Point(72, 46);
            this.SecretKeyText.Name = "SecretKeyText";
            this.SecretKeyText.Size = new System.Drawing.Size(147, 21);
            this.SecretKeyText.TabIndex = 2;
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
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(303, 18);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 330);
            this.Controls.Add(this.APIGroup);
            this.Name = "ConnectionForm";
            this.Text = "连接信息";
            this.APIGroup.ResumeLayout(false);
            this.APIGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox APIGroup;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label SecretKeyLabel;
        private System.Windows.Forms.TextBox SecretKeyText;
        private System.Windows.Forms.TextBox SecretIDText;
        private System.Windows.Forms.Label SecretIDLabel;
    }
}