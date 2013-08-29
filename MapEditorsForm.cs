using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RedAlertLauncher
{
    public partial class MapEditorsForm : Form
    {
        public MapEditorsForm()
        {
            InitializeComponent();
        }

        private void but_close_Click(object sender, EventArgs e)
        {

        }

        private void but_RAED_Click(object sender, EventArgs e)
        {
            Form1.Start_Application("raed.exe", "");
            Application.Exit();
        }

        private void but_edwin_Click(object sender, EventArgs e)
        {
            Form1.Start_Application("edwin.exe", "");
            Application.Exit();
        }

        private void but_RAED_DesertWinter_Click(object sender, EventArgs e)
        {
            Form1.Start_Application("raed_desert_winter.exe", "");
            Application.Exit();
        }
    }
}
