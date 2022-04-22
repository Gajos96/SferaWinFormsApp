using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SferaWinFormsApp.Klasy;

namespace SferaWinFormsApp
{
    public partial class Pozycje_Fakturowe : Form
    {
        public Pozycje_Fakturowe()
        {
            InitializeComponent();
        }

        

        /// <summary>
        /// Tworzenie listy podstawowych dokumentów do zaczytania ( nie istnieje okreslona lista faktów w bazie SQL )
        /// </summary>
        /// <param name="rodzaj_Dokumentów"></param>
        /// <returns></returns>
        object[] Zaczytanie ()
        {
            List<string> rodzaj_Dokumentów = new List<string>
            { "FS",
              "FZ",
              "RR",
              "FL",
              "ZK",
              "ZD",
              "PA"
            };
            rodzaj_Dokumentów.Sort();
                return rodzaj_Dokumentów.ToArray();
        }

        private void Pozycje_Fakturowe_Load(object sender, EventArgs e)
        {
            ///<summary>
            /// Załadowywanie przy otwarciu formsa listy Asortymentów 
            ///</summary>
            cbDokument.Items.AddRange(Zaczytanie());
            cbDokument.SelectedIndex = 0;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Sort_Data.OriginDate = dateTimePicker1.Value;
            Sort_Data.FinishDate = dateTimePicker2.Value;
            Sort_Data.Rodzaj_dokumentu = cbDokument.Text;

            if (cbDokument.Text != null)
            {
                Database database = new Database();
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
                    try { dataGridView1.DataSource = dataSet.Tables[0].DefaultView; }
                    catch { }

                }

            }
        }


        public static string Builder()
        {
            Database database1 = new Database();
            ///<summary>
            /// Konwersja dat na zgodne z datami z subiecta
            /// </summary>
            string pomocniczy1 = Sort_Data.OriginDate.ToString("MM-dd-yyyy HH:mm:ss");
            string pomocniczy2 = Sort_Data.FinishDate.ToString("MM-dd-yyyy HH:mm:ss");
            ///<summary>
            ///Zapytanie do Sql o połaczone 3 tabele Dokument/ Pozycja Asortymentu / oraz Asortyment
            /// </summary>
            string local1 = @"SELECT d.[LP] , e.[Symbol], e.[Nazwa] , (g.[DataWprowadzenia]) , g.[NumerWewnetrzny_PelnaSygnatura] as 'Numer dokumentu', g.[NumerZewnetrzny] as 'Numer Orginału' , d.[ilosc] ,d.[Cena_NettoPoRabacie] ,g.[Symbol]
            FROM" + database1.Nazwa_Bazy + ".[ModelDanychContainer].[PozycjeDokumentu] d INNER JOIN" + database1.Nazwa_Bazy + ".[ModelDanychContainer].[Asortymenty] e ON d.[AsortymentAktualnyId] = e.[Id] INNER JOIN" + database1.Nazwa_Bazy + ".[ModelDanychContainer].[Dokumenty] g ON d.[Dokument_Id] = g.[ID] where g.[Symbol] = (";
            string local2 = @"') and(g.[NumerWewnetrzny_PelnaSygnatura] LIKE '[A-Z]%') and (g.[DataWprowadzenia] BETWEEN '";
            string local3 = @"')
            ORDER BY g.[NumerWewnetrzny_PelnaSygnatura], d.[LP]";
            string Question = local1 +  Sort_Data.Rodzaj_dokumentu + local2 + pomocniczy1 + "' AND '" + pomocniczy2 + local3;
            return Question;
        }





    }
}
