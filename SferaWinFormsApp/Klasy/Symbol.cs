using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace SferaWinFormsApp
{
    class Symbol
    {
        public string Nazwa_Symbol { get; set; }
        public string Nazwa_Nazwa { get; set; }
        public string Opis { get; set; }
        public string StawkaVat { get; set; }
        public string EAN { get; set; }
        public string CN { get; set; }
        public string Grupa1 { get; set; }
        public Symbol(string sys, string sys1, string sys2, string sys3, string sys4, string sys5, string sys6)
        {
            Nazwa_Symbol = sys;
            Nazwa_Nazwa = sys1;
            Opis = sys2;
            StawkaVat = sys3;
            EAN = sys4;
            CN = sys5;
            Grupa1 = sys6;
        }
    }

    class Symbol_Update
    {
        public string Stary_Symbol { get; set; }
        public string Nowy_Symbol { get; set; }
        public string Nowa_Nazwa { get; set; }
        public string Opis { get; set; }
        public string Kod_Ean { get; set; }
        public string Pojemnik { get; set; }
        public string CN { get; set; }
        public string Nazwa_Angielska { get; set; }
        public Symbol_Update(string lol, string sys, string sys1, string sys2, string sys3, string sys4, string sys5, string sys6)
        {
            Stary_Symbol = lol;
            Nowy_Symbol = sys;
            Nowa_Nazwa = sys1;
            Opis = sys2;
            Kod_Ean = sys3;
            Pojemnik = sys4;
            CN = sys5;
            Nazwa_Angielska = sys6;
        }
    }

    static class Path_Find
    {
        public static string Path_Access { get; set; }

        public static Action<string> path = (y) =>
         {
             Path_Access = y;
         };

        public static void Json()
        {
            string PathOption = JsonConvert.SerializeObject(Path_Access);
            File.WriteAllText(Application.StartupPath + "/PathOption.json", PathOption);
            //Zaczytywanie do pliku Json Scieżki do magazynu ( Zapisuje ją )
        }
    }

    public static class Sort_Data
    {
        public static DateTime OriginDate { get; set; }
        public static DateTime FinishDate { get; set; }
        public static string Rodzaj_dokumentu { get; set; }
    }

    class Klient
    {
        public string Symbol { get; set; }
        public string NIP { get; set; }
        public string Nazwa_Firmy { get; set; }
        public string Name_Short { get; set; }

        public Klient(string x, string y, string z, string c)
        {
            Symbol = c ?? throw new ArgumentNullException(nameof(c));
            NIP = y;
            Nazwa_Firmy = z;
            Name_Short = x;
        }

    }

    public static class Cenniki_Pomocnicza
    {
        private static bool _active;
        /// <summary>
        /// Reaguje jak zmiane
        /// </summary>
        public static bool Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
            }
        }
    }



}
