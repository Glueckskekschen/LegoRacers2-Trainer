using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LegoRacers2_Trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        Memory mem;
        Thread writeThread;

        private void bn_Start_Click(object sender, EventArgs e)
        {
            //mem = new Memory("CalculatorApp");
            mem = new Memory("lego racers 2");
            label_status.Text = "Ready";
            writeThread = new Thread(new ThreadStart(writeValues));
            writeThread.Start();           

        }

        private void trackBar_Cars_Scroll(object sender, EventArgs e)
        {
            label_Cars.Text = "Cars " + trackBar_Cars.Value.ToString();            
        }

        private void bn_Stop_Click(object sender, EventArgs e)
        {
            bn_Stop.Enabled = false;
        }

        private void checkBox_Cars_CheckedChanged(object sender, EventArgs e)
        {

        }

        private static void writeValues()
        {
            Memory lul = new Memory("lego racers 2");
            while (true)
            {
                lul.WriteInt((int)lul.GetProcessBase() + 0x15C4FC, trackBar_Cars.Value);
                Thread.Sleep(1);    
            }
            
        }
    }
}
