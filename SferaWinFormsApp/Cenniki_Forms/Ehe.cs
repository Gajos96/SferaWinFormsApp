using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SferaWinFormsApp.Cenniki_Forms
{
    public partial class Ehe : UserControl , IConneting
    {
        public Ehe(int i)
        {
            InitializeComponent();

            //W zależnośli od tego co jaki label naciśniemy będzie powodowal inne zacąganie 
            Conneting();

        }

        /// <summary>
        /// Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resultBoxList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var dv = listBox1.DataSource as DataView;
            var drv = dv[e.Index];
            drv["Checked"] = e.NewValue == CheckState.Checked ? true : false;
        }

        private void Searce_Box_TextChanged(object sender, EventArgs e)
        {
            var dv = listBox1.DataSource as DataView;
            var filter = Searce_Box.Text.Trim().Length > 0
                ? $"Item LIKE '{Searce_Box.Text}*'"
                : null;

            dv.RowFilter = filter;

            for (var i = 0; i < listBox1.Items.Count; i++)
            {
                var drv = listBox1.Items[i] as DataRowView;
                var chk = Convert.ToBoolean(drv["Checked"]);
                listBox1.SetItemChecked(i, chk);
            }
        }


        #region Połacznienie
        public void Conneting()
        {
            string zapytanie = Builder();
            using (SqlConnection polaczenie = new SqlConnection(Database.Path_Connecting))
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(zapytanie, polaczenie);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sq = new SqlDataAdapter(cmd);
                sq.Fill(dt);
                //dt.Columns.Add("Bool", typeof(bool));
                
                foreach (DataRow dr in dt.Rows)
                {
                    listBox1.Items.Add(Convert.ToString(dr["Nazwa"]));
                }
            }
        }

        public string Builder()
        {
            return "SELECT [Nazwa] FROM " + Database.Nazwa_Bazy +  ".[ModelDanychContainer].[GrupyAsortymentu]";
        }

        #endregion
    }
}
