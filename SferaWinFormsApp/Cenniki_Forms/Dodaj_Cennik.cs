
using InsERT.Moria.CennikiICeny;
using InsERT.Moria.ModelDanych;
using InsERT.Moria.Uzytkownicy;
using InsERT.Moria.Waluty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SferaWinFormsApp.Cenniki_Forms
{
    public partial class Dodaj_Cennik : Form
    {

        public Dodaj_Cennik(Form ehe)
        {
            InitializeComponent();
            ehe.Close();
        }

        public string Symbol_Cennik { get { return Csymbol.Text; } }
        public string Nazwa_Cennik { get { return Cnazwa.Text; } }



        private void Dodaj_Cennik_Load(object sender, EventArgs e)
        {
            Cwaluta.Items.Add(Euro);
            Cwaluta.Items.Add(Pln);
            Cwaluta.SelectedIndex = 0; 
        }

        string Euro = "EUR";
        string Pln = "PLN";


        public void DodajCennikGlowny()
        {
                ICenniki menadzerCennikow = Program.Sfera.PodajObiektTypu<ICenniki>();
                IPoziomyCen menadzerPoziomowCen = Program.Sfera.PodajObiektTypu<IPoziomyCen>();
                IWalutyDaneDomyslne walutyDD = Program.Sfera.PodajObiektTypu<IWaluty>().DaneDomyslne;
                IUzytkownicy uzytkownicy = Program.Sfera.PodajObiektTypu<IUzytkownicy>();

                PoziomCen poziomWzorcowy = menadzerPoziomowCen.DaneDomyslne.Podstawowy;
                PoziomCen poziom = null;
                using (IPoziomCen poziomCen = menadzerPoziomowCen.Utworz())
                {
                    poziomCen.Dane.Symbol = Symbol_Cennik;
                    poziomCen.Dane.Nazwa = Nazwa_Cennik;
                    poziomCen.Dane.Waluta = Cwaluta.SelectedItem.ToString() == Pln ? walutyDD.PLN : walutyDD.EUR;
                    poziomCen.Dane.FunkcjaWyboruCennika = poziomWzorcowy.FunkcjaWyboruCennika;
                    poziomCen.Dane.FunkcjaWyliczaniaCenyBazowej = poziomWzorcowy.FunkcjaWyliczaniaCenyBazowej;
                    poziomCen.Dane.FunkcjaWyliczaniaCenyBazowejBezStanow = poziomWzorcowy.FunkcjaWyliczaniaCenyBazowejBezStanow;
                //    if (poziomCen.Zapisz())
                //        poziom = poziomCen.Dane;
                //    else
                //        poziomCen.WypiszBledy();
                //}
                //if (poziom != null)
                //{
                //    using (ICennik cennik = menadzerCennikow.Utworz())
                //    {
                //        cennik.Dane.PoziomCen = poziom;
                //        cennik.Dane.Bazowy = true; // ustawiamy cennik jako główny
                //        cennik.Dane.Tytul = "Cennik " + poziom.Nazwa;
                //       // cennik.Dane.CenaZerowa = (int)MetodaWyliczaniaPozycjiCennika.WedlugMarzy; // Wywali
                //        //cennik.Dane.DomyslnaMarza = 0.65m;
                //        cennik.WypelnijCennik(); // generujemy pozycje dla całego asortymentu

                //        //opublikowanie (zatwierdzenie) cennika:
                //        cennik.UstawStatus(uzytkownicy.Dane.Wszystkie().First(), StatusCennika.Zatwierdzony);

                //    if (cennik.Zapisz()) { }
                //    else
                //        cennik.WypiszBledy();
                //    }
                }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Csymbol.Text != null && Cnazwa.Text != null)
            {
                DodajCennikGlowny();
           
            }
            else
                MessageBox.Show("Nie wypełniono wszyskich Pól");
        }

        private void Dodaj_Cennik_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
