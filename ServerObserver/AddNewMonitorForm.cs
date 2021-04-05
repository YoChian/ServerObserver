using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using ServerObserverLibrary;

namespace ServerObserver
{
	public partial class AddNewMonitorForm : Form
	{
		string RegionDataPath;
		SOLMain.APIKey PrimaryKey;
		private SOLMain.APIKeySetDoc APIKeys = new SOLMain.APIKeySetDoc();
		private List<TencentCloud.Cvm.V20170312.Models.RegionInfo> RegionList=new List<TencentCloud.Cvm.V20170312.Models.RegionInfo>();
		private List<TencentCloud.Monitor.V20180724.Models.MetricSet> MetricList = new List<TencentCloud.Monitor.V20180724.Models.MetricSet>();
		private List<TencentCloud.Cvm.V20170312.Models.Instance> CvmInstanceList = new List<TencentCloud.Cvm.V20170312.Models.Instance>();
		private List<TencentCloud.Lighthouse.V20200324.Models.Instance> LighthouseInstanceList = new List<TencentCloud.Lighthouse.V20200324.Models.Instance>();
		private List<InstanceReference> Instances = new List<InstanceReference>();

		class InstanceReference
		{
			public string InstanceID;
			public string InstanceType;
			public int InstanceListIndex;
		}

		public AddNewMonitorForm()
		{
			InitializeComponent();
			CInitialize();
			UpdateAPIKeyInfo();
			RegionInfoRead();
		}

		private void UpdateAPIKeyInfo()
		{
			foreach (SOLMain.APIKeySet i in APIKeys.APIKeySets)
			{
				SecretIDBox.Items.Add(i.APIKey.SecretID);
			}
		}

		private void CInitialize()
		{
			APIKeys = SOLMain.GetFullAPIKeySet();
			PrimaryKey = SOLMain.GetPrimaryAPIKey();
			RegionDataPath = SOLMain.GetConfigPath(SOLMain.ConfigType.Region);
		}

		private void UpdateRegionBox()
		{
			RegionBox.Items.Clear();
			foreach (TencentCloud.Cvm.V20170312.Models.RegionInfo regi in RegionList)
			{
				RegionBox.Items.Add(regi.RegionName);
			}
		}

		private void UpdateMetricBox()
		{
			MetricBox.Items.Clear();
			foreach (TencentCloud.Monitor.V20180724.Models.MetricSet i in MetricList)
			{
				MetricBox.Items.Add(i.MetricName);
			}
		}

		private void UpdateInstanceIDBox()
		{
			Instances.Clear();
			InstanceIDBox.Items.Clear();
			
			if (CvmInstanceList.Count()!=0)
			{
				InstanceIDBox.Items.Add("=======Cvm======");
				Instances.Add(new InstanceReference() { InstanceType="Tag"});
				for (int i1 = 0; i1 < CvmInstanceList.Count; i1++)
				{
					TencentCloud.Cvm.V20170312.Models.Instance i = CvmInstanceList[i1];
					InstanceReference insref= new InstanceReference();
					insref.InstanceID = i.InstanceId;
					insref.InstanceType = "Cvm";
					insref.InstanceListIndex = i1;
					Instances.Add(insref);

					InstanceIDBox.Items.Add($"{i.InstanceId}({i.InstanceName})");
				}
			}

			if (LighthouseInstanceList.Count!=0)
			{
				InstanceIDBox.Items.Add("===LightHouse===");
				Instances.Add(new InstanceReference() { InstanceType = "Tag" });
				for (int i1 = 0; i1 < LighthouseInstanceList.Count; i1++)
				{
					TencentCloud.Lighthouse.V20200324.Models.Instance i = LighthouseInstanceList[i1];
					InstanceReference insref = new InstanceReference();
					insref.InstanceID = i.InstanceId;
					insref.InstanceType = "Lighthouse";
					insref.InstanceListIndex = i1;
					Instances.Add(insref);

					InstanceIDBox.Items.Add($"{i.InstanceId}({i.InstanceName})");
				}
			}
		}

