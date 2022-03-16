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
    public partial class Form1 : Form
    {

        public Dodaj_Asortyment sb;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
