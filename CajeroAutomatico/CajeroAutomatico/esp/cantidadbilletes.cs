using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace CajeroAutomatico.esp
{
    public partial class cantidadbilletes : Form 
    {
        public cantidadbilletes()
        {
            InitializeComponent();
        }

        private void cantidadbilletes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            string path = @"..\..\Datos.json";
            string json = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(json))
            {
                JsonConvert.PopulateObject(json, datos);
            }

            int C1000 = 0;
            int C500 = 0;
            int C100 = 0;

            int Retiro = datos.amountB;

            if (Retiro >= 1000) {
                C1000 = (Retiro) / 1000;
                Retiro = Retiro - (C1000 * 1000);
            }
            if (Retiro >= 500) {
                C500 = Retiro / 500;
                Retiro = Retiro - (C500 * 500);
            }
            if (Retiro >= 100) {
                C100 = Retiro / 100;
                Retiro = Retiro - (C100 * 100);
            }
            MessageBox.Show("Cantidad de de billetes de 1000: "+C1000+
                "\n Cantidad de billetes de 500: " + C500+
                "\n Cantidad de billetes de 100: " + C100);
            TomeDinero t = new TomeDinero();
            t.Show();
            this.Hide();
        }


        public void muchosbilletes() 
        {
            Datos data = new Datos();
            //data.amountB es la cantidad retirada del cajero para fines de calculo del billete

        
        }

        private void pocosbilletes()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            string path = @"..\..\Datos.json";
            string json = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(json))
            {
                JsonConvert.PopulateObject(json, datos);
            }
          
            int C500 = 0;
            int C100 = 0;

            int Retiro = datos.amountB;
   
            if (Retiro >= 1000)
            {
                C500 = Retiro / 500;
                Retiro = Retiro - (C500 * 500);
            }
            if (Retiro >= 100)
            {
                C100 = Retiro / 100;
                Retiro = Retiro - (C100 * 100);
            }
            MessageBox.Show(
                "Cantidad de billetes de 500: " + C500 +
                "\n Cantidad de billetes de 100: " + C100);
            TomeDinero t = new TomeDinero();
            t.Show();
            this.Hide();
        }
    }
}
