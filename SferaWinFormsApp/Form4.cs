using InsERT.Moria.Asortymenty;
using InsERT.Moria.ModelDanych;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace SferaWinFormsApp
{
    public partial class Dodaj_Asortyment : Form
    {
        public Dodaj_Asortyment()
        {
            InitializeComponent();
        }

        class Symbol
        {
            public string Nazwa_Symbol { get; set; }
            public string Nazwa_Nazwa { get; set; }
            public string Opis { get; set; }
            public string StawkaVat { get; set; }
            public string EAN { get; set; }
            public string CN { get; set; }
            public string grupa1 { get; set; }
            public Symbol(string sys, string sys1, string sys2, string sys3, string sys4, string sys5,string sys6)
            {
                Nazwa_Symbol = sys;
                Nazwa_Nazwa = sys1;
                Opis = sys2;
                StawkaVat = sys3;
                EAN = sys4;
                CN = sys5;
                grupa1 = sys6;
            }
        }

        public float Count_Progresbar(int row, int number_loop)
        {
            return (float)number_loop / (float)row * 100f;
        }

        private void Pobierz_Szablon_Click(object sender, EventArgs e)
        {
            try
            {
                var excel = new Excel.Application();
                excel.Visible = true;
                excel.Workbooks.Add();
                Excel._Worksheet Arkusz = (Excel._Worksheet)excel.ActiveSheet;

                #region ExelStyle
                {


                    Arkusz.Cells[1, "A"] = "LP.";
                    Arkusz.Cells[1, "A"].Interior.Color = Color.SlateGray;
                    Arkusz.Cells[1, "B"] = "Symbol";
                    Arkusz.Cells[1, "B"].Interior.Color = Color.SlateGray;
                    Arkusz.Cells[1, "C"] = "Nazwa Produktu";
                    Arkusz.Cells[1, "C"].Interior.Color = Color.SlateGray;
                    int p = 1;
                    for (int i = 2; i < 150; i++)
                    {

                        Arkusz.Cells[i, "A"] = p;
                        Arkusz.Cells[i, "A"].Interior.Color = Color.LightGray;
                        p++;
                    }
                    Arkusz.Columns[2].ColumnWidth = 20.00;
                    Arkusz.Columns[3].ColumnWidth = 20.00;
                    Arkusz.Columns[1].ColumnWidth = 6;
                    Arkusz.Range["A1", "C" + p].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
                    Arkusz.Range["A1", "C" + p].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlDouble;
                    Arkusz.Range["A1", "C" + p].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlDouble;
                    Arkusz.Range["A1", "C" + p].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlDouble;
                    Arkusz.Range["A1", "C" + p].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlDouble;
                    Arkusz.Range["A1", "C" + p].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlDouble;
                    Arkusz.Range["A1", "C1"].Font.Bold = true;
                    if (opis_pozycji.Checked == true)
                    {
                        Arkusz.Columns[4].ColumnWidth = 25;
                        Arkusz.Cells[1, "D"] = "Opis Pozycji";
                        Arkusz.Cells[1, "D"].Interior.Color = Color.SlateGray;
                        Arkusz.Range["D1", "D" + p].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["D1", "D" + p].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["D1", "D" + p].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["D1", "D" + p].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["D1", "D" + p].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["D1", "D" + p].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Cells[1, "D"].Font.Bold = true;
                    }
                    else { Arkusz.Columns["D"].Hidden = true; }

                    if (Stawka_Vat.Checked == true)
                    {
                        Arkusz.Columns[5].ColumnWidth = 25;
                        Arkusz.Cells[1, "E"] = "Nazwa Angielska";
                        Arkusz.Cells[1, "E"].Interior.Color = Color.SlateGray;
                        Arkusz.Range["E1", "E" + p].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["E1", "E" + p].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["E1", "E" + p].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["E1", "E" + p].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["E1", "E" + p].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["E1", "E" + p].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Cells[1, "E"].Font.Bold = true;
                    }
                    else { Arkusz.Columns["E"].Hidden = true; }

                    if (checkBox3.Checked == true)
                    {
                        Arkusz.Columns[6].ColumnWidth = 25;
                        Arkusz.Cells[1, "F"] = "Kod EAN";
                        Arkusz.Cells[1, "F"].Interior.Color = Color.SlateGray;
                        Arkusz.Cells[1, "F"].Font.Bold = true;
                        Arkusz.Range["F1", "E" + p].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["F1", "F" + p].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["F1", "F" + p].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["F1", "F" + p].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["F1", "F" + p].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["F1", "F" + p].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlDouble;
                    }
                    else { Arkusz.Columns["G"].Hidden = true; }
                    if (checkBox3.Checked == true)
                    {
                        Arkusz.Columns[7].ColumnWidth = 25;
                        Arkusz.Cells[1, "G"] = "Kod CN";
                        Arkusz.Cells[1, "G"].Interior.Color = Color.SlateGray;
                        Arkusz.Cells[1, "G"].Font.Bold = true;
                        Arkusz.Range["G1", "G" + p].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["G1", "G" + p].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["G1", "G" + p].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["G1", "G" + p].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["G1", "G" + p].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["G1", "G" + p].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlDouble;
                    }
                    else { Arkusz.Columns["G"].Hidden = true; }
                    if (Grupa.Checked == true)
                    {
                        Arkusz.Columns[8].ColumnWidth = 25;
                        Arkusz.Cells[1, "H"] = "Kod CN";
                        Arkusz.Cells[1, "H"].Interior.Color = Color.SlateGray;
                        Arkusz.Cells[1, "H"].Font.Bold = true;
                        Arkusz.Range["H1", "H" + p].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["H1", "H" + p].Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["H1", "H" + p].Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["H1", "H" + p].Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["H1", "H" + p].Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlDouble;
                        Arkusz.Range["H1", "H" + p].Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlDouble;
                    }
                    else { Arkusz.Columns["H"].Hidden = true; }
                }
                #endregion
                excel.Quit();
                Marshal.ReleaseComObject(excel);
                Marshal.ReleaseComObject(Arkusz);
            }
            catch (Exception theException)
            {
                MessageBox.Show("Numer błedu: " + theException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public string path;

        private void Wybór_Ścieżki_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            fbd.ValidateNames = false;
            fbd.CheckFileExists = false;
            fbd.CheckPathExists = true;
            fbd.Filter = "(*.xls, *.xlsx)|*.xls;*.xlsx";
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

        private void Dodaj()
        {
            var Excel_Load = new Ładowanie_Excel();
            Excel_Load.Show();
            IAsortymenty asortymenty = Program.Sfera.PodajObiektTypu<IAsortymenty>();
            ISzablonyAsortymentu szablony = Program.Sfera.PodajObiektTypu<ISzablonyAsortymentu>();
            IGrupyAsortymentu grupy = Program.Sfera.PodajObiektTypu<IGrupyAsortymentu>();
            Excel.Application oApp = new Excel.Application();
            var objBooks = (Excel.Workbooks)oApp.Workbooks;
            if (path == null)
            {
                MessageBox.Show("Dodaj ścieżkę pliku Excel", "Wybierz Ścieżkę", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var objbook = objBooks.Open(path);
            // ścieżka jest modyfikowalna i służy do zaczytywania wartości
            var Sheet = (Excel._Worksheet)objbook.ActiveSheet;
            oApp.Visible = false;
            //Excel.Range range;
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
            //MessageBox.Show("Liczba Rzedów: " + rows);
            //range = Sheet.UsedRange;
            //rows = range.Rows.Count;
            var listsymbol = new List<Symbol>();
            for (int i = 2; i < (rows); i++)
            {
                string z = Sheet.Cells[i, 2].Value2.ToString(); //not null
                string x = Sheet.Cells[i, 3].Value2.ToString(); //not null
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
                string r = "0";
                if (Sheet.Cells[i, "H"].Value2 != null)
                {
                    string y = Sheet.Cells[i, "H"].Value2.ToString();
                    r = y;
                }
                listsymbol.Add(new Symbol(z, x, w, o, l, s, r));
            }
            int Number_loop = 0;
            var New_Ladowanie = new Ładowanie();
            Excel_Load.Close();
            New_Ladowanie.Show();
            foreach (Symbol kupa in listsymbol)
            {
                Number_loop++;
                float Licz = Count_Progresbar(listsymbol.Count(), Number_loop);
                New_Ladowanie.Ładowanie_Load((int)Licz);
                //MessageBox.Show("Test : " + kupa.Nazwa_Symbol + " " + kupa.Nazwa_Nazwa + " " + kupa.Opis);
                using (IAsortyment towarBo = asortymenty.Utworz())
                {
                    towarBo.WypelnijNaPodstawieSzablonu(szablony.DaneDomyslne.Towar);
                    towarBo.Dane.Symbol = kupa.Nazwa_Symbol;
                    towarBo.Dane.Nazwa = kupa.Nazwa_Nazwa;
                    if (opis_pozycji.Checked == true)
                    {
                        towarBo.Dane.Opis = kupa.Opis;
                    }
                    if (Stawka_Vat.Checked == true)
                    {
                        towarBo.Dane.PolaWlasne.PoleWlasne1 = kupa.StawkaVat;
                    }
                    if (checkBox3.Checked == true)
                    {
                        var kod = new KodKreskowy();
                        towarBo.Dane.PodstawowaJednostkaMiaryAsortymentu.KodyKreskowe.Add(kod);
                        kod.Kod = kupa.EAN;
                        towarBo.Dane.PodstawowaJednostkaMiaryAsortymentu.PodstawowyKodKreskowy = kod;
                    }
                    if (Kod_Cn.Checked == true)
                    {
                        towarBo.Dane.KodCN = kupa.CN;
                    }
                    if(Grupa.Checked == true)
                    {
                        GrupaAsortymentu grupa = grupy.Dane.Wszystkie().Where(z => z.Nazwa == kupa.grupa1).FirstOrDefault();
                        if (grupa == null)
                        {
                            using (var grupaBO = grupy.Utworz())
                            {
                                grupaBO.Dane.Nazwa = kupa.grupa1;
                                if (!grupaBO.Zapisz())
                                    grupaBO.WypiszBledy();
                                grupa = grupaBO.Dane;
                            }
                        }
                        towarBo.Dane.Grupa = grupa;
                    }

                    if (!towarBo.Zapisz())
                    {
                        towarBo.WypiszBledy();
                    }

                }
            }
            New_Ladowanie.Visa_Button();
            objBooks.Close();
            oApp.Quit();
            GC.Collect();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Dodaj();
        }
    }

}




