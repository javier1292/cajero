using CajeroAutomatico.esp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class RetiroEfectivo : Form
    {
        public RetiroEfectivo()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainFrame frame = new MainFrame();
            frame.Show();
            this.Hide();

        }

        private void button2000_Click(object sender, EventArgs e)
        {
            withdraw(2000);
        }

        private void button1000_Click(object sender, EventArgs e)
        {
            withdraw(1000);

            
        }

        private void button500_Click(object sender, EventArgs e)
        {
            withdraw(500);
        }

        private void button300_Click(object sender, EventArgs e)
        {
            withdraw(300);
        }

        private void button100_Click(object sender, EventArgs e)
        {
            withdraw(100);
        }

        public void withdraw(int amount)
        {
            Datos datos = new Datos();
            string path = @"..\..\Datos.json";
            string json = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(json))
            {
                JsonConvert.PopulateObject(json, datos);
            }
            if (datos.Monto - amount < 0)
            {
                FaltanFondos faltan = new FaltanFondos();
                faltan.Show();
                this.Hide();
            }
            else
            {
                datos.Monto -= amount;
                datos.amountB = amount;
                using (StreamWriter file = File.CreateText(path))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, datos);
                }
                cantidadbilletes cb  = new cantidadbilletes();
                cb.Show();
                this.Hide();
            }
        }

        private void buttonOtro_Click(object sender, EventArgs e)
        {
            Retirootro Rotro = new Retirootro();
            Rotro.Show();
            this.Hide();
        }
    }
}
