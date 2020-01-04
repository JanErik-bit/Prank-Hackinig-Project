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
    public partial class TickerForm : Form
    {
        public TickerForm(string text)
        {
            InitializeComponent();
            // Text für das Fenster setzen
            textBox.Text = text;

            // zufälligen Startpunkt auswählen
            Random rnd = new Random();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(rnd.Next(0, 1600), rnd.Next(0, 1000));
        }

        private void GiraffeForm_Load(object sender, EventArgs e)
        {
        }

        private void durchlaufTimer_Tick(object sender, EventArgs e)
        {
            // ticker effekt durch durchscrollen mit jedem timer tick
            textBox.Select(textBox.SelectionStart + 5, 0);
        }
    }
}
