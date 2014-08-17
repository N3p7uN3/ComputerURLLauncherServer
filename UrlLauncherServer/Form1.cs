using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UrlLauncherServer
{
    public partial class Form1 : Form
    {
        private UrlLauncherServer mServer;
        
        public Form1()
        {
            InitializeComponent();
            mServer = new UrlLauncherServer(txtCmd.Text);
            mServer.Start();
        }

        private void txtCmd_TextChanged(object sender, EventArgs e)
        {
            mServer.UpdateCmdStr(txtCmd.Text);
        }
    }
}
