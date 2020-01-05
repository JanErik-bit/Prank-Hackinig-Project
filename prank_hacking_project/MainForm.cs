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

        private Geldform geldFenster = new Geldform();

        private List<Form> andereFenster = new List<Form>();

        private int geöffnete_datenfenster = 0;
        private Point[] datenFensterLocations = {
            new Point(50, 100),
            new Point(1200, 200),
            new Point(700, 10),
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            int noch_uebrig = progressBar.Maximum - progressBar.Value;
            int was_dazukommt = noch_uebrig / 330;

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
            // GeldFenster öffnen
            else if (progress_anteil > 0.3)
            {
                
                if (!geldFenster.Enabled)
                {
                    geldFenster.Enabled = true;
                    geldFenster.Show();
                    geldFenster.timerStarten();
                }
            }
            // DatenFenster öffnen
            else if (progress_anteil > 0.1)
            {
                if (geöffnete_datenfenster < datenFensterLocations.Length)
                {
                    // neues Datenfenster erstellen
                    Datenform datenFenster = new Datenform();

                    // anzeigen
                    datenFenster.Enabled = true;
                    datenFenster.Show();

                    // position setzen
                    datenFenster.Location = datenFensterLocations[geöffnete_datenfenster];

                    // zur Liste hinzufügen
                    andereFenster.Insert(0, datenFenster);

                    geöffnete_datenfenster++;
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

        private void giraffenTimer_Tick(object sender, EventArgs e)
        {
            // Giraffenfenster zeigen
            TickerForm giraffenFenster = new TickerForm(prank_hacking_project.Properties.Resources.giraffenWiki);
            andereFenster.Insert(0, giraffenFenster);

            giraffenFenster.Enabled = true;
            giraffenFenster.Show();

            // Timer deaktivieren, wenn genug Fenster geöffnet sind
            if (andereFenster.Count >= 6)
                giraffenTimer.Enabled = false;
        }
    }
}
