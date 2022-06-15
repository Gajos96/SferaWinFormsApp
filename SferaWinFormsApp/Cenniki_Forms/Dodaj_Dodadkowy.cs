using InsERT.Moria.Asortymenty;
using InsERT.Moria.CennikiICeny;
using InsERT.Moria.ModelDanych;
using InsERT.Moria.Uzytkownicy;
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
    public partial class Dodaj_Dodadkowy : Form
    {
        #region Variables
        private string NazwaCennika { get { return (string)TextNazwa.EditValue; } }
        private decimal Dopuszczalna { get { if (Dopuszczalny.Value > 0 && Dopuszczalny.Value != null) { return (decimal)Dopuszczalny.Value / 100; } else { return (decimal)0; } } }
        private decimal Domyslna { get { if (Domyslny.Value > 0 && Domyslny.Value != null) { return (decimal)Domyslny.Value / 100; } else { return (decimal)0; } } }
        #endregion

        public Dodaj_Dodadkowy()
        {
            InitializeComponent();
        }

        private void Przecena_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as Menu_Show).panel2.Visible = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        public void DodawanieCennikaDodatkowego()
        {
                ICenniki cenniki = Program.Sfera.PodajObiektTypu<ICenniki>();
                IAsortymenty asortymenty = Program.Sfera.PodajObiektTypu<IAsortymenty>();
                IUzytkownicy uzytkownicy = Program.Sfera.PodajObiektTypu<IUzytkownicy>();
                Cennik encjaPodstawowego = cenniki.Dane.Wszystkie().Where(c => c.Tytul == "Podstawowy").FirstOrDefault(); // z danych prezentacyjnych
                if (encjaPodstawowego == null)
                {
                MessageBox.Show("Nie znaleziona cennika podstawowego");
                return;
                }
                using (ICennik cennik = cenniki.Utworz())
                {
                if(NazwaCennika.Length < 5 )
                {
                    MessageBox.Show("Nazwa Cennika jest za krótka . \nMinimalna ilość znaków to 5 .");
                    return;
                }

                    cennik.Dane.Tytul = NazwaCennika;
                    cennik.UstawJakoDodatkowy(encjaPodstawowego);
                    cennik.UstawStatus(uzytkownicy.Dane.Wszystkie().Where(u => u.Login == Important_data.Login).FirstOrDefault(), StatusCennika.Zatwierdzony);

                    IEnumerable<IUproszczonaPozycjaCennika> dodanePozycje =
                        cennik.Dodaj(asortymenty.Dane.Wszystkie().Select(a => a.Id));
                    foreach (IUproszczonaPozycjaCennika pozycja in dodanePozycje)
                    {
                        pozycja.RozpocznijEdycje();
                        try
                        {
                        pozycja.RabatDopuszczalny = Dopuszczalna;
                            pozycja.RabatDomyslny = Domyslna;
                        }
                        finally
                        {
                            pozycja.ZakonczEdycje();
                        }
                    }
                    if (cennik.Zapisz())
                        MessageBox.Show("Cennik został zapisanny");
                    else
                        MessageBox.Show("Wyspapił problem z zapisaniem cennika");
            }
        }

    }
}
