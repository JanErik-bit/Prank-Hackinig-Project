using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Collections;

namespace prank_hacking_project
{
    public partial class Datenform : Form
    {
        public Datenform()
        {
            InitializeComponent();
        }

        private void zahlTimer_Tick(object sender, EventArgs e)
        {
            // text hinzufügen
            string[] fileEntries = Directory.GetFiles(@"c:\Windows\System32", "*");
            Random rnd = new Random();
            textBox.Text += fileEntries[rnd.Next(0, fileEntries.Length)] + Environment.NewLine;
            textBox.Select(textBox.Text.Length, 0);
            textBox.ScrollToCaret();
        }
    }
}
