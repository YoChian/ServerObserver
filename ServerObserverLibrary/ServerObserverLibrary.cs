using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TencentCloud;
using TencentCloud.Cvm.V20170312.Models;

namespace ServerObserverLibrary
{
    public class SOLMain
    {
		public enum LogLevel
		{
			Info = 0, Notice = 100, Warning = 200, Error = 300
		}
        public delegate void WriteLoglineDelegate(string Logline,LogLevel LogLevel);
        public static event WriteLoglineDelegate WriteLoglineEvent;
		/// <summary>
		/// 在程序日志中写入一行日志
		/// </summary>
		/// <param name="Logline">日志行内容</param>
		/// <param name="LogLevel">描述日志行的等级，0->Information,100->Notice,200->Warning,300->Error 在软件设置中设置日志等级可以限制日志中显示的日志类型</param>
		public static void WriteLogline(string Logline, LogLevel LogLevel = LogLevel.Info) => WriteLoglineEvent(Logline, LogLevel);

		public delegate void UpdateSecretKeyDelegate(string SID, string SKey);
        public static event UpdateSecretKeyDelegate UpdateSecretKeyEvent;
		/// <summary>
		/// 更新主密钥信息
		/// </summary>
		/// <param name="SID">SecretID</param>
		/// <param name="SKey">SecretKey</param>
		public static void UpdateSecretKey(string SID, string SKey) => UpdateSecretKeyEvent(SID, SKey);

		public class InstanceSet
		{
			RegionInfo Region;
			string InstanceID;
		}

		public class APIKey
		{
			public string SecretID;
			public string SecretKey;
		}
        public class APIKeySet
		{
			public APIKey APIKey;
			public List<InstanceSet> Instances;
		}
		public class APIKeySetDoc
		{
			public APIKey PrimaryKey;
			public List<APIKeySet> APIKeySets;
		}
		public delegate APIKey GetPrimaryAPIKeyDelegate();
		public static event GetPrimaryAPIKeyDelegate GetPrimaryAPIKeyEvent;
        public static APIKey GetPrimaryAPIKey()
		{
			return GetPrimaryAPIKeyEvent();
		}

		public delegate APIKeySetDoc GetFullAPIKeySetDelegate();
		public static event GetFullAPIKeySetDelegate GetFullAPIKeySetEvent;
		public static APIKeySetDoc GetFullAPIKeySet()
		{
			return GetFullAPIKeySetEvent();
		}

		public enum ConfigType
		{
			APIKey, Region, Metric
		}
		public delegate string GetConfigPathDelegate(ConfigType configType);
		public static event GetConfigPathDelegate GetConfigPathEvent;
		public static string GetConfigPath(ConfigType configType)
		{
			return GetConfigPathEvent(configType);
		}

		public void XMLWrite<T>(string XMLPath,ref T XMLobj)
		{
			StreamWriter writer;
			XmlSerializer xmlSerializer;
			try
			{
				writer = new StreamWriter(XMLPath);
				xmlSerializer = new XmlSerializer(XMLobj.GetType());
				try
				{
					xmlSerializer.Serialize(writer, XMLobj);
					writer.Flush();
					writer.Close();
				}
				catch (Exception e)
				{
					writer.Close();
					WriteLogline("写入XML时抛出异常：" + e.Message, LogLevel.Error);
					throw e;
				}
			}
			catch (Exception e)
			{
				WriteLogline("创建XMLWriter时抛出异常：" + e.Message, LogLevel.Error);
				throw e;
			}
		}

		public int XMLRead<T>(string XMLPath, ref T XMLobj)
		{
			Start:
			if (Directory.Exists(Path.GetDirectoryName(XMLPath)))
			{
				if (File.Exists(XMLPath))
				{
					StreamReader reader;
					XmlSerializer xmlSerializer;
					try
					{
						reader = new StreamReader(XMLPath);
						xmlSerializer = new XmlSerializer(XMLobj.GetType());
						try
						{
							XMLobj = (T)xmlSerializer.Deserialize(reader);
							reader.Close();
							return 0;
						}
						catch (Exception e)
						{
							reader.Close();
							WriteLogline("读取XML时抛出异常：" + e.Message, LogLevel.Error);
							throw e;
						}
					}
					catch (Exception e)
					{
						WriteLogline("创建XMLReader时抛出异常：" + e.Message, LogLevel.Error);
						throw e;
					}
				}
				else
				{
					WriteLogline("未找到配置文件");
					return -1;
				}
			}
			else
			{
				WriteLogline("配置文件目录未建立，开始建立目录");
				try
				{
					Directory.CreateDirectory(Path.GetDirectoryName(XMLPath));
					goto Start;
				}
				catch (Exception e)
				{
					WriteLogline("建立目录失败：" + e.Message, LogLevel.Error);
					throw e;
				}
			}
		}

		public delegate void CreateNewMonitorDelegate(string instance, string region, string metric, APIKey key);
		public static event CreateNewMonitorDelegate CreateNewMonitorEvent;
		public static void CreateNewMonitor(string instance, string region, string metric, APIKey key)
		{
			CreateNewMonitorEvent(instance, region, metric, key);
		}

		public delegate void UpdateMonitorDelegate();
		public static event UpdateMonitorDelegate UpdateMonitorEvent;
		public static void UpdateMonitor()
		{
			UpdateMonitorEvent();
		}
	}
}
