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
    public partial class Form1 : Form
    {
        public Form1()
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
        }
    }
}
