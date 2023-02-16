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
        public void start()
        {
            loop("start");
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
        public Int64 counter = 0;

        public void showValueOfCounter()
        { 
            this.label1.Text = counter.ToString();
        }

        public void loop(string x)
        {
            while ( x!="stop" || x != "pause" )
            {
                if (run == true)
                {
                    counter += 1;
                    showValueOfCounter();
                    this.Refresh();
                }
                else
                {
                    break;
                }
            };
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
    }
}
