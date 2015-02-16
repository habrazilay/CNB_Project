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
        private const int DEFAULT_MIN_FLOOR = -3;
        private const int DEFAULT_MAX_FLOOR = 25;
        private const int DEFAULT_MIN_YEAR = 1990;
        private const int DEFAULT_MAX_YEAR = 2050;
        private const int NUMBER_OF_PANELS = 5;
        private const string LAST_SCREEN = "analogWatchPanel";

        public CNBForm()
        {
            InitializeComponent();
            nextBtn.Text = "Start";
            List<Panel> panelsList = new List<Panel>() { welcomePanel, timeQuestiosPanel, locationPanel };
            currentPanel = panelsList.GetEnumerator();
            currentPanel.MoveNext();


            for (int year = DEFAULT_MIN_YEAR; year <= DEFAULT_MAX_YEAR; year++)
            {
                yearBox.Items.Add(year.ToString());
            }

            for (int day = 1; day <= 31; day++)
            {
                dayBox.Items.Add(day.ToString());
            }

            for (int floor = DEFAULT_MIN_FLOOR; floor <= DEFAULT_MAX_FLOOR; floor++)
            {
                floorBox.Items.Add(floor.ToString());
            }
        }


        private void nextBtn_Click(object sender, EventArgs e)
        {
            nextBtn.Text = "Next";
            //currentPanel.Current.Visible = false;
            /*if (currentPanel.MoveNext())
            {
                currentPanel.Current.Visible = true;
            }
            if (currentPanel.Current.Name == LAST_SCREEN)
            {
                nextBtn.Text = "Finish";
            }*/
            
            if (timeQuestiosPanel.Visible == true)
            {
                timeQuestiosPanel.Visible = false;
                locationPanel.Visible = true;
            }
             if (welcomeLabel.Visible == true)
            {
                welcomeLabel.Visible = false;
                timeQuestiosPanel.Visible = true;
            } 
        }

    }
}
