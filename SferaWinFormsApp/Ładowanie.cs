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








    }
}
