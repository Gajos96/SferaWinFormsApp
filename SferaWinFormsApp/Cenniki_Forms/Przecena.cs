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
using System.Text.RegularExpressions;

namespace SferaWinFormsApp.Cenniki_Forms
{
    public partial class Przecena : Form
    {

        // Tutaj jest wszysko jest Git

        public Przecena(Form ehe)
        {
            InitializeComponent();
            Connect();
            Cecha_ComboBox.SelectedIndex = 1;
        }

        #region Zmienne oraz Formy
        Database database = new Database();
        /// <summary>
        /// Przyjmuje nazwę z Data Grid
        /// </summary>
        private string Cennik { get; set; }
        
        /// <summary>
        /// Wyliczanie procentowej obniżki oraz groszowej
        /// </summary>
        private decimal Obniżka { get { if (_ObniżenieInt.Value > 0 && _ObniżenieInt.Value != null) { return (decimal)_ObniżenieInt.Value / 100; } else { return (decimal)0;}}}
        private decimal Obniżkagrosz { get { if (_ObniżenieDecimal.Value > 0 && _ObniżenieDecimal.Value != null) { return (decimal)_ObniżenieDecimal.Value; } else { return (decimal)0; } } }

        /// <summary>
        /// Czy ujemna korekta cenny
        /// </summary>
        private bool Cecha1 { get { if (Cecha_ComboBox.SelectedItem.ToString() == "Tak") { return true; } else return false; } }
        #endregion

        #region Zmiany i ukrywanie przy Radio Buttonach
        private void Button_Check1_CheckedChanged(object sender, EventArgs e)
        {
            if (Button_Check1.Checked == true) { Sing1.Visible = true; _ObniżenieInt.Visible = true; Button_Check2.Checked = false; }
            else { _ObniżenieInt.Visible = false; Sing1.Visible = false; Button_Check2.Checked = true; _ObniżenieInt.Value = 0; }
        }

        private void Button_Check2_CheckedChanged(object sender, EventArgs e)
        {
            if (Button_Check2.Checked == true) { _ObniżenieDecimal.Visible = true; Sing2.Visible = true; }
            else { _ObniżenieDecimal.Visible = false; Sing2.Visible = false; _ObniżenieDecimal.Value = 0; }
        }
        #endregion

        #region Metody + Połaczenie z Bazą
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

        /// <summary>
        /// Fukcja odpowiedzalna za obsługę wprowadzania przecen na podstawie cenników
        /// </summary>
        public void Przecena_Cennikow()
        {
            ICenniki cenniki = Program.Sfera.PodajObiektTypu<ICenniki>();
            Cennik encjaPodstawowego = cenniki.Dane.Wszystkie().Where(c => c.Tytul == Cennik).FirstOrDefault();
            using (ICennik podstawowy = cenniki.Znajdz(encjaPodstawowego))
            {
                MessageBox.Show(Obniżka + " " + Obniżkagrosz + " " + _ObniżenieDecimal + " " + _ObniżenieInt);
                podstawowy.Przecen(
                    podstawowy.Pozycje.Wszystkie,
                    RodzajPrzeceny.ObnizkaProcentowa,
                    Obniżka, // obniżka 
                    FunkcjeWyrownywaniaCeny.WyrownywanieDoJednostek_Id,
                    Cecha1, // ujemna/dodatnia korekta ceny
                    Obniżkagrosz, // korekta ceny o 1 grosz
                    true,
                    (v, m, d) =>
                    {

                        return false;
                    });
                if (podstawowy.Zapisz())
                    MessageBox.Show(" Poprawnie zakończono wykonywanie przeceny. ");
                else
                    MessageBox.Show(" Coś poszło nie tak. ");
            }
        }
        #endregion

        #region Event Click Button
        /// <summary>
        /// Obsługa Grida po kliknieciu i zaciąganie z niego wartości
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void Przecena_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as Menu_Show).panel2.Visible = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Przecena_Cennikow();
        }
        #endregion

    }
}
