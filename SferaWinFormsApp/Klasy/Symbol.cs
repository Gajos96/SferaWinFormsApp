using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Collections;

namespace SferaWinFormsApp
{
    public interface IEntity
    {
        int Id { get; set; }
    }



    class Symbol : IEntity
    {
        public int Id { get; set; }
        public string Nazwa_Symbol { get; set; }
        public string Nazwa_Nazwa { get; set; }
        public string Opis { get; set; }
        public string StawkaVat { get; set; }
        public string EAN { get; set; }
        public string CN { get; set; }
        public string Grupa1 { get; set; }
    }

    public class Lista_Pomocnicza<T> where T : IEntity
    {
        public List<T> List = new List<T>();

        public void AddlistElement(T element)
        {
            if (element != null)
            {
                List.Add(element);
            }
        }

        /// <summary>
        /// Wyszukiwanie po Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetElementById(int id)
        {
            var element = List.FirstOrDefault(o => o.Id == id);
            return element;
        }

        public T GetElement (int index)
        {
            if (index < List.Count)
            {
                return List[index];
            }
            else { return default; }
        }
        
    }

    class Symbol_Update : IEntity
    {
        public string Stary_Symbol { get; set; }
        public string Nowy_Symbol { get; set; }
        public string Nowa_Nazwa { get; set; }
        public string Opis { get; set; }
        public string Kod_Ean { get; set; }
        public string Pojemnik { get; set; }
        public string CN { get; set; }
        public string Nazwa_Angielska { get; set; }
        public int Id { get; set; }
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

    public static class Important_data
    {
        public static bool Active { get; set; } = true;
        public static string Login { get; set; } = "Szef";
    }

    public static class Database
    {
        public static string Path_Connecting  { get {return @"Data Source=GARTENLAND13\SQLEXPRESS;Initial Catalog=Nexo_Demo_1;Integrated Security=True";}}
        public static string Nazwa_Bazy { get { return @"[Nexo_Demo_1]"; } }
    }

    public class Cechy_List
    {
        public string Nazwa { get; set; }
    }


}
