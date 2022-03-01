using InsERT.Moria.Asortymenty;
using InsERT.Moria.Dokumenty.Logistyka;
using InsERT.Moria.Inwentaryzacja;
using InsERT.Moria.ModelDanych;
using InsERT.Moria.ModelOrganizacyjny;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Collections;

namespace SferaWinFormsApp
{
    public partial class Łaczymy : Form
    {
        class Zaczytywanie
        {
           public int Id { get; set; }
           public string PathFile { get; set; }
        }

        public Łaczymy()
        {
            InitializeComponent();
            Kupa(staticpath);
        }

        class Pomocnicza
        {
            public string Symbol_1 { get; set; }
            public int Ilosc { get; set; }

            public Pomocnicza(string x, int y)
            {
                Symbol_1 = x;
                Ilosc = y;
            }
        }

       public class Symbol
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
           
        
        

        static readonly string staticpath = @"\\fs1\Szklarnia\Magazyn 2021-2022 Nowy Index\MAGAZYNY LOKALIZACJI  Jesień 2021 wiosna 2022 nowy.xlsx";

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
                        var u = new Magazyn
                        {
                            Id = reader.GetInt32(0),
                            Nazwa = reader.GetString(1),
                            Symbol = reader.GetString(2)
                        };
                        magaz.Add(u);
                    }
                }
            }
            return magaz.ToArray();
        }

        private void Loan_EveryThing(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'pathFile.NewPath' . Możesz go przenieść lub usunąć.
            cbMagazyn.Items.AddRange(Pobierz_Magazyny());
            cbMagazyn.SelectedIndex = 0;
            DownloadPath();


        }

        // Zapytanie
        private DataRowCollection ZapytanieSelect (string zapytanie)
        {
            DataRowCollection dr;
            string asd = "";
            using (SqlConnection poloczenie = new SqlConnection(asd))
            {
                SqlCommand cmd = new SqlCommand(zapytanie, poloczenie);
                cmd.CommandType = CommandType.Text;
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet);
                dr = dataSet.Tables[0].Rows;
            }
            return dr;
        }

        public IEnumerable DownloadPath()
        {
            var dane = ZapytanieSelect("SELECT Id, PathFile FROM dbo.NewPath");
            foreach (DataRow dr in dane)
            {
                yield return new Zaczytywanie
                {
                    Id = int.Parse(dr["Id"].ToString()),
                    PathFile = dr["PathFile"].ToString(),
                };
            }
         }

        // Pozniej przetestuje

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
                if (z < 0)
                {
                    z = 0;
                }
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
                int Number_loop = 0;
                var New_Ladowanie = new Ładowanie();
                Excel_Load.Close();
                New_Ladowanie.Show();
                var lista = new List<Pomocnicza>();
                foreach (Symbol kupa in Lista_Inwetaryzacja)
                {
                    Number_loop++;
                    float Licz = Count_Progresbar(Lista_Inwetaryzacja.Count(), Number_loop);
                    New_Ladowanie.Ładowanie_Load((int)Licz);
                    Asortyment asortyment = asortymenty.Dane.Wszystkie().Where(a => a.Symbol == kupa.Symbol_Rośliny).FirstOrDefault();
                    if (asortyment == null || kupa.Symbol_Rośliny == "Błąd" || kupa.Symbol_Rośliny == "Wprowadz Formę") // Popraw
                    {
                        lista.Add(new Pomocnicza(kupa.Symbol_Rośliny, kupa.Ilość_Rośliny));
                    }
                    else
                    {
                        IUproszczonaPozycjaInwentaryzacji pozycja = inwentaryzacja.Pozycje.Dodaj(asortyment);
                        pozycja.RozpocznijEdycje();
                        pozycja.StanWgSpisow = kupa.Ilość_Rośliny;
                        pozycja.ZakonczEdycje();
                    }
                }
                //kupa
                New_Ladowanie.Visa_Button();
                if (lista.Count > 0)
                {
                    var excel = new Excel.Application
                    {
                        Visible = true
                    };
                    excel.Workbooks.Add();
                    Excel._Worksheet Arkusz = (Excel._Worksheet)excel.ActiveSheet;
                    Arkusz.Cells[1, "A"] = "LP.";
                    Arkusz.Cells[1, "A"].Interior.Color = Color.SlateGray;
                    Arkusz.Cells[1, "B"] = "Sybole nie będące w Subiecie.";
                    Arkusz.Cells[1, "B"].Interior.Color = Color.SlateGray;
                    Arkusz.Cells[1, "C"] = "Ilości na magazynie.";
                    Arkusz.Cells[1, "C"].Interior.Color = Color.SlateGray;
                    Arkusz.Columns[1].ColumnWidth = 5.00;
                    Arkusz.Columns[2].ColumnWidth = 25.00;
                    Arkusz.Columns[3].ColumnWidth = 17.00;
                    int p = 2;
                    foreach (Pomocnicza kupa1 in lista)
                    {
                        Arkusz.Cells[p, "A"] = p - 1;
                        Arkusz.Cells[p, "B"] = kupa1.Symbol_1;
                        Arkusz.Cells[p, "C"] = kupa1.Ilosc;
                        p++;
                    }
                }


                // osoba zatwierdzająca jest wymagana przy wykonanej inwentaryzacji:
                inwentaryzacja.Dane.Zatwierdzajacy = inwentaryzacja.Dane.Odpowiedzialny;
                // ustawianie statusu:
                inwentaryzacja.UstawStatus(statusy.Dane.Wszystkie().Where(s => (s.TypyDokumentow & (int)TypDokumentu.Inwentaryzacja) > 0 && (s.Zamkniety ?? false)).FirstOrDefault(), inwentaryzacja.Dane.DataUtworzenia, (v, m, d) =>
                {
                    Console.WriteLine(string.Format("Postep operacji: {0}. Maksymalny postep: {1}. {2}", v, m, d));
                });
                // zapis inwentaryzacji:
                if (inwentaryzacja.Zapisz())   //Kurwaaaaaaaaaaaaa Dlaczego to się zepsuło
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

        private void Pozycje_not_null()
        {
            IAsortymenty asortymenty = Program.Sfera.PodajObiektTypu<IAsortymenty>();
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
                if (z < 0)
                {
                    z = 0;
                }
                Lista_Inwetaryzacja.Add(new Symbol(x, z)); //Dodawanie do listy 2 elemetów.
            }
            var lista = new List<Pomocnicza>();
            foreach (Symbol kupa in Lista_Inwetaryzacja)
            {
                Asortyment asortyment = asortymenty.Dane.Wszystkie().Where(a => a.Symbol == kupa.Symbol_Rośliny).FirstOrDefault();
                if (asortyment == null && kupa.Symbol_Rośliny != "Błąd" && kupa.Symbol_Rośliny != "Wprowadz Formę" && kupa.Ilość_Rośliny != 0)
                {
                    lista.Add(new Pomocnicza(kupa.Symbol_Rośliny, kupa.Ilość_Rośliny));
                }
            }
            if (lista.Count > 0)
            {
                var excel = new Excel.Application
                {
                    Visible = true
                };
                excel.Workbooks.Add();
                Excel._Worksheet Arkusz = (Excel._Worksheet)excel.ActiveSheet;
                Arkusz.Cells[1, "A"] = "LP.";
                Arkusz.Cells[1, "A"].Interior.Color = Color.SlateGray;
                Arkusz.Cells[1, "B"] = "Sybole nie będące w Subiecie.";
                Arkusz.Cells[1, "B"].Interior.Color = Color.SlateGray;
                Arkusz.Cells[1, "C"] = "Ilości na magazynie.";
                Arkusz.Cells[1, "C"].Interior.Color = Color.SlateGray;
                Arkusz.Columns[1].ColumnWidth = 5.00;
                Arkusz.Columns[2].ColumnWidth = 25.00;
                Arkusz.Columns[3].ColumnWidth = 16.00;
                int p = 2;
                foreach (Pomocnicza kupa1 in lista)
                {
                    Arkusz.Cells[p, "A"] = p - 1;
                    Arkusz.Cells[p, "B"] = kupa1.Symbol_1;
                    Arkusz.Cells[p, "C"] = kupa1.Ilosc;
                    p++;
                }
            }
            else
            {
                MessageBox.Show("Brak nowości");
            }
            Excel_Load.Close();
        }

        private string path1;

        private void Button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog
            {
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                Filter = "(*.xls, *.xlsx)|*.xls;*.xlsx"
            };
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

        private void Button2_Click(object sender, EventArgs e)
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

        private void Nowosci_Click(object sender, EventArgs e)
        {
            Pozycje_not_null();
        }



    }
}