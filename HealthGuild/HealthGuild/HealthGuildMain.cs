using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthGuild
{
    public partial class HealthGuildMain : Form
    {
        public HealthGuildMain()
        {
            InitializeComponent();
        }

        private void ctlFileSubmissionTracker_Click(object sender, EventArgs e)
        {
            var form = new FileSubmissionTrackerView();
            form.Show();
            //Testing GitHub
            //Testing GitHub 2
        }
    }
}
