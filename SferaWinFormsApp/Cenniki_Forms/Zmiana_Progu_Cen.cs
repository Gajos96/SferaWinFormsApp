using InsERT.Moria.Asortymenty;
using InsERT.Moria.CennikiICeny;
using InsERT.Moria.ModelDanych;
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
    public partial class Zmiana_Progu_Cen : Form
    {
        public Zmiana_Progu_Cen(Form Ehe)
        {
            InitializeComponent();
        }


        #region Zmienne

        #endregion

        #region Metody
        public void DodajProgCenowy()
        {
            ICenniki cenniki = Program.Sfera.PodajObiektTypu<ICenniki>();
            IAsortymenty asortymenty = Program.Sfera.PodajObiektTypu<IAsortymenty>();
            Cennik encjaPodstawowego = cenniki.Dane.Wszystkie().Where(c => c.Tytul == "Podstawowy").FirstOrDefault(); // z danych prezentacyjnych
            Asortyment balsam = asortymenty.Dane.Wszystkie().Where(a => a.Symbol == "BANAW200").FirstOrDefault();
            if (encjaPodstawowego == null)
            {
                MessageBox.Show("Nie znaleziono cennika podstawowego.");
                return;
            }
            using (ICennik podstawowy = cenniki.Znajdz(encjaPodstawowego))
            {
                IUproszczonaPozycjaCennika pozycjaBazowa = podstawowy.Pozycje.Wszystkie.Where(p => p.SymbolAsortymentu == "BANAW200" && p.Glowna).FirstOrDefault();
                IUproszczonaPozycjaCennika progCenowy = podstawowy.Pozycje.Dodaj(balsam);
                progCenowy.RozpocznijEdycje();
                try
                {
                    progCenowy.IloscMinAsortymentu = 10m;
                    if (pozycjaBazowa != null)
                        progCenowy.CenaBrutto = Math.Round(0.75m * pozycjaBazowa.CenaBrutto, podstawowy.Dane.Waluta.PrecyzjaCeny, MidpointRounding.AwayFromZero);
                }
                finally
                {
                    progCenowy.ZakonczEdycje();
                }
                if (podstawowy.Zapisz())
                    MessageBox.Show("Poprawnie zakończono dodawanie progu cenowego.");
                else
                    podstawowy.WypiszBledy();
            }
        }
            #endregion

            #region Eventy / Ładowanie

            #endregion



        }
}
