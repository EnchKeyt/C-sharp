using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace TimerTick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dispatcherTimer_Tick;

            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

            timer.Tick += new EventHandler(Tik);
            timer.Interval = new TimeSpan(0, 2, 0);
            timer.Start();
            dt.Start();
        }
        public int minutes = 1;
        public int second = 49;
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            minutsText.Text = minutes.ToString();
            secondText.Text = second.ToString();
            second--;
            if (second == 0)
            {
                minutes--;
                second = 59;
                if (minutes == 0)
                {
                    MessageBox.Show("Время сеанса подходит к концу");
                }
            }



        }
        public void Tik(object sender, EventArgs e)
        {
          
        }
    }
    
}
