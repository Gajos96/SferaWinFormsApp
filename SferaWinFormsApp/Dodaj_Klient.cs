using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SferaWinFormsApp
{
    public partial class Dodaj_Klient : Form
    {
        public Dodaj_Klient()
        {
            InitializeComponent();
        }

        private void Check_List_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (Check_List1.GetItemChecked(0) == true)
            {
                Check_List1.SetItemChecked(1, false);
                Check_List1.SetItemChecked(2, false);
            }

            if (Check_List1.GetItemChecked(1) == true)
            {
                Check_List1.SetItemChecked(0, false);
                Check_List1.SetItemChecked(2, false);
            }

            if (Check_List1.GetItemChecked(2) == true)
            {
                Check_List1.SetItemChecked(1, false);
                Check_List1.SetItemChecked(0, false);
            }

        }
    }
}