		private void QueryRegion()
		{
			try
			{
				Credential cred = new Credential
				{
					SecretId = PrimaryKey.SecretID,
					SecretKey = PrimaryKey.SecretKey
				};

				ClientProfile clientProfile = new ClientProfile();
				HttpProfile httpProfile = new HttpProfile();
				httpProfile.Endpoint = ("cvm.tencentcloudapi.com");
				clientProfile.HttpProfile = httpProfile;

				TencentCloud.Cvm.V20170312.CvmClient client = new TencentCloud.Cvm.V20170312.CvmClient(cred, "", clientProfile);
				TencentCloud.Cvm.V20170312.Models.DescribeRegionsRequest req = new TencentCloud.Cvm.V20170312.Models.DescribeRegionsRequest();

				TencentCloud.Cvm.V20170312.Models.DescribeRegionsResponse resp = client.DescribeRegionsSync(req);
				RegionList.Clear();
				foreach (TencentCloud.Cvm.V20170312.Models.RegionInfo i in resp.RegionSet)
				{
					RegionList.Add(i);
				}
				RegionInfoWrite();
				UpdateRegionBox();
			}
			catch (Exception e)
			{
				SOLMain.WriteLogline(e.Message, SOLMain.LogLevel.Error);
			}
		}

		private void RegionInfoWrite()
		{
			try
			{
				StreamWriter writer = new StreamWriter(RegionDataPath);
				XmlSerializer xmlSerializer = new XmlSerializer(RegionList.GetType());
				xmlSerializer.Serialize(writer, RegionList);
				writer.Flush();
				writer.Close();
			}
			catch (Exception e)
			{
				SOLMain.WriteLogline("写入地区XML时抛出异常：" + e.Message, SOLMain.LogLevel.Error);
				throw e;
			}
		}

		private void RegionInfoRead()
		{
			while (true)
			{
				if (Directory.Exists(Path.GetDirectoryName(RegionDataPath)))
				{
					if (File.Exists(RegionDataPath))
					{
						try
						{
							StreamReader reader = new StreamReader(RegionDataPath);
							XmlSerializer xmlSerializer = new XmlSerializer(RegionList.GetType());
							RegionList = (List<TencentCloud.Cvm.V20170312.Models.RegionInfo>)xmlSerializer.Deserialize(reader);
							reader.Close();
							UpdateRegionBox();
							break;
						}
						catch (Exception e)
						{
							SOLMain.WriteLogline("读取地区XML时抛出异常：" + e.Message, SOLMain.LogLevel.Error);
							throw e;
						}
						
					}
					else
					{
						SOLMain.WriteLogline("未找到地区配置文件");
						QueryRegion();
					}
				}
				else
				{
					SOLMain.WriteLogline("配置文件目录未建立，开始建立目录");
					Directory.CreateDirectory(Path.GetDirectoryName(RegionDataPath));
				}
			}
		}

		private void QueryMetric()
		{
			try
			{
				Credential cred = new Credential
				{
					SecretId = PrimaryKey.SecretID,
					SecretKey = PrimaryKey.SecretKey
				};

				ClientProfile clientProfile = new ClientProfile();
				HttpProfile httpProfile = new HttpProfile();
				httpProfile.Endpoint = ("monitor.tencentcloudapi.com");
				clientProfile.HttpProfile = httpProfile;

				TencentCloud.Monitor.V20180724.MonitorClient client = new TencentCloud.Monitor.V20180724.MonitorClient(cred, RegionList[RegionBox.SelectedIndex].Region, clientProfile);
				TencentCloud.Monitor.V20180724.Models.DescribeBaseMetricsRequest req = new TencentCloud.Monitor.V20180724.Models.DescribeBaseMetricsRequest();
				req.Namespace = "QCE/CVM";

				TencentCloud.Monitor.V20180724.Models.DescribeBaseMetricsResponse resp = client.DescribeBaseMetricsSync(req);

				foreach (TencentCloud.Monitor.V20180724.Models.MetricSet i in resp.MetricSet)
				{
					MetricList.Add(i);
				}
				UpdateMetricBox();
			}
			catch (Exception e)
			{
				SOLMain.WriteLogline("查询指标时抛出异常："+e.Message, SOLMain.LogLevel.Error);
				throw e;
			}
		}

