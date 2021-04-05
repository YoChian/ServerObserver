using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using ServerObserverLibrary;

namespace ServerObserver
{
    public partial class MainForm : Form
    {
		SOLMain.APIKeySetDoc APIKeyInfo;
		private readonly string APIKeyPath = Path.Combine(Application.StartupPath, "config\\ConnectionInfo.xml");
		private readonly string RegionDataPath = Path.Combine(Application.StartupPath, "config\\MonitorData.xml");
		private readonly string MetricDataPath = Path.Combine(Application.StartupPath, "config\\MetricData.xml");
		public MainForm()
        {
            InitializeComponent();
			CInitialize();
            AppConfigRead();
			SOLMain.WriteLogline("ServerObserver启动完成");
        }

		private void CInitialize()
		{
			APIKeyInfo = new SOLMain.APIKeySetDoc();
			APIKeyInfo.APIKeySets = new List<SOLMain.APIKeySet>();
			APIKeyInfo.PrimaryKey = new SOLMain.APIKey();
			SOLMain.WriteLoglineEvent += new SOLMain.WriteLoglineDelegate(WriteLog);
            SOLMain.UpdateSecretKeyEvent += new SOLMain.UpdateSecretKeyDelegate(UpdateSecretKey);
            SOLMain.GetPrimaryAPIKeyEvent += new SOLMain.GetPrimaryAPIKeyDelegate(GetPrimaryAPIKey);
			SOLMain.GetFullAPIKeySetEvent += new SOLMain.GetFullAPIKeySetDelegate(GetFullAPIKeySet);
			SOLMain.GetConfigPathEvent += new SOLMain.GetConfigPathDelegate(GetConfigPath);
			SOLMain.CreateNewMonitorEvent += new SOLMain.CreateNewMonitorDelegate(CreateNewMonitor);
		}

		private void CreateNewMonitor(string instance, string region, string metric, SOLMain.APIKey key)
		{
			MonitorTab tabcontrol = new MonitorTab(instance, region, metric, key);
			TabPage tabPage = new TabPage(instance);
			tabPage.Controls.Add(tabcontrol);
			MonitorTabs.TabPages.Add(tabPage);
		}

		private string GetConfigPath(SOLMain.ConfigType configType)
		{
			switch (configType)
			{
				case SOLMain.ConfigType.APIKey:
					return APIKeyPath;
				case SOLMain.ConfigType.Region:
					return RegionDataPath;
				case SOLMain.ConfigType.Metric:
					return MetricDataPath;
				default:
					return null;
			}
		}

		private SOLMain.APIKeySetDoc GetFullAPIKeySet()
		{
			return APIKeyInfo;
		}

		private SOLMain.APIKey GetPrimaryAPIKey()
		{
            return APIKeyInfo.PrimaryKey;
		}

		private void AppConfigRead()
        {
			while (true)
			{
                if (Directory.Exists(Path.GetDirectoryName(APIKeyPath)))
			    {
				    if (File.Exists(APIKeyPath))
				    {
						StreamReader reader;
						try
						{
							reader = new StreamReader(APIKeyPath);
							XmlSerializer xmlSerializer = new XmlSerializer(APIKeyInfo.GetType());
							try
							{
								APIKeyInfo = (SOLMain.APIKeySetDoc)xmlSerializer.Deserialize(reader);
								reader.Close();
								break;
							}
							catch (InvalidOperationException e)
							{
								reader.Close();
								SOLMain.WriteLogline(e.Message, SOLMain.LogLevel.Error);
								SOLMain.WriteLogline("密钥配置文件错误，重新生成密钥配置文件", SOLMain.LogLevel.Error);
								MessageBox.Show("请先填写用于访问腾讯云API的密钥", "未找到密钥配置文件", MessageBoxButtons.OK, MessageBoxIcon.Information);
								OpenConnectionForm();
							}
							
						}
						catch (Exception e)
						{
							SOLMain.WriteLogline("读取密钥XML时抛出异常：" + e.Message, SOLMain.LogLevel.Error);
							throw e;
						}
					}
				    else
				    {
                        SOLMain.WriteLogline("未找到密钥配置文件");
                        MessageBox.Show("请先填写用于访问腾讯云API的密钥，并设置主密钥", "未找到密钥配置文件", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OpenConnectionForm();
				    }
			    }
                else
			    {
                    SOLMain.WriteLogline("配置文件目录未建立，开始建立目录");
                    Directory.CreateDirectory(Path.GetDirectoryName(APIKeyPath));
                }
			}
        }
        
        private void WriteLog(string logline,SOLMain.LogLevel logLevel)
		{
			LogTextBox.Text = $"[{DateTime.Now}]{logline}\n{LogTextBox.Text}";
		}

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void 连接信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenConnectionForm();
        }

        private void OpenConnectionForm()
		{
            new ConnectionForm().ShowDialog();
		}

		private void UpdateSecretKey(string SID, string SKey)
		{
            APIKeyInfo.PrimaryKey.SecretID = SID;
			APIKeyInfo.PrimaryKey.SecretKey = SKey;
		}

		private void 添加新监控ToolStripMenuItem_Click(object sender, EventArgs e)
		{
            new AddNewMonitorForm().ShowDialog();
		}

		private void 启用监控ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
		{
            if (启用监控ToolStripMenuItem.Checked)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
		}

		private void 软件设置ToolStripMenuItem_Click(object sender, EventArgs e)
		{
            new AppSettingForm().ShowDialog();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			SOLMain.UpdateMonitor();
		}
	}
}
