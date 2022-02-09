using System;
using System.Drawing;
using System.Windows.Forms;

namespace SferaWinFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //timer1.Start();

        }
        public bool MinMax1 = false;
        #region CLICK



        private void B_Pan1_Click(object sender, EventArgs e)
        {
            int a = 1;
            Change_Style_Button(a, 0);
            Check_Active(a);
        }

        private void B_Pan2_Click(object sender, EventArgs e)
        {
            int a = 2;
            Change_Style_Button(a, 0);
            Check_Active(a);

        }

        private void B_Pan3_Click(object sender, EventArgs e)
        {
            int a = 3;
            Change_Style_Button(a, 0);
            Check_Active(a); 
        }

        private void Sing_Menu_Click(object sender, EventArgs e)
        {
            Hide_menu();
        }

        #endregion

        private void Hide_menu()
        {
            if (splitContainer1.Panel1Collapsed == true)
            {
                splitContainer1.Panel1Collapsed = false;
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;
            }
        }

        


        private void X_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz wyłaczyć program ? ", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #region Mini/Max Form
        private void Max_Min_Click(object sender, EventArgs e)
        {
            if (MinMax1 == false) // false jeśli normalna
            {
                MinMax1 = true; // Zmienia się na Max
                MAXMIN();
            }
            else // Jeśli zmienia się na min
            {
                MinMax1 = false;
            }

            MAXMIN();
        }

        #region button do nowych formularzy
        private void B1_Click(object sender, EventArgs e)
        {
            int b = 1;
            Change_Style_Button(0, b);
            OpenChildForm(new Dodaj_Asortyment());
        }

        private void B2_Click(object sender, EventArgs e)
        {
            int b = 2;
            Change_Style_Button(0, b);
            OpenChildForm(new Zmien_Asortyment());
        }

        private void B3_Click(object sender, EventArgs e)
        {
            int b = 3;
            Change_Style_Button(0, b);
            OpenChildForm(new Inwentaryzacja());

        }

        private void B4_Click(object sender, EventArgs e)
        {
            int b = 4;
            Change_Style_Button(0, b);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            int b = 5;
            Change_Style_Button(0, b);
        }

        private void B6_Click(object sender, EventArgs e)
        {
            int b = 6;
            Change_Style_Button(0, b);
        }

        #endregion

        private void MAXMIN()
        {
            if (MinMax1 == true) // Jęsli zmienia się na Max
            {
                WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            else
            {
                WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        #endregion

        private void Change_Style_Button(int a, int b)
        {
            if (b == 0)
            {
                if (a == 1)
                {
                    b_Pan1.BackColor = SystemColors.ScrollBar;
                    b_Pan2.BackColor = SystemColors.ButtonShadow;
                    Panel_nr1.BackColor = SystemColors.ButtonShadow;
                }
                if (a == 2)
                {
                    b_Pan2.BackColor = SystemColors.ScrollBar;
                    b_Pan1.BackColor = SystemColors.ButtonShadow;
                    Panel_nr1.BackColor = SystemColors.ButtonShadow;
                }
                if (a == 3)
                {
                    Panel_nr1.BackColor = SystemColors.ScrollBar;
                    b_Pan1.BackColor = SystemColors.ButtonShadow;
                    b_Pan2.BackColor = SystemColors.ButtonShadow;
                }
            }
            if (a == 0)
            {
                if (b == 1)
                {
                    b1.BackColor = SystemColors.ScrollBar;
                    b2.BackColor = SystemColors.ButtonShadow;
                    b3.BackColor = SystemColors.ButtonShadow;
                    b4.BackColor = SystemColors.ButtonShadow;
                    b5.BackColor = SystemColors.ButtonShadow;
                    b6.BackColor = SystemColors.ButtonShadow;
                }
                if (b == 2)
                {
                    b2.BackColor = SystemColors.ScrollBar;
                    b1.BackColor = SystemColors.ButtonShadow;
                    b3.BackColor = SystemColors.ButtonShadow;
                    b4.BackColor = SystemColors.ButtonShadow;
                    b5.BackColor = SystemColors.ButtonShadow;
                    b6.BackColor = SystemColors.ButtonShadow;
                }
                if (b == 3)
                {
                    b3.BackColor = SystemColors.ScrollBar;
                    b1.BackColor = SystemColors.ButtonShadow;
                    b2.BackColor = SystemColors.ButtonShadow;
                    b4.BackColor = SystemColors.ButtonShadow;
                    b5.BackColor = SystemColors.ButtonShadow;
                    b6.BackColor = SystemColors.ButtonShadow;
                }
                if (b == 4)
                {
                    b4.BackColor = SystemColors.ScrollBar;
                    b1.BackColor = SystemColors.ButtonShadow;
                    b2.BackColor = SystemColors.ButtonShadow;
                    b3.BackColor = SystemColors.ButtonShadow;
                    b5.BackColor = SystemColors.ButtonShadow;
                    b6.BackColor = SystemColors.ButtonShadow;
                }
                if (b == 5)
                {
                    b5.BackColor = SystemColors.ScrollBar;
                    b1.BackColor = SystemColors.ButtonShadow;
                    b2.BackColor = SystemColors.ButtonShadow;
                    b3.BackColor = SystemColors.ButtonShadow;
                    b4.BackColor = SystemColors.ButtonShadow;
                    b6.BackColor = SystemColors.ButtonShadow;
                }
                if (b == 6)
                {
                    b6.BackColor = SystemColors.ScrollBar;
                    b1.BackColor = SystemColors.ButtonShadow;
                    b2.BackColor = SystemColors.ButtonShadow;
                    b3.BackColor = SystemColors.ButtonShadow;
                    b4.BackColor = SystemColors.ButtonShadow;
                    b5.BackColor = SystemColors.ButtonShadow;
                }
            }
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
            panel2.Controls.Add(ChildForm);
            panel2.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        public void Form1_Shown(object sender, EventArgs e)
        {
            Refresh();
            Logowanie logowanie = new Logowanie(Program.Sfera);
            var result = logowanie.ShowDialog();
            if (result == DialogResult.OK)
            {
                Program.Sfera.ZalogujOperatora(logowanie.Login, logowanie.Haslo);
                Logowanie.Text = "Zalogowany użytkownik: " + logowanie.Uzytkownik;
            }
            else
            {
                Hide();
            }
        }

        private void Check_Active(int a)
        {
            if (a == 1)
            {
                b_Pan1.Enabled = false;
                b1.Visible = true;
                b2.Visible = true;
                tab1.RowStyles[1].Height = 38;
                tab1.RowStyles[2].Height = 38;
            }
            else
            {
                b_Pan1.Enabled = true;
                b1.Visible = false;
                b2.Visible = false;
                tab1.RowStyles[1].Height = 0;
                tab1.RowStyles[2].Height = 0;
            }
            if (a == 2)
            {
                b_Pan2.Enabled = false;
                b3.Visible = true;
                b4.Visible = true;
                tab1.RowStyles[4].Height = 38;
                tab1.RowStyles[5].Height = 38;
            }
            else
            {
                b_Pan2.Enabled = true;
                b3.Visible = false;
                b4.Visible = false;
                tab1.RowStyles[4].Height = 0;
                tab1.RowStyles[5].Height = 0;
            }
            if (a == 3)
            {
                Panel_nr1.Enabled = false;
                b5.Visible = true;
                b6.Visible = true;
                tab1.RowStyles[7].Height = 38;
                tab1.RowStyles[8].Height = 38;
            }
            else
            {
                Panel_nr1.Enabled = true;
                b5.Visible = false;
                b6.Visible = false;
                tab1.RowStyles[7].Height = 0;
                tab1.RowStyles[8].Height = 0;
            }
        }

        public bool moveDetect = false;

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        public void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }


        int mov;
        int movX;
        int movY;
        private void Form3_Load(object sender, EventArgs e)
        {
            Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void Mini__Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}

