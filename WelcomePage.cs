using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hands_viewer.cs
{
    public partial class WelcomePage : Form
    {

        public PXCMSession g_session;

        public WelcomePage()
        {
            InitializeComponent();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            // MainForm form = new MainForm(g_session);
            Application.Exit();

        }
    }
}
