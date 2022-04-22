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
    public partial class Zmiana_Sposobu_Wyliczania : Form
    {
        public Zmiana_Sposobu_Wyliczania(Form Ehe)
        {
            InitializeComponent();
            Connect();
        }

        #region Zmienne 
        readonly Database database = new Database();
        private decimal Obniżka { get { if (_ObniżenieInt.Value > 0 && _ObniżenieInt.Value != null) { return (decimal)_ObniżenieInt.Value / 100; } else { return (decimal)0; } } }
        private string Cennik { get; set; } = "Podstawowy"; //Powod : zawsze na początku ustawione jest Cennik null i wybrana cennik podstawowy
        #endregion

        #region Metody
        public void ZmianaSposobuWyliczaniaCenySprzedazy()
        {
                ICenniki cenniki = Program.Sfera.PodajObiektTypu<ICenniki>();
                ICechyAsortymentu cechy = Program.Sfera.PodajObiektTypu<ICechyAsortymentu>();
                Cennik encjaPodstawowego = cenniki.Dane.Wszystkie().Where(c => c.Tytul == Cennik).FirstOrDefault();
                string pop = Cecha_Combox.SelectedItem.ToString();
                CechaAsortymentu kosmetykPopularny = cechy.Dane.Wszystkie().Where(c => c.Nazwa == pop).FirstOrDefault();
                if (encjaPodstawowego == null)
                {
                    MessageBox.Show("Nie ustawiono cennika");
                    return;
                }
                using (ICennik podstawowy = cenniki.Znajdz(encjaPodstawowego))
                {
                    foreach (IUproszczonaPozycjaCennika pozycja in podstawowy.Pozycje.Wszystkie.Where(p => p.IdCechAsortymentu.Contains(kosmetykPopularny.Id)))
                    {
                        pozycja.RozpocznijEdycje();
                        try
                        {
                        pozycja.DomyslneWyliczajPozycjeWedlug = (int)MetodaWyliczaniaPozycjiCennika.WedlugMarzy;
                            pozycja.ParametrKalkulacyjny = Obniżka;
                            pozycja.PrzeliczPozycje();
                        }
                        finally
                        {
                            pozycja.ZakonczEdycje();
                        }
                    }
                if (podstawowy.Zapisz())
                    MessageBox.Show(" Operacje zakończono z powodzeniem ");
                else
                    MessageBox.Show(" Zmiana nie została zapisana. Coś poszło nie tak .");
                }
        }

        private void Connect()
        {
            using (SqlConnection polaczenie = new SqlConnection(database.Path_Connecting))
            {

                string zapytanie = Builder();
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

        private string Builder()
        {
            return "SELECT ROW_NUMBER() OVER ( ORDER BY [DataZatwierdzenia] ) as 'Lp.' ," +
                " [Tytul] as 'Nazwa Cennika : ' FROM " + database.Nazwa_Bazy + ".[ModelDanychContainer].[Cenniki]";
        }

        #endregion

        #region Eventy / Guziczki / Ładowania

        private object[] PobierzUzytkownikow()
        {
            var uzytkownicy = new List<string>();
            using (var conn = Program.Sfera.PodajPolaczenie())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT DISTINCT Nazwa FROM " + database.Nazwa_Bazy + ".[ModelDanychContainer].[CechyAsortymentu] ";
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    
                    while (reader.Read())
                    {
                        // jest git
                        string q;
                        q = reader.GetString(0);
                        uzytkownicy.Add(q);
                    }
                }
            }
            return uzytkownicy.ToArray();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                Cennik = selectedRow.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void Dodaj_Próg_Cennowy_Load(object sender, EventArgs e)
        {
            Cecha_Combox.Items.AddRange(PobierzUzytkownikow());
            Cecha_Combox.SelectedIndex = 0;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                if (Obniżka != 0) // Aby przypadkowo nie wyzerować cechy
                {
                    ZmianaSposobuWyliczaniaCenySprzedazy();
                }
            }
        }

        private void Dodaj_Cennik_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as Menu_Show).panel2.Visible = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }
        #endregion


    }
}
