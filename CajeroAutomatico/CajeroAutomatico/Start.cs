using CajeroAutomatico.esp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button_Click(object sender, EventArgs e)
        {
            entrar login = new entrar();
            login.Show();
            this.Hide();
        }



        private void buttonConfig_Click(object sender, EventArgs e)
        {
            Config c = new Config();
            c.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
