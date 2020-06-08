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
    public partial class TomeDinero : Form
    {
        public TomeDinero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
