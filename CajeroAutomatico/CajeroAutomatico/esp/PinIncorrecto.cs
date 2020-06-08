using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.esp
{
    public partial class PinIncorrecto : Form
    {
        int timeLeft;
        Timer timer;
        public PinIncorrecto()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 700;
            timer.Start();

            timeLeft = 2;
            timer.Tick += Timer_Tick;

            timer.Start();
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;

            if (timeLeft <= 0)
            {
                timer.Stop();
                Start frame = new Start();
                frame.Show();
                this.Hide();

            }
        }
    }
}
