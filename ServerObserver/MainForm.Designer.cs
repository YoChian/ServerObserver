
namespace ServerObserver
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.连接信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.启用监控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.软件设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添加新监控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.MonitorTabs = new System.Windows.Forms.TabControl();
			this.LogTabPage = new System.Windows.Forms.TabPage();
			this.LogTextBox = new System.Windows.Forms.RichTextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.MonitorTabs.SuspendLayout();
			this.LogTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 设置ToolStripMenuItem
			// 
			this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接信息ToolStripMenuItem,
            this.启用监控ToolStripMenuItem,
            this.软件设置ToolStripMenuItem});
			this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
			this.设置ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.设置ToolStripMenuItem.Text = "设置";
			// 
			// 连接信息ToolStripMenuItem
			// 
			this.连接信息ToolStripMenuItem.Name = "连接信息ToolStripMenuItem";
			this.连接信息ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
			this.连接信息ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.连接信息ToolStripMenuItem.Text = "连接信息";
			this.连接信息ToolStripMenuItem.Click += new System.EventHandler(this.连接信息ToolStripMenuItem_Click);
			// 
			// 启用监控ToolStripMenuItem
			// 
			this.启用监控ToolStripMenuItem.CheckOnClick = true;
			this.启用监控ToolStripMenuItem.Name = "启用监控ToolStripMenuItem";
			this.启用监控ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.启用监控ToolStripMenuItem.Text = "启用监控";
			this.启用监控ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.启用监控ToolStripMenuItem_CheckedChanged);
			// 
			// 软件设置ToolStripMenuItem
			// 
			this.软件设置ToolStripMenuItem.Name = "软件设置ToolStripMenuItem";
			this.软件设置ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
			this.软件设置ToolStripMenuItem.Text = "软件设置";
			this.软件设置ToolStripMenuItem.Click += new System.EventHandler(this.软件设置ToolStripMenuItem_Click);
			// 
			// 窗口ToolStripMenuItem
			// 
			this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加新监控ToolStripMenuItem});
			this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
			this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.窗口ToolStripMenuItem.Text = "窗口";
			// 
			// 添加新监控ToolStripMenuItem
			// 
			this.添加新监控ToolStripMenuItem.Name = "添加新监控ToolStripMenuItem";
			this.添加新监控ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.添加新监控ToolStripMenuItem.Text = "添加新监控";
			this.添加新监控ToolStripMenuItem.Click += new System.EventHandler(this.添加新监控ToolStripMenuItem_Click);
			// 
			// 帮助ToolStripMenuItem
			// 
			this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem1});
			this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
			this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.帮助ToolStripMenuItem.Text = "帮助";
			// 
			// 查看帮助ToolStripMenuItem
			// 
			this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
			this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.查看帮助ToolStripMenuItem.Text = "查看帮助";
			// 
			// 关于ToolStripMenuItem1
			// 
			this.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
			this.关于ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
			this.关于ToolStripMenuItem1.Text = "关于";
			this.关于ToolStripMenuItem1.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
			// 
			// MonitorTabs
			// 
			this.MonitorTabs.Controls.Add(this.LogTabPage);
			this.MonitorTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MonitorTabs.Location = new System.Drawing.Point(0, 25);
			this.MonitorTabs.Name = "MonitorTabs";
			this.MonitorTabs.SelectedIndex = 0;
			this.MonitorTabs.Size = new System.Drawing.Size(800, 425);
			this.MonitorTabs.TabIndex = 1;
			// 
			// LogTabPage
			// 
			this.LogTabPage.Controls.Add(this.LogTextBox);
			this.LogTabPage.Location = new System.Drawing.Point(4, 22);
			this.LogTabPage.Name = "LogTabPage";
			this.LogTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.LogTabPage.Size = new System.Drawing.Size(792, 399);
			this.LogTabPage.TabIndex = 1;
			this.LogTabPage.Text = "日志";
			this.LogTabPage.UseVisualStyleBackColor = true;
			// 
			// LogTextBox
			// 
			this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LogTextBox.Location = new System.Drawing.Point(3, 3);
			this.LogTextBox.Margin = new System.Windows.Forms.Padding(0);
			this.LogTextBox.Name = "LogTextBox";
			this.LogTextBox.ReadOnly = true;
			this.LogTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.LogTextBox.Size = new System.Drawing.Size(786, 393);
			this.LogTextBox.TabIndex = 0;
			this.LogTextBox.Text = "";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.MonitorTabs);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "服务器监视器";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.MonitorTabs.ResumeLayout(false);
			this.LogTabPage.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添加新监控ToolStripMenuItem;
		private System.Windows.Forms.TabControl MonitorTabs;
		private System.Windows.Forms.TabPage LogTabPage;
		private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 启用监控ToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem 软件设置ToolStripMenuItem;
		private System.Windows.Forms.RichTextBox LogTextBox;
	}
}

