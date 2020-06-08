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
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            Datos datos = new Datos();

            string path = @"..\..\Datos.json";
            string json = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(json))
            {
                JsonConvert.PopulateObject(json, datos);
            }
            balance.labelBlance.Text = datos.Monto.ToString("C");
            balance.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RetiroEfectivo retiro = new RetiroEfectivo();
            retiro.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            string path = @"..\..\Datos.json";
            string json = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(json))
            {
                JsonConvert.PopulateObject(json, datos);
            }
            if (datos.Monto - 1000 < 0)
            {
                FaltanFondos faltan = new FaltanFondos();
                faltan.Show();
                this.Hide();
            }
            else
            {
                datos.Monto -= 1000;
                datos.amountB = 1000;
                using (StreamWriter file = File.CreateText(path))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, datos);
                }
                cantidadbilletes cb = new cantidadbilletes();
                cb.Show();
                this.Hide();
            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
