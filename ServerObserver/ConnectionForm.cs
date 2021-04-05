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
    public partial class ConnectionForm : Form
    {
        string APIKeyPath;
        SOLMain.APIKeySetDoc FullAPIKeySet=new SOLMain.APIKeySetDoc();

        public ConnectionForm()
        {
            InitializeComponent();
            CInitialize();
            SecretIDTextUpdate();
        }

		private void CInitialize()
		{
            FullAPIKeySet = SOLMain.GetFullAPIKeySet();
            APIKeyPath = SOLMain.GetConfigPath(SOLMain.ConfigType.APIKey);
            SelectionChanged();
        }

		private void SecretIDTextUpdate()
		{
            SecretIDText.Items.Clear();
			foreach (SOLMain.APIKeySet i in FullAPIKeySet.APIKeySets)
			{
                SecretIDText.Items.Add(i.APIKey.SecretID);
			}
		}

		private void XmlInfoWirte()
		{
            try
            {
                StreamWriter writer = new StreamWriter(APIKeyPath);
                XmlSerializer xmlSerializer = new XmlSerializer(FullAPIKeySet.GetType());
                xmlSerializer.Serialize(writer, FullAPIKeySet);
                writer.Flush();
                writer.Close();
            }
            catch (Exception e)
            {
                SOLMain.WriteLogline("写入地区XML时抛出异常：" + e.Message, SOLMain.LogLevel.Error);
                throw e;
            }
        }

		private void CreateButton_Click(object sender, EventArgs e)
		{
            SOLMain.APIKeySet newAPIKey = new SOLMain.APIKeySet();
            newAPIKey.APIKey = new SOLMain.APIKey();
            newAPIKey.APIKey.SecretID = SecretIDText.Text;
            newAPIKey.APIKey.SecretKey = SecretKeyText.Text;
            FullAPIKeySet.APIKeySets.Add(newAPIKey);
            XmlInfoWirte();
            SecretIDTextUpdate();
        }

		private void EditButton_Click(object sender, EventArgs e)
		{
            FullAPIKeySet.APIKeySets[SecretIDText.SelectedIndex].APIKey.SecretID = SecretIDText.SelectedItem.ToString();
            FullAPIKeySet.APIKeySets[SecretIDText.SelectedIndex].APIKey.SecretKey = SecretKeyText.Text;
            XmlInfoWirte();
            SecretIDTextUpdate();
        }

		private void DeleteButton_Click(object sender, EventArgs e)
		{
            FullAPIKeySet.APIKeySets.RemoveAt(SecretIDText.SelectedIndex);
            XmlInfoWirte();
            SecretIDTextUpdate();
        }

        private void SelectionChanged()
		{
            if (SecretIDText.SelectedIndex == -1)
            {
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
                SecretKeyText.Text = "";
                PrimaryKeyText.Text = "";
            }
            else
            {
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
                SecretKeyText.Text = FullAPIKeySet.APIKeySets[SecretIDText.SelectedIndex].APIKey.SecretKey;
                if (SecretIDText.Text == FullAPIKeySet.PrimaryKey.SecretID)
                    PrimaryKeyText.Text = "是";
                else
                    PrimaryKeyText.Text = "否";
            }
        }

        private void SecretIDText_TextChanged(object sender, EventArgs e)
        {
            SelectionChanged();
        }

        private void PrimaryKeyButton_Click(object sender, EventArgs e)
		{
            FullAPIKeySet.PrimaryKey.SecretID = SecretIDText.Text;
            FullAPIKeySet.PrimaryKey.SecretKey = SecretKeyText.Text;
            XmlInfoWirte();
            SecretIDTextUpdate();
            SOLMain.UpdateSecretKey(FullAPIKeySet.PrimaryKey.SecretID, FullAPIKeySet.PrimaryKey.SecretKey);
        }
	}
}
