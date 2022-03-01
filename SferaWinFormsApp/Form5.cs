using InsERT.Moria.Asortymenty;
using InsERT.Moria.ModelDanych;
using InsERT.Moria.Waluty;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SferaWinFormsApp
{
    public partial class Zmien_Asortyment : Form
    {
        private Best_Void kr = new Best_Void();

        public Zmien_Asortyment()
        {
            InitializeComponent();
        }

        private string path;

        private void Button3_Click(object sender, System.EventArgs e)
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
                path = OFD.FileName;
                if (path.Length <= 60)
                {
                    Text_Path1.Text = OFD.FileName;
                }
                else
                {
                    string left = path.Substring(0, 3);
                    string right = path.Substring((path.Length - 50), path.Length - (path.Length - 50));
                    Text_Path1.Text = left + @".../..." + right;
                }
            }
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            Create_Excel();
        }

        private void Create_Excel()
        {
            if (Check_List.GetItemChecked(0) == false && Check_List.GetItemChecked(1) == false && Check_List.GetItemChecked(2) == false && Check_List.GetItemChecked(3) == false && Check_List.GetItemChecked(4) == false && Check_List.GetItemChecked(5) == false && Check_List.GetItemChecked(6) == false)
            {
                MessageBox.Show("Zaznacz chociaż jeden element do wymiany", "Wybierz Element", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                var excel = new Excel.Application
                {
                    Visible = true
                };
                excel.Workbooks.Add();
                Excel._Worksheet Arkusz = (Excel._Worksheet)excel.ActiveSheet;
                #region Excel_Kod
                Arkusz.Cells[1, "A"] = "LP."; //1
                Arkusz.Cells[1, "A"].Interior.Color = Color.SlateGray;
                Arkusz.Cells[1, "B"] = "Symbol"; //2
                Arkusz.Cells[1, "B"].Interior.Color = Color.SlateGray;
                Arkusz.Cells[1, "C"] = "Nowy Symbol"; //3
                Arkusz.Cells[1, "C"].Interior.Color = Color.SlateGray;
                Arkusz.Cells[1, "D"] = "Nazwa"; //4
                Arkusz.Cells[1, "D"].Interior.Color = Color.SlateGray;
                Arkusz.Cells[1, "E"] = "Opis"; //5
                Arkusz.Cells[1, "E"].Interior.Color = Color.SlateGray;
                Arkusz.Cells[1, "F"] = "Kod EAN"; //6
                Arkusz.Cells[1, "F"].Interior.Color = Color.SlateGray;
                Arkusz.Cells[1, "G"] = "Pojemnik"; //7
                Arkusz.Cells[1, "G"].Interior.Color = Color.SlateGray;
                Arkusz.Cells[1, "H"] = "Kod CN"; //8
                Arkusz.Cells[1, "H"].Interior.Color = Color.SlateGray;
                Arkusz.Cells[1, "I"] = "Nazwa Angielska"; //9
                Arkusz.Cells[1, "I"].Interior.Color = Color.SlateGray;

                int p = 1;
                for (int i = 2; i < 150; i++)
                {
                    Arkusz.Cells[i, "A"] = p;
                    Arkusz.Cells[i, "A"].Interior.Color = Color.LightGray;
                    p++;
                }

                Arkusz.Columns[1].ColumnWidth = 6;
                Arkusz.Columns[2].ColumnWidth = 20;
                Arkusz.Columns[3].ColumnWidth = 20;
                Arkusz.Columns[4].ColumnWidth = 20;
                Arkusz.Columns[5].ColumnWidth = 20;
                Arkusz.Columns[6].ColumnWidth = 20;
                Arkusz.Columns[7].ColumnWidth = 20;
                Arkusz.Columns[8].ColumnWidth = 20;
                Arkusz.Columns[9].ColumnWidth = 20;

                Arkusz.Range["A1", "I" + p].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
                Arkusz.Range["A1", "I" + p].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlDouble;
                Arkusz.Range["A1", "I" + p].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlDouble;
                Arkusz.Range["A1", "I" + p].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlDouble;
                Arkusz.Range["A1", "I" + p].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlDouble;
                Arkusz.Range["A1", "I" + p].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlDouble;
                Arkusz.Range["A1", "I1"].Font.Bold = true;

                for (int i = 0; i < Check_List.Items.Count; i++)
                {
                    if (Check_List.GetItemChecked(i) == true)
                    {
                        Arkusz.Columns[i + 3].Hidden = false;
                    }
                    else
                    {
                        Arkusz.Columns[i + 3].Hidden = true;
                    }
                }

                excel.Quit(); // Wyłacza Excel po Stworzeniu
                Marshal.ReleaseComObject(excel);  //Zabija Procesy Pliku
                Marshal.ReleaseComObject(Arkusz); //Zabija Procesy Pliku

                #endregion
            }
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            if (Check_List.GetItemChecked(0) == false && Check_List.GetItemChecked(1) == false && Check_List.GetItemChecked(2) == false && Check_List.GetItemChecked(3) == false && Check_List.GetItemChecked(4) == false && Check_List.GetItemChecked(5) == false && Check_List.GetItemChecked(6) == false)
            {
                MessageBox.Show("Zaznacz chociaż jeden element do wymiany", "Wybierz Element", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Text_Path1.Text == null)
                {
                    MessageBox.Show("Dodaj ścieżkę pliku Excel", "Wybierz Ścieżkę", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Dodawanie();
                }
            }
        }

        private void Dodawanie()
        {
            var Excel_Load = new Ładowanie_Excel();
            Excel_Load.Show();
            IAsortymenty asortymenty = Program.Sfera.PodajObiektTypu<IAsortymenty>();
            IWalutyDaneDomyslne walutyDD = Program.Sfera.PodajObiektTypu<IWaluty>().DaneDomyslne;
            Excel.Application oApp = new Excel.Application();
            var objBooks = (Excel.Workbooks)oApp.Workbooks;
            var objbook = objBooks.Open(path);
            var Sheet = (Excel._Worksheet)objbook.ActiveSheet;
            oApp.Visible = false;
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
            var listsymbol = new List<Symbol_Update>();
            for (int i = 2; i < (rows); i++)
            {
                #region Pentla Bleeeee
                string z = Sheet.Cells[i, "B"].Value2.ToString();
                string x = "0";
                if (Sheet.Cells[i, "C"].Value2 != null)
                {
                    string y = Sheet.Cells[i, "C"].Value2.ToString();
                    x = y;
                }
                string w = "0";
                if (Sheet.Cells[i, "D"].Value2 != null)
                {
                    string y = Sheet.Cells[i, "D"].Value2.ToString();
                    w = y;
                }
                string o = "0";
                if (Sheet.Cells[i, "E"].Value2 != null)
                {
                    string y = Sheet.Cells[i, "E"].Value2.ToString();
                    o = y;
                }
                string l = "0";
                if (Sheet.Cells[i, "F"].Value2 != null)
                {
                    string y = Sheet.Cells[i, "F"].Value2.ToString();
                    l = y;
                }
                string s = "0";
                if (Sheet.Cells[i, "G"].Value2 != null)
                {
                    string y = Sheet.Cells[i, "G"].Value2.ToString();
                    s = y;
                }
                string p = "0";
                if (Sheet.Cells[i, "H"].Value2 != null)
                {
                    string y = Sheet.Cells[i, "H"].Value2.ToString();
                    p = y;
                }
                string q = "0";
                if (Sheet.Cells[i, "I"].Value2 != null)
                {
                    string y = Sheet.Cells[i, "I"].Value2.ToString();
                    q = y;
                }
                listsymbol.Add(new Symbol_Update(z, x, w, o, l, s, p, q));
                #endregion
            }
            objBooks.Close();
            oApp.Quit();

            int Number_loop = 0;
            var New_Ladowanie = new Ładowanie();
            Excel_Load.Close();
            New_Ladowanie.Show();
            foreach (Symbol_Update xxx in listsymbol)
            {
                Asortyment aso = asortymenty.Dane.WyszukajPoSymbolu(xxx.Stary_Symbol);
                if (aso != null)
                {
                    using (var towarBo = asortymenty.Znajdz(aso))
                    {
                        Number_loop++;
                        float Licz = kr.Count_Progresbar1(listsymbol.Count(), Number_loop);
                        New_Ladowanie.Ładowanie_Load((int)Licz);
                        if (Check_List.GetItemChecked(0) == true)
                        {
                            towarBo.Dane.Symbol = xxx.Nowy_Symbol;
                        }
                        if (Check_List.GetItemChecked(1) == true)
                        {
                            towarBo.Dane.Nazwa = xxx.Nowa_Nazwa;
                        }
                        if (Check_List.GetItemChecked(2) == true)
                        {
                            towarBo.Dane.Opis = xxx.Opis;
                        }
                        if (Check_List.GetItemChecked(3) == true)
                        {
                            var kod = new KodKreskowy();
                            towarBo.Dane.PodstawowaJednostkaMiaryAsortymentu.KodyKreskowe.Add(kod);
                            kod.Kod = xxx.Kod_Ean;
                            towarBo.Dane.PodstawowaJednostkaMiaryAsortymentu.PodstawowyKodKreskowy = kod;
                        }
                        if (Check_List.GetItemChecked(4) == true)
                        {
                            towarBo.Dane.PolaWlasne.PoleWlasne2 = xxx.Pojemnik;
                        }
                        if (Check_List.GetItemChecked(5) == true)
                        {
                            towarBo.Dane.KodCN = xxx.CN;
                        }
                        if (Check_List.GetItemChecked(6) == true)
                        {
                            towarBo.Dane.PolaWlasne.PoleWlasne1 = xxx.Nazwa_Angielska;
                        }
                        if (!towarBo.Zapisz())
                        {
                            Rozszerzenia.lol = xxx.Nowy_Symbol; // Na ktorym symbolu się wywala
                            towarBo.WypiszBledy();
                        }
                    }
                }
            }
            New_Ladowanie.Visa_Button();
            listsymbol.Clear();
            objBooks.Close();
            oApp.Quit();
            System.GC.Collect();
        }










    }
}
