using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ServerObserver
{
    public partial class AboutForm : Form
    {

        const string linkadress = "https://github.com/YoChian/ServerObserver/issues";

        public AboutForm()
        {
            InitializeComponent();
            CInitialize();
        }

        private void CInitialize()
        {
            IssueLink.Text = linkadress;
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            object[] objectAttrs = executingAssembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            AssemblyCopyrightAttribute copyrightAttr = (AssemblyCopyrightAttribute)objectAttrs[0];
            InfoLabel.Text = "";
            InfoLabel.Text += "Copyright:" + copyrightAttr.Copyright + "\n";
            InfoLabel.Text += "Version:"+Assembly.GetExecutingAssembly().GetName().Version.ToString()+"\n";
        }

        private void IssueLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkadress);
        }
    }
}
