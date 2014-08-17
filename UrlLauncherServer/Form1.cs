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
        private StartupManager mStartup;
        
        public Form1()
        {
            InitializeComponent();
            mServer = new UrlLauncherServer();
            mServer.UpdateCmdStr(txtCmd.Text, txtArguments.Text);
            mServer.Start();

            mStartup = new StartupManager();
            if (mStartup.isAlreadyStartup())
                chkStartup.Checked = true;
        }

        private void txtCmd_TextChanged(object sender, EventArgs e)
        {
            mServer.UpdateCmdStr(txtCmd.Text, txtArguments.Text);
        }

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartup.Checked)
                mStartup.addToStartup();
            else
                mStartup.removeFromStartup();

        }
    }
}
