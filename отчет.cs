using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба1
{

    public partial class Form1 : Form
    {
        public double Radius { get; set; }
        public double ConeHeight { get; set; }
        public double Density { get; set; }
        public bool CalculateVolume { get; set; }
        public bool CalculateMass { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iNputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 inputForm = new Form2(this);
            inputForm.ShowDialog();
        }

        private void workToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = "";

            if (CalculateVolume)
            {
                double volume = (1.0 / 3.0) * Math.PI * Math.Pow(Radius, 2) * Height;
                result += $"Volume: {volume:F2} cubic units\n";
            }

            if (CalculateMass)
            {
                double volume = (1.0 / 3.0) * Math.PI * Math.Pow(Radius, 2) * Height;
                double mass = volume * Density;
                result += $"Mass: {mass:F2} units\n";
            }

            if (string.IsNullOrEmpty(result))
            {
                result = "No calculation selected.";
            }

            MessageBox.Show(result, "Calculation Result");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
