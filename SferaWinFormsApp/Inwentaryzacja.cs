using InsERT.Moria.Asortymenty;
using InsERT.Moria.Dokumenty.Logistyka;
using InsERT.Moria.Inwentaryzacja;
using InsERT.Moria.ModelDanych;
using InsERT.Moria.ModelOrganizacyjny;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SferaWinFormsApp
{
    public partial class Inwentaryzacja : Form
    {
        public Inwentaryzacja()
        {
            InitializeComponent();
            Kupa(staticpath);
        }

        class Symbol
        {
            public string Symbol_Rośliny { get; set; }
            public int Ilość_Rośliny { get; set; }

            public Symbol(string x, int y)
            {
                Symbol_Rośliny = x;
                Ilość_Rośliny = y;
            }
        }

        private string Kupa(string i)
        {
            if (i.Length <= 70)
            {
                Text_Path1.Text = i;
            }
            else
            {
                string left = i.Substring(0, 3);
                string right = i.Substring((i.Length - 50), i.Length - (i.Length - 50));
                Text_Path1.Text = left + @".../..." + right;
            }
            return i;
        }
        // Tworzenie spisu inwentaryzacji
        static string staticpath = @"\\fs1\Szklarnia\Magazyn 2021-2022 Nowy Index\MAGAZYNY LOKALIZACJI  Jesień 2021 wiosna 2022 nowy.xlsx";

        private object[] Pobierz_Magazyny()
        {
            var magaz = new List<Magazyn>();
            using (var conn = Program.Sfera.PodajPolaczenie())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT Id,Nazwa,Symbol FROM ModelDanychContainer.Magazyny;";
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var u = new Magazyn();
                        u.Id = reader.GetInt32(0);
                        u.Nazwa = reader.GetString(1);
                        u.Symbol = reader.GetString(2);
                        magaz.Add(u);
                    }
                }
            }
            return magaz.ToArray();
        }

        private void Loan_EveryThing(object sender, EventArgs e)
        {
            cbMagazyn.Items.AddRange(Pobierz_Magazyny());
            cbMagazyn.SelectedIndex = 0;
        }

        public float Count_Progresbar(int row, int number_loop)
        {
            return (float)number_loop / (float)row * 100f;
        }

        private void Auto_Spis()
        {
            var Excel_Load = new Ładowanie_Excel();
            Excel_Load.Show();
            if (path1 == null)
            {
                path1 = staticpath;
            }
            var WFile = new Excel.Application();
            Excel.Workbook Wbook = WFile.Workbooks.Open(path1, ReadOnly: true);
            var Sheet = (Excel._Worksheet)Wbook.Sheets[4];
            WFile.Visible = false;
            string row = Sheet.Cells[1, "J"].Value2.ToString();
            int ok = Int32.Parse(row);
            var Lista_Inwetaryzacja = new List<Symbol>();
            for (int i = 1; i < ok; i++)
            {
                string x = Sheet.Cells[i + 1, "A"].Value2.ToString();
                string y = Sheet.Cells[i + 1, "F"].Value2.ToString();
                int z = Int32.Parse(y);
                Lista_Inwetaryzacja.Add(new Symbol(x, z)); //Dodawanie do listy 2 elemetów.
            }
            string magazine_ = cbMagazyn.Text;
            IInwentaryzacje inwentaryzacje = Program.Sfera.PodajObiektTypu<IInwentaryzacje>();
            IKonfiguracje konfiguracje = Program.Sfera.PodajObiektTypu<IKonfiguracje>();
            IAsortymenty asortymenty = Program.Sfera.PodajObiektTypu<IAsortymenty>();
            IMagazyny magazyny = Program.Sfera.PodajObiektTypu<IMagazyny>();
            ICentrale centrale = Program.Sfera.PodajObiektTypu<ICentrale>();
            IStatusyDokumentow statusy = Program.Sfera.PodajObiektTypu<IStatusyDokumentow>();
            Konfiguracja konfiguracjaIw = konfiguracje.DaneDomyslne.Inwentaryzacja;
            Magazyn glowny = magazyny.Dane.Wszystkie().Where(m => m.Nazwa == magazine_).FirstOrDefault();
            Centrala centrala = centrale.Dane.Wszystkie().FirstOrDefault();

            using (IInwentaryzacja inwentaryzacja = inwentaryzacje.Utworz(konfiguracjaIw))
            {
                inwentaryzacja.Dane.Magazyn = glowny;
                inwentaryzacja.Dane.MiejsceWprowadzenia = centrala;
                int Number_loop =0;
                var New_Ladowanie = new Ładowanie();
                Excel_Load.Close();
                New_Ladowanie.Show();
                
                foreach (Symbol kupa in Lista_Inwetaryzacja)
                {
                    Number_loop++;
                    float Licz =Count_Progresbar(Lista_Inwetaryzacja.Count(), Number_loop);
                    New_Ladowanie.Ładowanie_Load((int)Licz);
                    Asortyment asortyment = asortymenty.Dane.Wszystkie().Where(a => a.Symbol == kupa.Symbol_Rośliny).FirstOrDefault();
                    if (asortyment == null)
                    {
                        Console.WriteLine(string.Format("Nie znaleziono asortymentu o symbolu {0}", kupa.Symbol_Rośliny));
                    }
                    else
                    {
                        IUproszczonaPozycjaInwentaryzacji pozycja = inwentaryzacja.Pozycje.Dodaj(asortyment);
                        pozycja.RozpocznijEdycje();
                        pozycja.StanWgSpisow = kupa.Ilość_Rośliny;
                        pozycja.ZakonczEdycje();
                    }
                }
                New_Ladowanie.Visa_Button();
                // osoba zatwierdzająca jest wymagana przy wykonanej inwentaryzacji:
                inwentaryzacja.Dane.Zatwierdzajacy = inwentaryzacja.Dane.Odpowiedzialny;
                // ustawianie statusu:
                inwentaryzacja.UstawStatus(statusy.Dane.Wszystkie().Where(s => (s.TypyDokumentow & (int)TypDokumentu.Inwentaryzacja) > 0 && (s.Zamkniety ?? false)).FirstOrDefault(), inwentaryzacja.Dane.DataUtworzenia, (v, m, d) =>
                {
                    Console.WriteLine(string.Format("Postep operacji: {0}. Maksymalny postep: {1}. {2}", v, m, d));
                });
                // zapis inwentaryzacji:
                if (inwentaryzacja.Zapisz())
                {
                    Console.WriteLine(string.Format("Zapisano inwentaryzację o numerze {0}.", inwentaryzacja.Dane.NumerInwentaryzacji.PelnaSygnatura));
                }
                else
                {
                    inwentaryzacja.WypiszBledy();
                }
                Wbook.Close();
                WFile.Quit();
                Lista_Inwetaryzacja.Clear();
                System.GC.Collect();
            }
        }

        private string path1;
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ValidateNames = false;
            OFD.CheckFileExists = false;
            OFD.CheckPathExists = true;
            OFD.Filter = "(*.xls, *.xlsx)|*.xls;*.xlsx";
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path1 = OFD.FileName;
                if (path1.Length <= 70)
                {
                    Text_Path1.Text = OFD.FileName;
                }
                else
                {
                    string left = path1.Substring(0, 3);
                    string right = path1.Substring((path1.Length - 50), path1.Length - (path1.Length - 50));
                    Text_Path1.Text = left + @".../..." + right;
                }
                OFD.FileName = path1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Auto_Spis();
            }
            catch (Exception theException)
            {
                MessageBox.Show("Numer błedu: " + theException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

