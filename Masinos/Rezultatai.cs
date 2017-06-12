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
    public partial class Rezultatai : Form
    {
        public int KainaNuo { get; private set; }
        public int KainaIki { get; private set; }
        public int GaliaNuo { get; private set; }
        public int GaliaIki { get; private set; }
        public string Kebulas { get; private set; }



        public Rezultatai(int kainaNuo, int kainaIki, int galiaNuo, int galiaIki, string kebulas)
        {
            InitializeComponent();
            KainaNuo = kainaNuo;
            KainaIki = kainaIki;
            GaliaNuo = galiaNuo;
            GaliaIki = galiaIki;
            Kebulas = kebulas;
        }

        private void Rezultatai_Load(object sender, EventArgs e)
        {
            Automobiliai masinos = new Automobiliai();
            
            List<Automobilis> atrinkti = new List<Automobilis>();
            foreach (var auto in masinos.AutomobiliaiSarasas)
            {
                if (KainaNuo <= auto.Biudžetas && KainaIki >= auto.Biudžetas && GaliaNuo <= auto.Galia 
                    && GaliaIki >= auto.Galia && Kebulas == auto.KėbuloTipas)
                {
                    atrinkti.Add(auto);
                }
            }
            dataGridView1.DataSource = atrinkti;

        }
    }
}
