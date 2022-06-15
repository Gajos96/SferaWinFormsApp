using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SferaWinFormsApp.Cenniki_Forms;
using SferaWinFormsApp.Klasy;

namespace SferaWinFormsApp.Cenniki_Forms
{
    public partial class Menu_Show : Form
    {

       
        public Menu_Show(Form Main_Menu)
        {
                InitializeComponent();
        }

        private Form activeform = null;
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

        public void Button1_Click(object sender, EventArgs e)
        {
            Hide_Button();
            Dodaj_Cennik lol = new Dodaj_Cennik
            {
                Owner = this
            };
            OpenChildForm(lol);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Hide_Button();
            Zmiana_Sposobu_Wyliczania lol2 = new Zmiana_Sposobu_Wyliczania(this)
            {
                Owner = this
            };
            OpenChildForm(lol2);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Hide_Button();
            Przecena lol3 = new Przecena(this)
            {
                Owner = this
            };
            OpenChildForm(lol3);
        }



        private void Button5_Click(object sender, EventArgs e)
        {
            Hide_Button();
            Dodaj_Dodadkowy lol5 = new Dodaj_Dodadkowy()
            {
                Owner = this
            };
            OpenChildForm(lol5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Hide_Button();
            Personalizacja_Cennika_Dodakowego lol6 = new Personalizacja_Cennika_Dodakowego(this)
            {
                Owner = this
            };
            OpenChildForm(lol6);
        }

        private void Hide_Button()
        {
            panel2.Visible = false;
        }
    }
}