		private void QueryInstanceCvm()
		{
			try
			{
				Credential cred = new Credential
				{
					SecretId = SecretIDBox.Text,
					SecretKey = SecretKeyBox.Text
				};

				ClientProfile clientProfile = new ClientProfile();
				HttpProfile httpProfile = new HttpProfile();
				httpProfile.Endpoint = ("cvm.tencentcloudapi.com");
				clientProfile.HttpProfile = httpProfile;

				TencentCloud.Cvm.V20170312.CvmClient client = new TencentCloud.Cvm.V20170312.CvmClient(cred, RegionList[RegionBox.SelectedIndex].Region, clientProfile);
				TencentCloud.Cvm.V20170312.Models.DescribeInstancesRequest req = new TencentCloud.Cvm.V20170312.Models.DescribeInstancesRequest();

				TencentCloud.Cvm.V20170312.Models.DescribeInstancesResponse resp = client.DescribeInstancesSync(req);

				foreach (TencentCloud.Cvm.V20170312.Models.Instance i in resp.InstanceSet)
				{
					CvmInstanceList.Add(i);
				}
			}
			catch (Exception e)
			{
				SOLMain.WriteLogline("查询Cvm实例时抛出异常：" + e.Message, SOLMain.LogLevel.Error);
			}
		}

		private void QueryInstanceLighthouse()
		{
			try
			{
				Credential cred = new Credential
				{
					SecretId = SecretIDBox.Text,
					SecretKey = SecretKeyBox.Text
				};

				ClientProfile clientProfile = new ClientProfile();
				HttpProfile httpProfile = new HttpProfile();
				httpProfile.Endpoint = ("lighthouse.tencentcloudapi.com");
				clientProfile.HttpProfile = httpProfile;

				TencentCloud.Lighthouse.V20200324.LighthouseClient client = new TencentCloud.Lighthouse.V20200324.LighthouseClient(cred, RegionList[RegionBox.SelectedIndex].Region, clientProfile);
				TencentCloud.Lighthouse.V20200324.Models.DescribeInstancesRequest req = new TencentCloud.Lighthouse.V20200324.Models.DescribeInstancesRequest();

				TencentCloud.Lighthouse.V20200324.Models.DescribeInstancesResponse resp = client.DescribeInstancesSync(req);

				foreach (TencentCloud.Lighthouse.V20200324.Models.Instance i in resp.InstanceSet)
				{
					LighthouseInstanceList.Add(i);
				}
			}
			catch (Exception e)
			{
				SOLMain.WriteLogline("查询Lighthouse实例时抛出异常：" + e.Message, SOLMain.LogLevel.Error);
			}
		}

		private void SubmitButton_Click(object sender, EventArgs e)
		{
			string insID = Instances[InstanceIDBox.SelectedIndex].InstanceID;
			SOLMain.APIKey key = new SOLMain.APIKey();
			key.SecretID = SecretIDBox.Text;
			key.SecretKey = SecretKeyBox.Text;
			SOLMain.CreateNewMonitor(insID, RegionList[RegionBox.SelectedIndex].Region, MetricBox.Text,key);
		}

		private void RegionUpdateButton_Click(object sender, EventArgs e)
		{
			QueryRegion();
		}

		private void InstanceButton_Click(object sender, EventArgs e)
		{
			QueryInstanceCvm();
			QueryInstanceLighthouse();
			UpdateInstanceIDBox();
		}

		private void RegionBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			QueryMetric();
		}

		private void SecretIDBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (SecretIDBox.SelectedIndex>-1)
			{
				SecretKeyBox.Text = APIKeys.APIKeySets[SecretIDBox.SelectedIndex].APIKey.SecretKey;
			}
		}

		private void MetricButton_Click(object sender, EventArgs e)
		{
			QueryMetric();
		}
	}
}
