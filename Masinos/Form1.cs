using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masinos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kainaNuo = Convert.ToInt32(comboBox4.Text);
            var kainaIki = Convert.ToInt32(comboBox5.Text);
            var galiaNuo = Convert.ToInt32(comboBox6.Text);
            var galiaIki = Convert.ToInt32(comboBox7.Text);
            var kebulas = (comboBox2.Text);


            Rezultatai forma = new Rezultatai(kainaNuo, kainaIki, galiaNuo, galiaIki, kebulas);
            forma.ShowDialog();

        }
    }
}
