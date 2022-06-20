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
    public partial class Ustawinia : Form
    {
        
        public Ustawinia()
        {
            InitializeComponent();
            
        }
        class Dupa
        {
            public int Number { get; set; }
            public string Path { get; set; }
            public Dupa(int x, string y)
            {
                Number = x;
                Path = y;
            }
            
        }

        public string path_update;

        private void Label1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog InFile = new OpenFileDialog()
            {
                ValidateNames = false,
                CheckFileExists = false,
                CheckPathExists = true,
                Filter = "(*.xls, *.xlsx)|*.xls;*.xlsx"

            };
            if (InFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Path_Find.path(InFile.FileName);
                Path_Find.Json();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
