using InsERT.Moria.Asortymenty;
using InsERT.Moria.CennikiICeny;
using InsERT.Moria.ModelDanych;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SferaWinFormsApp.Cenniki_Forms
{
    public partial class Zmiana_Progu_Cen : Form
    {
        public Zmiana_Progu_Cen()
        {
            InitializeComponent();
        }


        #region Zmienne
        private string Nazwa_Cennika { get; set; } // return 
        private string Nazwa_Grupy { get; set; }
        private string Nazwa_Cechy { get; set; }
        List<string> lista_symboli;
        #endregion

        #region Metody
        public void DodajProgCenowy()
        {
            ICenniki cenniki = Program.Sfera.PodajObiektTypu<ICenniki>();
            IAsortymenty asortymenty = Program.Sfera.PodajObiektTypu<IAsortymenty>();
            ICechyAsortymentu cechy = Program.Sfera.PodajObiektTypu<ICechyAsortymentu>();
            Cennik encjaPodstawowego = cenniki.Dane.Wszystkie().Where(c => c.Tytul == Nazwa_Cennika).FirstOrDefault(); // Wybór cennika jak w innych arkuszach
            // Zaprogramuj rózne opcje po symbolach / po wszyskim / po grupach / po cechach 


            //Asortyment _Symbol = asortymenty.Dane.Wszystkie().Where(a => a.Symbol == "BANAW200").FirstOrDefault(); /* =====> To będzie w innym miejscu z Enumerate */

            // Asortyment _Symbol = asortymenty.Dane.Wszystkie().Where(a => a.Grupa == "Batman" && a => a.Grupa != null).FirstOrDefault();
            CechaAsortymentu _cecha = cechy.Dane.Wszystkie().Where(c => c.Nazwa == "ehe").FirstOrDefault();
            Asortyment Wszyskie = asortymenty.Dane.Wszystkie().FirstOrDefault(); //wszysko
            if (encjaPodstawowego == null)
            {
                MessageBox.Show("Nie znaleziono cennika podstawowego.");
                return;
            }
            using (ICennik podstawowy = cenniki.Znajdz(encjaPodstawowego))
            {
                IUproszczonaPozycjaCennika pozycjaBazowa = podstawowy.Pozycje.Wszystkie.Where(p => p.SymbolAsortymentu == "BANAW200" && p.Glowna).FirstOrDefault();
                //IUproszczonaPozycjaCennika progCenowy = podstawowy.Pozycje.Dodaj(_Symbol);
                //progCenowy.RozpocznijEdycje();
                //try
                //{
                //    progCenowy.IloscMinAsortymentu = 10m;
                //    if (pozycjaBazowa != null)
                //        progCenowy.CenaBrutto = Math.Round(0.75m * pozycjaBazowa.CenaBrutto, podstawowy.Dane.Waluta.PrecyzjaCeny, MidpointRounding.AwayFromZero);
                //}
                //finally
                //{
                //    progCenowy.ZakonczEdycje();
                //}
                //if (podstawowy.Zapisz())
                //    MessageBox.Show("Poprawnie zakończono dodawanie progu cenowego.");
                //else
                //    podstawowy.WypiszBledy();
            }
        }

        private void Connect()
        {
            Przecena przecena = new Przecena(this);
            using (SqlConnection polaczenie = new SqlConnection(Database.Path_Connecting))
            {
                string zapytanie = przecena.Builder();
                SqlCommand cmd = new SqlCommand(zapytanie, polaczenie)
                {
                    CommandType = System.Data.CommandType.Text
                };
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);
                try
                {
                    dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                    dataGridView1.Columns[0].Width = 40;
                    dataGridView1.Columns[1].Width = 800;
                }
                catch { }
            }
        }



        #endregion

        #region Eventy / Ładowanie

        #endregion

        #region Lebel Event
        private void Grupy_Filtr_Cechy_MouseEnter(object sender, EventArgs e)
        {
            Cecha_Label.Font = new Font("Arial", 12, FontStyle.Bold);
            Cecha_Label.Font = new Font("Arial", 12, FontStyle.Underline);
        }

        private void Cecha_Label_Click(object sender, EventArgs e)
        {
            Cecha_Label.ForeColor = Color.Blue;
            Label_Filtr_Grupa.Controls.Add(new Ehe(0));
        }

        private void Grupy_Filtr_Cechy_MouseLeave(object sender, EventArgs e)
        {
            Cecha_Label.Font = new Font("Arial", 10, FontStyle.Regular);
        }

        #endregion


        private void Grupa_Label_MouseEnter(object sender, EventArgs e)
        {
            Grupa_Label.Font = new Font("Arial", 12, FontStyle.Bold);
            Grupa_Label.Font = new Font("Arial", 12, FontStyle.Underline);
        }

        private void Grupa_Label_MouseLeave(object sender, EventArgs e)
        {
            Grupa_Label.Font = new Font("Arial", 10, FontStyle.Regular);
        }

        private void Grupa_Label_Click(object sender, EventArgs e)
        {
            Cecha_Label.ForeColor = Color.Blue;
            Label_Filtr_Grupa.Controls.Add(new Ehe(1));
        }

    }
}
