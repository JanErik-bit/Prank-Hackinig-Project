using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prank_hacking_project
{
    public partial class MainForm : Form
    {
        private bool skullZu = false;

        private ZahlenForm zahlenFenster = new ZahlenForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            int noch_uebrig = progressBar.Maximum - progressBar.Value;
            int was_dazukommt = noch_uebrig / 500;

            // check ob progress bar schon voll ist, sonst gibt es einen Fehler
            if (progressBar.Value == progressBar.Maximum)
            {
                // timer ausmachen und funktion beenden
                progressTimer.Enabled = false;
                return;
            }
            
            // progress Bar balken weiter füllen
            progressBar.Value = progressBar.Value + was_dazukommt;

            

            // progressbar status text
            double progress_anteil = (double) progressBar.Value / (double) progressBar.Maximum;
            if (progress_anteil > 0.9)
            {
                progresslabel.Text = "steam libary cleared";
            }
            else if (progress_anteil > 0.7)
            {
                progresslabel.Text = "sending game keys to albanien servers";
            }
            else if (progress_anteil > 0.4)
            {
                progresslabel.Text = "unlocking game keys";
            }
            else if (progress_anteil > 0.1)
            {
                if (!zahlenFenster.Enabled)
                {
                    zahlenFenster.Enabled = true;
                    zahlenFenster.Show();
                }
            }
            else
            {
                progresslabel.Text = "searching for passwords";
            }

            // schliessen, wenn voll
            if (progress_anteil >= 0.99)
            {
                Close();
            }
        }

        /**
         * Timer tick um das skull Bild zu Ändern
         */
        private void skulltimer_Tick(object sender, EventArgs e)
        {
            if (skullZu == true)
            {
                pictureBox1.BackgroundImage = prank_hacking_project.Properties.Resources.blue_skull_zu;
                skullZu = false;
            }
            else
            {
                pictureBox1.BackgroundImage = prank_hacking_project.Properties.Resources.blue_skull;
                skullZu = true;
            }
            pictureBox1.Refresh();
        }
    }
}
