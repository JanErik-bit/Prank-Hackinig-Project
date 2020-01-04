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
    public partial class Geldform : Form
    {
        private int nächsteZeile = 0;
        public Geldform()
        {
            InitializeComponent();
        }

        private void geldtimer_Tick(object sender, EventArgs e)
        {
            // text hinzufügen

            Random rnd = new Random();
            string[] lines = prank_hacking_project.Properties.Resources.Geld.Split('\n');
            textBox1.Text += lines[nächsteZeile] + Environment.NewLine;
            textBox1.Select(textBox1.Text.Length, 0);
            textBox1.ScrollToCaret();

            nächsteZeile = nächsteZeile + 1;

            if (nächsteZeile >= lines.Length)
            {
                geldtimer.Enabled = false;
            }
        } 

        public void timerStarten()
        {
            geldtimer.Enabled = true;
        }
    }
}
