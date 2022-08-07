using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LegoRacers2_Trainer
{
    public partial class Form1 : Form
    {
        Memory mem;
        bool timer_ProcessIsBusy = false;
        bool timer_WriteIsBusy = false;
        public Form1()
        {
            InitializeComponent();
            enableOrDisableAllCheckBoxes(false);
            mem = new Memory("lego racers 2");
            //mem = new Memory("CalculatorApp");
            timer_Process.Start();
            
        }        

        


        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isAcheckBoxChecked())
            {
                timer_Write.Start();
            }
            else
            {
                timer_Write.Stop();
            }
            
        }

        private bool isAcheckBoxChecked() //is at least one CheckBox Checked?
        {
            //Only two CheckBoxes
            foreach (Control c in Controls.OfType<CheckBox>())
            {
                if (((CheckBox)c).Checked == true)
                {
                    return true;
                }
            }

            //GroupBox
            if (checkBox_Special.Checked)
            {
                return true;
            }
            return false;
        }

        private void enableOrDisableAllCheckBoxes(bool b)
        {
            foreach (CheckBox c in Controls.OfType<CheckBox>())
            {
               c.Enabled = b;
            }
            //GroupBox Cars
            foreach (CheckBox c in groupBox_Cars.Controls.OfType<CheckBox>())
            {
                c.Enabled = b;
            }
        }

        private void uncheckAllCheckBoxes()
        {
            foreach (CheckBox c in Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }
            //GroupBox Cars
            foreach (CheckBox c in groupBox_Cars.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }
        }

        private void checkStartPositions() //No Start number is allowed twice -> Crash
        {
            int[] iStartNumbers = new int[8];
            int i = 0;
            foreach (NumericUpDown n in groupBox_Cars.Controls.OfType<NumericUpDown>())
            {
                iStartNumbers[i] = (int)n.Value;
                i++;
            }

            if (!iStartNumbers.All(new HashSet<int>().Add))
            {
                //Contains duplicates, set 1 - 8
                int x = 8;
                foreach (NumericUpDown nn in groupBox_Cars.Controls.OfType<NumericUpDown>())
                {
                    nn.Value = x;
                    x--;
                }
            }
        }

        private void timer_Process_Tick(object sender, EventArgs e)
        {
            if (!timer_ProcessIsBusy)
            {
                timer_ProcessIsBusy = true; //lock timer
                if (mem.AccessProcessOnce())
                {
                    label_status.ForeColor = Color.Green;
                    label_status.Text = "Ready";
                    enableOrDisableAllCheckBoxes(true);
                    timer_Process.Stop();
                }
                else
                {
                    label_status.ForeColor = Color.Red;
                    if (label_status.Text.Equals("Wait for the Game :)"))
                    {
                        label_status.Text = "Wait for the Game  :)";
                    }
                    else
                    {
                        label_status.Text = "Wait for the Game :)";
                    }
                }
                timer_ProcessIsBusy = false; //free timer
            }            
        }

        //Write the Values to the Memory
        private void timer_Write_Tick(object sender, EventArgs e)
        {
            if (!timer_WriteIsBusy)
            {
                try
                {
                    timer_WriteIsBusy = true; //lock timer
                    //Cars
                    int iBase = (int)mem.GetProcessBase();
                    if (checkBox_Cars.Checked)
                    {
                        mem.WriteInt(iBase + 0x15C4FC, trackBar_Cars.Value);
                    }

                    if (checkBox_Laps.Checked)
                    {
                        mem.WriteInt(iBase + 0x15C4F8, (int)numericUpDown_Laps.Value);
                    }
                    
                    if (checkBox_Special.Checked)
                    {
                        //Cars Special
                        foreach (TrackBar trackbar in groupBox_Cars.Controls.OfType<TrackBar>())
                        {
                            char lul = trackbar.Name[trackbar.Name.Length - 1]; //Get last index of name 
                            int iNumber = lul - '0'; //Char to int
                            mem.WriteInt(iBase + 0x15C538 + (0x344 * (iNumber-1)), trackbar.Value);
                        }

                        //Start Place
                        checkStartPositions();
                        foreach (NumericUpDown n in groupBox_Cars.Controls.OfType<NumericUpDown>())
                        {
                            char lul = n.Name[n.Name.Length -1];
                            int iNumber = lul - '0';
                            mem.WriteInt(iBase + 0x15C544 + (0x344 * (iNumber - 1)), (int)n.Value);
                        }
                    }
                }
                catch (Exception ex) //Game Closed or crashed
                {
                    uncheckAllCheckBoxes();
                    enableOrDisableAllCheckBoxes(false);
                    timer_Write.Stop();
                    timer_Process.Start();
                }
                finally
                {
                    timer_WriteIsBusy = false; //free timer
                }
            }
        }


        private void trackBar_Cars_Scroll(object sender, EventArgs e)
        {
            label_Cars.Text = "Cars " + trackBar_Cars.Value.ToString();
        }

        private void trackBar_Special_Scroll(object sender, EventArgs e)
        {
            string sText = "Normal";
            switch (((TrackBar)sender).Value)
            {
                case 1:
                    sText = "Normal";
                    break;
                case 2:
                    sText = "Riegel's mech";
                    break;
                case 3:
                    sText = "Chasing";
                    break;
                case 4:
                    sText = "The Berg";
                    break;
                case 5:
                    sText = "Oilslick";
                    break;
                default:
                    break;
            }
            string sNr = ((TrackBar)sender).Tag.ToString();
            foreach (Label label in groupBox_Cars.Controls.OfType<Label>())
            {
                if (label.Name.Contains("_Special_" + sNr))
                {
                    label.Text = sText;
                }
            }
        }
    }
}
