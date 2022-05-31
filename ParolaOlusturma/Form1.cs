using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace ParolaOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Stream pow = Properties.Resources.Mighty_Morphin_Power_Rangers_Full_Theme_Song;
            SoundPlayer cal = new SoundPlayer(pow);
            cal.Play();
        }
        char[] buyukHarf = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'V', 'Y', 'Z', 'W', 'Q', 'X' };
        char[] kucukHarf = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'ı', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'y', 'z', 'w', 'q', 'x' };
        char[] rakam = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] ozelKarakter = { '!', '&', '+', '-', '*', '/', '=', '|', '%', '/', '#' };
        char[] sifreElemanlari = new char[0];
        private void btnUret_Click(object sender, EventArgs e)
        {
            rtxSifreSergile.Clear();
            Random rnd = new Random();
            if (chbBuyukHarf.Checked == true)
            {
                int hafiza = sifreElemanlari.Length;
                Array.Resize(ref sifreElemanlari, (sifreElemanlari.Length + buyukHarf.Length));
                for (int i = 0; i < buyukHarf.Length; i++)
                    sifreElemanlari[hafiza + i] = buyukHarf[i];
            }
            if (chbKücükHarf.Checked == true)
            {
                int hafiza = sifreElemanlari.Length;
                Array.Resize(ref sifreElemanlari, (sifreElemanlari.Length + kucukHarf.Length));
                for (int i = 0; i < kucukHarf.Length; i++)
                    sifreElemanlari[hafiza + i] = kucukHarf[i];
            }
            if (chbRakam.Checked == true)
            {
                int hafiza = sifreElemanlari.Length;
                Array.Resize(ref sifreElemanlari, (sifreElemanlari.Length + rakam.Length));
                for (int i = 0; i < rakam.Length; i++)
                    sifreElemanlari[hafiza + i] = rakam[i];
            }
            if (chbOzelKarakter.Checked == true)
            {
                int hafiza = sifreElemanlari.Length;
                Array.Resize(ref sifreElemanlari, (sifreElemanlari.Length + ozelKarakter.Length));
                for (int i = 0; i < ozelKarakter.Length; i++)
                    sifreElemanlari[hafiza + i] = ozelKarakter[i];
            }
            if (chbBuyukHarf.Checked == false && chbKücükHarf.Checked == false && chbOzelKarakter.Checked == false && chbRakam.Checked == false)
            {
                MessageBox.Show("Şifre içeriği seçilmedi.");
            }
            else
            {
                for (int i = 0; i < nudSifreSayisi.Value; i++)
                {
                    string sifre = "";
                    for (int j = 0; j < nudSifreUzunlugu.Value; j++)
                    {
                        int rastgele = rnd.Next(0, sifreElemanlari.Length);
                        sifre += sifreElemanlari[rastgele];
                    }
                    rtxSifreSergile.SelectedText = sifre + Environment.NewLine;
                }
            }
            Array.Resize(ref sifreElemanlari, (0));
        }
    }
}
