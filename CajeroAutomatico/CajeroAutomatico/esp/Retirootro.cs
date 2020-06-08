using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico.esp
{
    public partial class Retirootro : Form
    {
        public Retirootro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RetiroEfectivo R = new RetiroEfectivo();
            if (txt_monto.Text != "") { 
                

            int MR = int.Parse(txt_monto.Text);
            int Valido = MR % 100;
            if (Valido == 0)
            {
                R.withdraw(MR);
                this.Hide();
            }
            else {
                MessageBox.Show("Monto no multiplo de 100");
            }

            }
            else
            {
                MessageBox.Show ("Usted no digito ningun monto  ");
            }
          
      
        }
    }
}
