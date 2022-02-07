using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsERT.Mox.BusinessObjects;
using InsERT.Mox.ObiektyBiznesowe;

namespace SferaWinFormsApp
{
    public partial class Ładowanie : Form
    {
        public Ładowanie()
        {

            InitializeComponent();
        }


        private void Zakończ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Ładowanie_Load(int procent)
        {
            try
            {
                progressBar1.Value = (int)(procent);
                if(progressBar1.Value == 100)
                {
                    Info_Label.Text = "Zakończone :";
                }
            }
            catch (Exception theException)
            {
                MessageBox.Show("Numer błedu: " + theException.Message, "Cos się wyjebało", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Visa_Button()
        {
            button1.Enabled = true;
        }

        public void WypiszBledy1(IObiektBiznesowy obiektBiznesowy)
        {
            WypiszBledy1((IBusinessObject)obiektBiznesowy);
            var uow = ((IGetUnitOfWork)obiektBiznesowy).UnitOfWork;
            foreach (var innyObiektBiznesowy in uow.Participants.OfType<IBusinessObject>().Where(bo => bo != obiektBiznesowy))
            {
                WypiszBledy1(innyObiektBiznesowy);
            }
        }
        public void WypiszBledy1(IBusinessObject obiektBiznesowy)
        {
            foreach (var encjaZBledami in obiektBiznesowy.InvalidData)
            {
                foreach (var bladNaCalejEncji in encjaZBledami.Errors) // Do przerobienia
                { 
                    
                    Console.Error.WriteLine(bladNaCalejEncji);
                    textBox1.Text += bladNaCalejEncji + " ";
                    Console.Error.WriteLine(" na encjach:" + encjaZBledami.GetType().Name);
                    textBox1.Text += (" na encjach:" + encjaZBledami.GetType().Name) + "\n";

                }
                foreach (var bladNaKonkretnychPolach in encjaZBledami.MemberErrors)
                {
                    Console.Error.WriteLine(bladNaKonkretnychPolach.Key);
                    textBox1.Text += bladNaKonkretnychPolach.Key + " ";
                    Console.Error.WriteLine(" na polach:");
                    textBox1.Text += " na polach: ";
                    Console.Error.WriteLine(string.Join(", ", bladNaKonkretnychPolach.Select(b => encjaZBledami.GetType().Name + "." + b)));
                    textBox1.Text += " na polach: ";
                }
            }
        }

    }
}
