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
            Application.Exit();

        }

        private void ChallengeMode_Click(object sender, EventArgs e)
        {

            PXCMSession session = null;
            session = PXCMSession.CreateInstance();
            if (session != null)
            {
                // Optional steps to send feedback to Intel Corporation to understand how often each SDK sample is used.
                PXCMMetadata md = session.QueryInstance<PXCMMetadata>();
                if (md != null)
                {
                    string sample_name = "Hands Viewer CS";
                    md.AttachBuffer(1297303632, System.Text.Encoding.Unicode.GetBytes(sample_name));
                }
               
                MainForm form = new MainForm(session);
                form.Show();
               
            }
           

        }
    }
}
