using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using AdamAsmacaFormProje.Properties;

namespace AdamAsmacaFormProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Genel Değişkenler
        string kelime = "";
        char[] yertutucu;
        bool bayrak;
        int hak;
        private string resources;
        #endregion
        
        private void btnBaşlat_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.adamasmaca1;
            lblÇizgi.Text = "";
            btnBaşlat.Enabled = false;
            hak = 9;
            lblHakSayac.Text = Convert.ToString(hak);

            #region Buton Durumları
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnÇ.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btnG.Enabled = true;
            btnĞ.Enabled = true;
            btnH.Enabled = true;
            btnI.Enabled = true;
            btnİ.Enabled = true;
            btnJ.Enabled = true;
            btnK.Enabled = true;
            btnL.Enabled = true;
            btnM.Enabled = true;
            btnN.Enabled = true;
            btnO.Enabled = true;
            btnÖ.Enabled = true;
            btnP.Enabled = true;
            btnR.Enabled = true;
            btnS.Enabled = true;
            btnŞ.Enabled = true;
            btnT.Enabled = true;
            btnU.Enabled = true;
            btnÜ.Enabled = true;
            btnV.Enabled = true;
            btnY.Enabled = true;
            btnZ.Enabled = true;
            #endregion
            #region Buton Renklerini Sıfırlama
            btnA.BackColor = Color.White;
            btnB.BackColor = Color.White;
            btnC.BackColor = Color.White;
            btnÇ.BackColor = Color.White;
            btnD.BackColor = Color.White;
            btnE.BackColor = Color.White;
            btnF.BackColor = Color.White;
            btnG.BackColor = Color.White;
            btnĞ.BackColor = Color.White;
            btnH.BackColor = Color.White;
            btnI.BackColor = Color.White;
            btnİ.BackColor = Color.White;
            btnJ.BackColor = Color.White;
            btnK.BackColor = Color.White;
            btnL.BackColor = Color.White;
            btnM.BackColor = Color.White;
            btnN.BackColor = Color.White;
            btnO.BackColor = Color.White;
            btnÖ.BackColor = Color.White;
            btnP.BackColor = Color.White;
            btnR.BackColor = Color.White;
            btnS.BackColor = Color.White;
            btnŞ.BackColor = Color.White;
            btnT.BackColor = Color.White;
            btnU.BackColor = Color.White;
            btnÜ.BackColor = Color.White;
            btnV.BackColor = Color.White;
            btnY.BackColor = Color.White;
            btnZ.BackColor = Color.White;
            #endregion

            #region Konular
            ArrayList Konular = new ArrayList();
            Konular.Add("Meyveler");
            Konular.Add("İsimler");
            Konular.Add("Şehirler");
            Konular.Add("Ülkeler");
            Konular.Add("Hayvanlar");
            #endregion

            #region Meyveler
            ArrayList Meyveler = new ArrayList();
            Meyveler.Add("armut");
            Meyveler.Add("kiraz");
            Meyveler.Add("çilek");
            Meyveler.Add("kavun");
            Meyveler.Add("karpuz");
            Meyveler.Add("vişne");
            Meyveler.Add("avakado");
            Meyveler.Add("böğürtlen");
            Meyveler.Add("hurma");
            Meyveler.Add("erik");
            Meyveler.Add("portakal");
            Meyveler.Add("nar");
            Meyveler.Add("mandalina");
            Meyveler.Add("ananas");
            Meyveler.Add("kivi");
            Meyveler.Add("muz");
            Meyveler.Add("greyfurt");
            Meyveler.Add("ayva");
            Meyveler.Add("üzüm");
            Meyveler.Add("kayısı");
            #endregion
            #region Ulkeler
            ArrayList Ulkeler = new ArrayList();
            Ulkeler.Add("bolivya");
            Ulkeler.Add("macaristan");
            Ulkeler.Add("amerika");
            Ulkeler.Add("finlandiya");
            Ulkeler.Add("yunanistan");
            Ulkeler.Add("türkiye");
            Ulkeler.Add("isveç");
            Ulkeler.Add("hırvatistan");
            Ulkeler.Add("arjantin");
            Ulkeler.Add("çin");
            Ulkeler.Add("japonya");
            Ulkeler.Add("yemen");
            Ulkeler.Add("moğolistan");
            Ulkeler.Add("panama");
            Ulkeler.Add("azerbaycan");
            Ulkeler.Add("kazakistan");
            Ulkeler.Add("ırak");
            Ulkeler.Add("iran");
            Ulkeler.Add("katar");
            Ulkeler.Add("kanada");
            #endregion
            #region Isımler
            ArrayList İsimler = new ArrayList();
            İsimler.Add("yusuf");
            İsimler.Add("mahmut");
            İsimler.Add("arda");
            İsimler.Add("muhammet");
            İsimler.Add("betül");
            İsimler.Add("berna");
            İsimler.Add("selin");
            İsimler.Add("mehmet");
            İsimler.Add("beyza");
            İsimler.Add("ahmet");
            İsimler.Add("veli");
            İsimler.Add("ayşe");
            İsimler.Add("abdullah");
            İsimler.Add("merve");
            İsimler.Add("açelya");
            İsimler.Add("ajda");
            İsimler.Add("hande");
            İsimler.Add("sezen");
            İsimler.Add("aleyna");
            İsimler.Add("buket");
            #endregion
            #region Sehirler
            ArrayList Şehirler = new ArrayList();
            Şehirler.Add("istanbul");
            Şehirler.Add("kocaeli");
            Şehirler.Add("ankara");
            Şehirler.Add("izmir");
            Şehirler.Add("bursa");
            Şehirler.Add("çankırı");
            Şehirler.Add("ordu");
            Şehirler.Add("adana");
            Şehirler.Add("şanlıurfa");
            Şehirler.Add("diyarbakır");
            Şehirler.Add("elazığ");
            Şehirler.Add("muğla");
            Şehirler.Add("manisa");
            Şehirler.Add("sakarya");
            Şehirler.Add("kastamonu");
            Şehirler.Add("kırıkkale");
            Şehirler.Add("adıyaman");
            Şehirler.Add("antalya");
            Şehirler.Add("karabük");
            Şehirler.Add("zonguldak");
            #endregion
            #region Hayvanlar
            ArrayList Hayvanlar = new ArrayList();
            Hayvanlar.Add("fil");
            Hayvanlar.Add("köpek");
            Hayvanlar.Add("kedi");
            Hayvanlar.Add("fare");
            Hayvanlar.Add("tavşan");
            Hayvanlar.Add("kaplan");
            Hayvanlar.Add("aslan");
            Hayvanlar.Add("panda");
            Hayvanlar.Add("yılan");
            Hayvanlar.Add("koala");
            Hayvanlar.Add("zürafa");
            Hayvanlar.Add("geyik");
            Hayvanlar.Add("ayı");
            Hayvanlar.Add("çita");
            Hayvanlar.Add("kaplumbağa");
            Hayvanlar.Add("eşek");
            Hayvanlar.Add("keçi");
            Hayvanlar.Add("kurbağa");
            Hayvanlar.Add("kirpi");
            Hayvanlar.Add("timsah");
            #endregion

            #region Konunun Random Belirlenmesi
            Random rnd = new Random();
            int konuIndex = rnd.Next(4);
            string konu = Convert.ToString(Konular[konuIndex]);
            lblkonu2.Text = konu;
            #endregion

            #region Kelimenin Random Belirlenmesi
            Random rnd1 = new Random();
            int kelimeIndex = rnd.Next(20);

            if (konuIndex == 0)
            {
                kelime = Convert.ToString(Meyveler[kelimeIndex]);
            }
            else if (konuIndex == 1)
            {
                kelime = Convert.ToString(İsimler[kelimeIndex]);
            }
            else if (konuIndex == 2)
            {
                kelime = Convert.ToString(Şehirler[kelimeIndex]);
            }
            else if (konuIndex == 3)
            {
                kelime = Convert.ToString(Ulkeler[kelimeIndex]);
            }
            else if (konuIndex == 4)
            {
                kelime = Convert.ToString(Hayvanlar[kelimeIndex]);
            }
            #endregion

            #region Harf Sayısı Kadar Çizgi Bastırma
            yertutucu = new char[kelime.Length];

            for (int i = 0; i < yertutucu.Length; i++)
            {
                yertutucu[i] = '_';
                lblÇizgi.Text += "_ ";
            }
            #endregion
        }
        #region Harfe Kontrolü
        private void HarfOlay(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            char harf = Convert.ToChar(btn.Text); //Basılan butonun hangi tuş olduğunu algılama

            #region Butonların D/Y Olmasına Göre Renk Değiştirmesi ve Pasif Olması Kontrolü
            if (kelime.Contains(harf))
            {
                btn.BackColor = Color.LimeGreen;
                btn.Enabled = false;
            }
            else
            {
                btn.BackColor = Color.IndianRed;
                btn.Enabled = false;
                hak = hak - 1;
                lblHakSayac.Text = Convert.ToString(hak);

                #region Hak Her Azaldığında Resim Değişmesi
                switch (hak)
                {
                    case 8:
                        pictureBox1.Image = Resources.adamasmaca3;
                        break;
                    case 7:
                        pictureBox1.Image = Resources.adamasmaca4;
                        break;
                    case 6:
                        pictureBox1.Image = Resources.adamasmaca5;
                        break;
                    case 5:
                        pictureBox1.Image = Resources.adamasmaca7;
                        break;
                    case 4:
                        pictureBox1.Image = Resources.adamasmaca8;
                        break;
                    case 3:
                        pictureBox1.Image = Resources.adamasmaca9;
                        break;
                    case 2:
                        pictureBox1.Image = Resources.adamasmaca10;
                        break;
                    case 1:
                        pictureBox1.Image = Resources.adamasmaca11;
                        break;
                    case 0:
                        pictureBox1.Image = Resources.adamasmaca12son;
                        break;
                    default:
                        break;
                }
                #endregion
            }
            #endregion

            bayrak = false;
            lblÇizgi.Text = "";

            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i] == harf)
                {
                    yertutucu[i] = harf;
                    bayrak = true;
                }
                lblÇizgi.Text += Convert.ToString(yertutucu[i])+" ";
            }
            #region Bildirimlr
            if (hak==0)
            {
                MessageBox.Show("Kaybettiniz\nDoğru Cevap: "+kelime, "Sonuç Ekranı", MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnBaşlat.Enabled = true;

                #region Harf Butonlarını Kapatma
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnÇ.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
                btnG.Enabled = false;
                btnĞ.Enabled = false;
                btnH.Enabled = false;
                btnI.Enabled = false;
                btnİ.Enabled = false;
                btnJ.Enabled = false;
                btnK.Enabled = false;
                btnL.Enabled = false;
                btnM.Enabled = false;
                btnN.Enabled = false;
                btnO.Enabled = false;
                btnÖ.Enabled = false;
                btnP.Enabled = false;
                btnR.Enabled = false;
                btnS.Enabled = false;
                btnŞ.Enabled = false;
                btnT.Enabled = false;
                btnU.Enabled = false;
                btnÜ.Enabled = false;
                btnV.Enabled = false;
                btnY.Enabled = false;
                btnZ.Enabled = false;
                #endregion

            }
            if (lblÇizgi.Text.Contains("_ ")==false)
            {
                MessageBox.Show("Tebrikler","Sonuç Ekranı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnBaşlat.Enabled = true;

                #region Harf Butonlarını Kapatma
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnÇ.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
                btnG.Enabled = false;
                btnĞ.Enabled = false;
                btnH.Enabled = false;
                btnI.Enabled = false;
                btnİ.Enabled = false;
                btnJ.Enabled = false;
                btnK.Enabled = false;
                btnL.Enabled = false;
                btnM.Enabled = false;
                btnN.Enabled = false;
                btnO.Enabled = false;
                btnÖ.Enabled = false;
                btnP.Enabled = false;
                btnR.Enabled = false;
                btnS.Enabled = false;
                btnŞ.Enabled = false;
                btnT.Enabled = false;
                btnU.Enabled = false;
                btnÜ.Enabled = false;
                btnV.Enabled = false;
                btnY.Enabled = false;
                btnZ.Enabled = false;
                #endregion

            }
            #endregion
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Buton Durumları
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnÇ.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            btnG.Enabled = false;
            btnĞ.Enabled = false;
            btnH.Enabled = false;
            btnI.Enabled = false;
            btnİ.Enabled = false;
            btnJ.Enabled = false;
            btnK.Enabled = false;
            btnL.Enabled = false;
            btnM.Enabled = false;
            btnN.Enabled = false;
            btnO.Enabled = false;
            btnÖ.Enabled = false;
            btnP.Enabled = false;
            btnR.Enabled = false;
            btnS.Enabled = false;
            btnŞ.Enabled = false;
            btnT.Enabled = false;
            btnU.Enabled = false;
            btnÜ.Enabled = false;
            btnV.Enabled = false;
            btnY.Enabled = false;
            btnZ.Enabled = false;
            btnBaşlat.Enabled = true;
            #endregion
        }
    }
}

