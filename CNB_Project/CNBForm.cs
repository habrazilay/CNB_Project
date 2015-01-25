using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNB_Project
{
    public partial class CNBForm : Form
    {
        public IEnumerator<Panel> currentPanel { get; set; }
        public CNBForm()
        {
            InitializeComponent();
            nextBtn.Visible = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            welcomeLabel.Visible = false;
            startBtn.Visible = false;
            timeQuestiosPanel.Visible = true;
            nextBtn.Visible = true;
        }

    }
}
