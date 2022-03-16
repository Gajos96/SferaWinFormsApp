using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using InsERT.Moria.ModelDanych;
using InsERT.Moria.Klienci;

namespace SferaWinFormsApp
{
    public partial class Dodaj_Klient : Form
    {
        private Best_Void kr = new Best_Void();
        public Dodaj_Klient()
        {
            InitializeComponent();
        }


        /// <summary>
        /// RadioButtony edytujące Szablon Excela .
        /// </summary>
        #region RadioButton
        private void Radio_button_Domyslne(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            radioButton3.Checked = false;
        }

        private void Radio_button_wpisz(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton3.Checked = true;
        }

        #endregion


        /// <summary>
        /// Obsługa TextBoxa z pliku.
        /// </summary>
        #region Ścieżka_Dostępu_Do_Pliku
        public string path;

        private void Wybór_Ścieżki_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog
            {
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                Filter = "(*.xls, *.xlsx)|*.xls;*.xlsx"
            };
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = fbd.FileName;
                if (path.Length <= 50)
                {
                    Text_Path.Text = fbd.FileName;
                }
                else
                {
                    string left = path.Substring(0, 3);
                    string right = path.Substring((path.Length - 50), path.Length - (path.Length - 50));
                    Text_Path.Text = left + "..." + right;
                }
            }
        }
        #endregion


        /// <summary>
        /// Edycja Excela i jego stylu .
        /// </summary>
        #region ExcelStyle
        private void Pobierz_Szablon_Click(object sender, EventArgs e)
        {
                try
                {
                    var excel = new Excel.Application
                    {
                        Visible = true
                    };
                    excel.Workbooks.Add();
                    Excel._Worksheet Arkusz = (Excel._Worksheet)excel.ActiveSheet;

                    #region ExelStyle
                    {
                        Arkusz.Cells[1, "A"] = "Lp : ";
                        Arkusz.Cells[1, "A"].Interior.Color = Color.SlateGray; //1

                        Arkusz.Cells[1, "B"] = "Odział Nazwa skrócona : ";
                        Arkusz.Cells[1, "B"].Interior.Color = Color.SlateGray; //2

                        Arkusz.Cells[1, "C"] = "Nazwa Firmy : ";
                        Arkusz.Cells[1, "C"].Interior.Color = Color.SlateGray; //3

                        Arkusz.Cells[1, "D"] = "NIP -> Format (XXXX - XXXX - XXXX) ";
                        Arkusz.Cells[1, "D"].Interior.Color = Color.SlateGray; //4

                        Arkusz.Cells[1, "E"] = "Nazwa Klienta ";
                        Arkusz.Cells[1, "E"].Interior.Color = Color.SlateGray; //5

                        int p = 1;
                        for (int i = 2; i < 150; i++)
                        {
                            Arkusz.Cells[i, "A"] = p;
                            Arkusz.Cells[i, "A"].Interior.Color = Color.LightGray;
                            p++;
                        }

                        Arkusz.Columns[1].ColumnWidth = 6;
                        Arkusz.Columns[2].ColumnWidth = 25.00;
                        Arkusz.Columns[3].ColumnWidth = 25.00;
                        Arkusz.Columns[4].ColumnWidth = 25.00;
                        Arkusz.Columns[5].ColumnWidth = 25.00;

                    ///<summary>
                    ///Dodanie dodatkowej kolumny
                    /// </summary>
                    if (radioButton3.Checked == true)
                    {
                        Arkusz.Cells[1, "F"] = "Symbol Klienta : ";
                        Arkusz.Cells[1, "F"].Interior.Color = Color.SlateGray; //6
                        Arkusz.Columns[6].ColumnWidth = 25.00;
                        Arkusz.Range["A1", "F" + p].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["A1", "F" + p].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["A1", "F" + p].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["A1", "F" + p].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["A1", "F" + p].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["A1", "F" + p].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["A1", "F1"].Font.Bold = true;
                    }
                    else
                    {
                        Arkusz.Range["A1", "E" + p].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["A1", "E" + p].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["A1", "E" + p].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["A1", "E" + p].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["A1", "E" + p].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["A1", "E" + p].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["A1", "E1"].Font.Bold = true;
                    }
                        #endregion
                        excel.Quit();
                        Marshal.ReleaseComObject(excel);
                        Marshal.ReleaseComObject(Arkusz);

                    }
                }
                catch (Exception theException)
                {
                    MessageBox.Show("Numer błedu: " + theException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        #endregion


        private void button3_Click(object sender, EventArgs e)
        {
            Polecenie_Wykonaj();
        }

        public void Polecenie_Wykonaj()
        {
            var ListError = new Form1();
            var Excel_Load = new Ładowanie_Excel();
            Excel_Load.Show();
            IPodmioty podmioty = Program.Sfera.PodajObiektTypu<IPodmioty>();
            Podmiot encjaOddzial = null;

            #region Zaczytywanie do listy Excela
            var List = new List<Klient>();
            Excel.Application oApp = new Excel.Application();
            var objBooks = (Excel.Workbooks)oApp.Workbooks;
            if (path == null)
            {
                MessageBox.Show("Dodaj ścieżkę pliku Excel", "Wybierz Ścieżkę", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var objbook = objBooks.Open(path);
            var Sheet = (Excel._Worksheet)objbook.ActiveSheet;
            oApp.Visible = false;

            ///<summary>
            ///Do przerobienia lepsze zaczytywanie z Excela
            ///</summary>
            int rows = 0;
            int g = 2;
            for (int i = 2; i < (1500); i++)
            {
                if (Sheet.Cells[i, 2].Value != null)
                {
                    g++;
                }
            }
            rows = g;

            for (int i = 2; i < (rows); i++)
            {
                string x = Sheet.Cells[i, 2].Value2.ToString(); //not null
                string y = Sheet.Cells[i, 3].Value2.ToString(); //not null
                string z = Sheet.Cells[i, 4].Value2.ToString(); //not null
                string c = Sheet.Cells[i, 5].Value2.ToString(); // Zalezności od  radio wymagane rób nie
                List.Add(new Klient(x, y ,z, c));
            }
            int Number_loop = 0;
            var New_Ladowanie = new Ładowanie();
            Excel_Load.Close();
            New_Ladowanie.Show();
            foreach (var list in List)
            {
                using (IPodmiot oddzial = podmioty.UtworzFirme())
                {
                    Number_loop++;
                    float Licz = kr.Count_Progresbar1(List.Count(), Number_loop);
                    New_Ladowanie.Ładowanie_Load((int)Licz);
                    if (radioButton2.Checked == false)
                    {
                        oddzial.AutoSymbol();
                    }
                    else
                    {
                        oddzial.AutoSymbol(); // Wrłócene tego
                    }
                    oddzial.Dane.NazwaSkrocona = list.Name_Short;
                    oddzial.Dane.Firma.Nazwa = list.Nazwa_Firmy ;
                    oddzial.Dane.NIPSformatowany = list.NIP;
                    if (oddzial.Zapisz()) { }
                    else
                    {
                        oddzial.WypiszBledy();
                        return;
                    }


                }

            }


            #endregion






        }




    }
}
