using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace CajeroAutomatico.esp
{
    public partial class entrar : Form
    {
        public entrar()
        {
            InitializeComponent();
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

            if (textBox1.Text == datos.Pin)
            {
                MainFrame m = new MainFrame();
                m.Show();
                this.Hide();
            }
            else {
                PinIncorrecto p = new PinIncorrecto();
                p.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
