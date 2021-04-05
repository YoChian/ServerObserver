using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerObserverLibrary;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Monitor.V20180724;
using TencentCloud.Monitor.V20180724.Models;

namespace ServerObserver
{
	public partial class MonitorTab : UserControl
	{
        string InstanceID;
        string IRegion;
        string Metric;
        SOLMain.APIKey APIKey=new SOLMain.APIKey();
        Queue<MetricDataPoint> dataPoints = new Queue<MetricDataPoint>();

		class MetricDataPoint
		{
            public float? time;
            public float? value;
		}
        public MonitorTab(string instance, string region, string metric, SOLMain.APIKey key)
		{
			InitializeComponent();
            InstanceID = instance;
            IRegion = region;
            Metric = metric;
            APIKey.SecretID=key.SecretID;
            APIKey.SecretKey = key.SecretKey;
			CInitialize();
		}

		private void CInitialize()
		{
            //SOLMain.UpdateMonitorEvent += new SOLMain.UpdateMonitorDelegate(MonitorTick);
            timer1.Enabled = true;
		}

		private void MonitorTick()
		{
            GetData();
            MonitorChart.Series[0].Points.Clear();
			foreach (MetricDataPoint i in dataPoints)
			{
                MonitorChart.Series[0].Points.AddXY(i.time, i.value);
			}
		}

        private void GetData()
        {
            try
            {
                Credential cred = new Credential
                {
                    SecretId = APIKey.SecretID,
                    SecretKey = APIKey.SecretKey
                };

                ClientProfile clientProfile = new ClientProfile();
                HttpProfile httpProfile = new HttpProfile();
                httpProfile.Endpoint = ("monitor.tencentcloudapi.com");
                clientProfile.HttpProfile = httpProfile;

                MonitorClient client = new MonitorClient(cred, IRegion, clientProfile);
                GetMonitorDataRequest req = new GetMonitorDataRequest();
                req.Namespace = "QCE/CVM";
                req.MetricName = Metric;
                Instance instance1 = new Instance();
                Dimension dimension1 = new Dimension();
                dimension1.Name = "InstanceId";
                dimension1.Value = InstanceID;
                instance1.Dimensions = new Dimension[] { dimension1 };

                req.Instances = new Instance[] { instance1 };

                GetMonitorDataResponse resp = client.GetMonitorDataSync(req);

                dataPoints.Clear();
				for (int i1 = 0; i1 < resp.DataPoints[0].Timestamps.Length; i1++)
				{
                    MetricDataPoint i = new MetricDataPoint() { time = resp.DataPoints[0].Timestamps[i1], value = resp.DataPoints[0].Values[i1] };
					dataPoints.Enqueue(i);
					if (dataPoints.Count>10)
					{
                        dataPoints.Dequeue();
					}
				}
            }
            catch (Exception e)
            {
                SOLMain.WriteLogline("获取数据失败：" + e.Message, SOLMain.LogLevel.Error);
            }
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
            MonitorTick();
		}
	}
}
