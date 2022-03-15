﻿using System;
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
            List<string> rodzaj_Dokumentów = new List<string>();
                rodzaj_Dokumentów.Add("FS");
                rodzaj_Dokumentów.Add("FZ");
                rodzaj_Dokumentów.Add("RR");
                rodzaj_Dokumentów.Add("FL");
                rodzaj_Dokumentów.Add("ZK");
                rodzaj_Dokumentów.Add("ZD");
                rodzaj_Dokumentów.Add("PA");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Sort_Data.OriginDate = dateTimePicker1.Value;
            Sort_Data.FinishDate = dateTimePicker2.Value;
            Sort_Data.Rodzaj_dokumentu = cbDokument.Text;

            if (cbDokument.Text != null)
            {
                using (SqlConnection polaczenie = new SqlConnection(@"Data Source=GARTENLAND13\SQLEXPRESS;Initial Catalog=Nexo_Demo_2;Integrated Security=True"))
                {

                    string zapytanie = Builder();
                    SqlCommand cmd = new SqlCommand(zapytanie, polaczenie);
                    cmd.CommandType = System.Data.CommandType.Text;
                    DataSet dataSet = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0].DefaultView;

               
                    //try
                    //{
                    //    polaczenie.Open();
                    //}
                    //catch
                    //{
                    //    Console.WriteLine(" Nie Udało się połaczyć z serverem :");
                    //    Console.WriteLine(" W razie problemów skontaktuj się z administratorem");
                    //}

                }

            }
        }


        public static string Builder()
        {
            ///<summary>
            /// Konwersja dat na zgodne z datami z subiecta
            /// </summary>
            string pomocniczy1 = Sort_Data.OriginDate.ToString("MM-dd-yyyy HH:mm:ss");
            string pomocniczy2 = Sort_Data.FinishDate.ToString("MM-dd-yyyy HH:mm:ss");
            ///<summary>
            ///Zapytanie do Sql o połaczone 3 tabele Dokument/ Pozycja Asortymentu / oraz Asortyment
            /// </summary>
            string local1 = @"SELECT d.[LP] , e.[Symbol], e.[Nazwa] , (g.[DataWprowadzenia]) , g.[NumerWewnetrzny_PelnaSygnatura] as 'Numer dokumentu', g.[NumerZewnetrzny] as 'Numer Orginału' , d.[ilosc] ,d.[Cena_NettoPoRabacie] ,g.[Symbol]
            FROM[Nexo_Demo_2].[ModelDanychContainer].[PozycjeDokumentu] d INNER JOIN[Nexo_Demo_2].[ModelDanychContainer].[Asortymenty] e
            ON d.[AsortymentWybranyId] = e.[Id]
            INNER JOIN[Nexo_Demo_2].[ModelDanychContainer].[Dokumenty] g ON d.[Dokument_Id] = g.[ID]
            where g.[Symbol] = ('";
            string local2 = @"') and(g.[NumerWewnetrzny_PelnaSygnatura] LIKE '[A-Z]%') and (g.[DataWprowadzenia] BETWEEN '";
            string local3 = @"')
            ORDER BY g.[NumerWewnetrzny_PelnaSygnatura], d.[LP]";
            string Question = local1 +  Sort_Data.Rodzaj_dokumentu + local2 + pomocniczy1 + "' AND '" + pomocniczy2 + local3;
            return Question;
        }





    }
}
