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
            label3.Text = round.ToString();

        }
        int second = 60;
        int minute=24;
       


        private void TICK_WORK(object sender, EventArgs e)
        {
           // percentage = (60-second)*1.66;
           // label4.Text = percentage.ToString();
            //percentage = (percentage/60)*100;
            //label4.Text = percentage.ToString();
            circularProgressBar1.Value = 60-second;

            tick_rest.Enabled = false;
            second--;
            High.Text = "Time to WORK";
            if (second==00)                                         //SECOND TO CHANGE MINUTE
            {
                minute--;
                second = 60;                                             //TIMER
            }
            sec.Text = second.ToString();
            min.Text = minute.ToString();
            if(minute==0)                                          //CHANGE WORK MODE TO BREAK TIME        //25 MIn
            { 
                second = 60;
            minute = 4;
            tick_rest.Enabled = true;                               //GO TO REST MODE
            }
        }

        private void tickrest(object sender, EventArgs e)
        {
            tick_wk.Enabled = false;
            second--;
            High.Text = "Time to Take Break";

            circularProgressBar1.Value = 60 - second;









            if (second == 00)                                       //SECOMD TO CHNAGE MINUTE
            {
                minute--;
                second = 60;
            }
            sec.Text = second.ToString();
            min.Text = minute.ToString();
            if (minute == 0)                                            //4MINUTE BREAK TIME
            {
                minute = 25;
                tick_wk.Enabled = true;
                label3.Text=round++.ToString();
            }
        }

        int round = 0;

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

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {

            tick_wk.Enabled = true;
            
            
        }
    }
}
