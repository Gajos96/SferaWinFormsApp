using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SferaWinFormsApp.Cenniki_Forms
{
    public partial class Cennik_Menu : Form
    {
        public Cennik_Menu()
        {
            InitializeComponent();
        }




        private void b1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dodaj_Cennik(this));
        }

        private void b2_Click(object sender, EventArgs e)
        {

        }

        private void b3_Click(object sender, EventArgs e)
        {

        }

        private void b4_Click(object sender, EventArgs e)
        {

        }

        private void b5_Click(object sender, EventArgs e)
        {

        }

        private void b6_Click(object sender, EventArgs e)
        {

        }


        public Form activeform { get; set; } = null;


        private void OpenChildForm(Form ChildForm)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
    
    }
}
