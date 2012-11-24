using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedAlertLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void but_Configuration_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("RedAlertConfig.exe");
        }

        private void But_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but_PlayRedAlert_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ra95.exe");
            Application.Exit();
        }

        private void but_PlayOnline_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cncnet.exe");
            Application.Exit();
        }

        private void but_OpenSkirmish_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ra95.exe", "-SKIRMISH");
            Application.Exit();
        }

        private void but_OpenLAN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ra95.exe", "-LAN");
            Application.Exit();
        }

        private void but_LaunchAntMissions_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ra95.exe", "-ANTMISSIONS");
            Application.Exit();
        }

        private void but_LaunchNewMissions_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ra95.exe", "-NEWMISSIONS");
            Application.Exit();
        }
    }
}
