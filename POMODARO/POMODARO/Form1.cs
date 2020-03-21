using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POMODARO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sec_Click(object sender, EventArgs e)
        {

        }

        private void Min_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // circularProgressBar1.Value = minute;

        }
        int second = 0;
        int minute=0;
      
       

        private void TICK_WORK(object sender, EventArgs e)
        {
            tick_rest.Enabled = false;
            second++;
            High.Text = "Time to Take WORK";
            if (second==61)                                         //SECOND TO CHANGE MINUTE
            {
                minute++;
                second = 0;                                             //TIMER
            }
            sec.Text = second.ToString();
            min.Text = minute.ToString();
            if(minute==25)                                          //CHANGE WORK MODE TO BREAK TIME        //25 MIn
            { 
                second = 0;
            minute = 0;
            tick_rest.Enabled = true;                               //GO TO REST MODE
            }
        }

        private void tickrest(object sender, EventArgs e)
        {
            tick_wk.Enabled = false;
            second++;
            High.Text = "Time to Take Break";
            
            if (second == 61)                                       //SECOMD TO CHNAGE MINUTE
            {
                minute++;
                second = 0;
            }
            sec.Text = second.ToString();
            min.Text = minute.ToString();
            if (minute == 4)                                            //4MINUTE BREAK TIME
            {
                minute = 0;
                tick_wk.Enabled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            tick_wk.Enabled = true;
            minute++;
            circularProgressBar1.Value = minute;
        }

        private void High_Click(object sender, EventArgs e)
        {

        }

        

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROGRAM BY DHANANJAY SENDAY");
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
