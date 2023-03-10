using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreUretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sifreUzunlugu, sifreSayisi;
        bool buyukHarfVarMi, kucukHarfVarMi, rakamVarMi, ozelKrkVarMi;
        string sifre = string.Empty;
        Random rnd = new Random();
        StringBuilder sb=new StringBuilder();

        private void btnSifreUret_Click(object sender, EventArgs e)
        {
            buyukHarfVarMi=chkBuyukHarf.Checked;
            kucukHarfVarMi=chkKucukHarf.Checked;
            rakamVarMi=chkRakam.Checked;
            ozelKrkVarMi=chkOzelKarakter.Checked;
            lbSifre.Items.Clear();
            sb.Clear();

            sifreUzunlugu = (int)nudSifreUzunlugu.Value;
            sifreSayisi=(int)nudSifreSayisi.Value;

            if (!(buyukHarfVarMi || kucukHarfVarMi || ozelKrkVarMi || rakamVarMi))
            {
                MessageBox.Show("lütfen bir parametre seçin");
                return;
            }
            EkleBuyukHarf(buyukHarfVarMi);
            EkleKucukHarf(kucukHarfVarMi);
            EkleRakam(rakamVarMi);
            EkleOzelKrk(ozelKrkVarMi);
            SifreOlustur(sifreUzunlugu, sifreSayisi);

        }

        private void SifreOlustur(int sifreUzunlugu, int sifreSayisi)
        {
           string randomchar=sb.ToString();
            string sifre = string.Empty;
            int randomUzunluk = randomchar.Length;
            for (int i = 0; i < sifreSayisi; i++)
            {
                sb.Clear();
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    sb.Append(randomchar[rnd.Next(0, randomUzunluk)]);
                }
                sifre=sb.ToString();
                lbSifre.Items.Add(sifre);
            }
        }

        private void EkleOzelKrk(bool ozelKrkVarMi)
        {
            if (ozelKrkVarMi)
            {
                for (char i = (char)33; i < 48; i++)
                {
                    sb.Append(i);
                }
                for (char i = (char)58; i < 65; i++)
                {
                    sb.Append(i);
                }
            }
        }

        private void EkleRakam(bool rakamVarMi)
        {
            if (rakamVarMi)
            {
                for (char i = (char)48; i <58 ; i++)
                {
                    sb.Append(i);
                }
            }
        }

        private void EkleKucukHarf(bool kucukHarfVarMi)
        {

            if (kucukHarfVarMi)
            {
                for (char i = (char)97; i < 123; i++)
                {
                    sb.Append(i);
                }
            }
        }

        private void EkleBuyukHarf(bool buyukHarfVarMi)
        {
            if (buyukHarfVarMi)
            {
                for (char i = (char)65; i < 91; i++)
                {
                    sb.Append(i);
                }
            }
        }
    }
}
