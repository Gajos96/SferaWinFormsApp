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
            public string path { get; set; }
            public Dupa(int x, string y)
            {
                Number = x;
                path = y;
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
                tableTableAdapter.UpTable(1, InFile.FileName);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            


        }


        private void Ustawinia_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'database2DataSet.Table' . Możesz go przenieść lub usunąć.
            this.tableTableAdapter.Fill(this.database2DataSet.Table);

        }

        //private Rectangle buttonOrginRectangle;
        //private Rectangle OrginFormSize;

        //private void Ustawinia_Load(object sender, EventArgs e)
        //{
        //    OrginFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
        //    buttonOrginRectangle = new Rectangle(label1.Location.X, label1.Location.Y, label1.Size.Width, label1.Size.Height);
        //}

        //private void resizeControl(Rectangle r, Control c)
        //{
        //    float xRatio = (float)(this.Width) / (float)(OrginFormSize.Width);
        //    float yRatio = (float)(this.Height) / (float)(OrginFormSize.Height);

        //    int newX = (int)(r.Width * xRatio);
        //    int newY = (int)(r.Height * yRatio);

        //    int newWidth = (int)(r.Width * xRatio);
        //    int newHeight = (int)(r.Height * yRatio);

        //    c.Location = new Point(newX, newY);
        //    c.Size = new Size(newWidth, newHeight);
        //}

        //private void Ustawinia_Resize(object sender, EventArgs e)
        //{
        //    resizeControl(buttonOrginRectangle, label1);
        //}
    }



}
