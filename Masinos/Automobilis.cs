using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masinos
{
    class Automobilis
    {
        public int Biudžetas { get; private set; }
        public int Galia { get; private set; }
        public string KilmėsŠalis { get; private set; }
        public string KėbuloTipas { get; private set; }
        public string VarantiejiRatai { get; private set; }
        public string Markė { get; private set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }

        public Automobilis()
        {

        }

        public Automobilis(int biudzetas, int galia, string kilmesSalis, string kebuloTipas,
            string varantiejiRatai, string marke, string modelis, int metai)
        {
            Biudžetas = biudzetas;
            Galia = galia;
            KilmėsŠalis = kilmesSalis;
            KėbuloTipas = kebuloTipas;
            VarantiejiRatai = varantiejiRatai;
            Markė = marke;
            Modelis = modelis;
            Metai = metai;

        }
    }
}
