using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5Pool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Pump pump in pumpTable.Controls)
            {
                pump.Click += (object sender, EventArgs e) => pump1_Click(pump, e);
            }

            filingPump.Mode = true;
        }

        private void pump1_Click(Pump pump, EventArgs e)
        {
            pump.Activation(progressBar1);
        }

        private void pump1_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentPower.Text = trackBar1.Value.ToString();
            filingPump.powerPump = trackBar1.Value;
        }

        private void filingPump_Load(object sender, EventArgs e)
        {
            filingPump.Activation(progressBar1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
