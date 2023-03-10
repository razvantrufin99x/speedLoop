using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace speedLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool run = false;
        public Int64 initialcounter = 0;
        public Int64 currentcounter = 0;
        public Int64 counter = 0;

        public void start()
        {
            loop("start");
            currentcounter = counter;
            run = true;
        }
        public void stop()
        {
            loop("stop");
            run = false;
        }
        public void pause()
        {
            loop("pause");
            run = false;
        }


        public void showValueOfCounter()
        { 
            this.label1.Text = counter.ToString();
        }

        public void loop(string x)
        {
            if (x == "start") { timer1.Enabled=true; }
            else if (x == "pause") {  timer1.Enabled = false;  }
            else if (x == "stop") { timer1.Enabled = false;  }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stop();
        }
        
        public void calculateFrequence()
        {
            Int64 diff = this.currentcounter - initialcounter;
            Int64 diffCC = this.counter - diff;
            label2.Text = diff.ToString();
            label3.Text = diffCC.ToString(); 
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (run == true)
            {
                counter += 1;
                showValueOfCounter();
                calculateFrequence();
                this.Refresh();
            }
            else
            {
                run = false;
                
            }
        }
    }
}
