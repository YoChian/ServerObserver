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
        public AboutForm()
        {
            InitializeComponent();
            CInitialize();
        }

        private void CInitialize()
        {
            VersionContent.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        string linkadress = "http://forum.phaneix.com/";

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkadress);
        }
    }
}
