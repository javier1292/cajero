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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            MainFrame frame = new MainFrame();
            frame.Show();
            this.Hide();
        }

        private void Balance_Load(object sender, EventArgs e)
        {

        }
    }
}
