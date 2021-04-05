using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TencentCloud;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Monitor.V20180724;
using TencentCloud.Monitor.V20180724.Models;

namespace ServerObserverAPI
{
    class TencentCloudMonitorClass
	{
        public static void GetMonitorData(string SecretID,string SecretKey,string Region,string Metric,string InstanceID)
        {

            try
            {
                Credential cred = new Credential
                {
                    SecretId = SecretID,
                    SecretKey = SecretKey
                };

                ClientProfile clientProfile = new ClientProfile();
                HttpProfile httpProfile = new HttpProfile();
                httpProfile.Endpoint = ("monitor.tencentcloudapi.com");
                clientProfile.HttpProfile = httpProfile;

                MonitorClient client = new MonitorClient(cred, Region, clientProfile);
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
                Console.WriteLine(AbstractModel.ToJsonString(resp));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.Read();
        }
    }
}
