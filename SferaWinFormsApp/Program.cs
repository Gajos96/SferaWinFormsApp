using InsERT.Moria.Sfera;
using InsERT.Mox.BusinessObjects;
using InsERT.Mox.ObiektyBiznesowe;
using InsERT.Mox.Product;
using System;
using System.Linq;
using System.Windows.Forms;


namespace SferaWinFormsApp
{
    static class Program
    {

        public static Uchwyt UruchomSfere()
        {
            DanePolaczenia danePolaczenia = null;
            string pName = "/UruchomionePrzezInsLauncher";
            if (Environment.GetCommandLineArgs().Any(a => string.Compare(a, pName, true) == 0))
            {
                danePolaczenia = DanePolaczenia.Odbierz();
            }
            else
            {
                danePolaczenia = DanePolaczenia.Jawne(@"GARTENLAND13\SQLEXPRESS", "Nexo_Demo_1", true);
            }

            MenedzerPolaczen mp = new MenedzerPolaczen();
            return mp.Polacz(danePolaczenia, ProductId.Subiekt);
        }

        private static Uchwyt _sfera = null;
        public static Uchwyt Sfera
        {
            get
            {
                if (_sfera == null)
                {
                    _sfera = UruchomSfere();
                }

                return _sfera;
            }
        }


        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Ładowanie());
            Application.Run(new Form3());
        }
    }


  public static class Rozszerzenia
{
    internal static void WypiszBledy(this InsERT.Mox.ObiektyBiznesowe.IObiektBiznesowy obiektBiznesowy)
    {
        WypiszBledy((InsERT.Mox.BusinessObjects.IBusinessObject)obiektBiznesowy);
        var uow = ((InsERT.Mox.BusinessObjects.IGetUnitOfWork)obiektBiznesowy).UnitOfWork;
        foreach (var innyObiektBiznesowy in uow.Participants.OfType<InsERT.Mox.BusinessObjects.IBusinessObject>().Where(bo => bo != obiektBiznesowy))
        {
            WypiszBledy(innyObiektBiznesowy);
        }
    }

    internal static void WypiszBledy(this InsERT.Mox.BusinessObjects.IBusinessObject obiektBiznesowy)
    {
        foreach (var encjaZBledami in obiektBiznesowy.InvalidData)
        {
            foreach (var bladNaCalejEncji in encjaZBledami.Errors)
            {
                Console.Error.WriteLine(bladNaCalejEncji);
                Console.Error.WriteLine(" na encjach:" + encjaZBledami.GetType().Name);
                Console.Error.WriteLine();
            }
            foreach (var bladNaKonkretnychPolach in encjaZBledami.MemberErrors)
            {
                Console.Error.WriteLine(bladNaKonkretnychPolach.Key);
                Console.Error.WriteLine(" na polach:");
                Console.Error.WriteLine(string.Join(", ", bladNaKonkretnychPolach.Select(b => encjaZBledami.GetType().Name + "." + b)));
                Console.Error.WriteLine();
            }
        }
    }
}


}