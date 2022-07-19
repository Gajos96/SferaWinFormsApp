using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using SferaWinFormsApp.Cenniki_Forms;

namespace SferaWinFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public bool MinMax1 = false;
        #region CLICK

        //private bool Dodawanie_Menu;
        //private bool Zmiana_Menu;
        //private bool Inne_Fukcje_Menu;
        //private bool Ustawienia_manu;

        /// <summary>
        /// Sprawdza który z guzików był klikniety
        /// </summary>
        /// <param name="a"></param>
        private void Zmiana(int a)
        {
            if (a ==1)
            {
                b1.Visible = true;
                b2.Visible = true;
                b3.Visible = false;
                b4.Visible = false;
                b5.Visible = false;
                b6.Visible = false;
                b7.Visible = false;
            }
            if(a==2)
            {
                b1.Visible = false;
                b2.Visible = false;
                b3.Visible = true;
                b4.Visible = true;
                b5.Visible = false;
                b6.Visible = false;
                b7.Visible = false;
            }
            if (a==3)
            {
                b1.Visible = false;
                b2.Visible = false;
                b3.Visible = false;
                b4.Visible = false;
                b5.Visible = true;
                b6.Visible = true;
                b7.Visible = true;
            }
            if (a==4)
            {
                b1.Visible = false;
                b2.Visible = false;
                b3.Visible = false;
                b4.Visible = false;
                b5.Visible = false;
                b6.Visible = false;
                b7.Visible = false;
            }
        }

        private async void B_Pan1_Click(object sender, EventArgs e)
        {
            B_Pan1.Enabled = false;
            int a = 1;
            await Change_Style_Button(a, 0);
            Zmiana(a);
            B_Pan1.Enabled = true;
        }

        private async void B_Pan2_Click(object sender, EventArgs e)
        {
            B_Pan2.Enabled = false;
            int a = 2;
            await Change_Style_Button(a, 0);
            Zmiana(a);
            B_Pan2.Enabled = true;
        }

        private async void B_Pan3_Click(object sender, EventArgs e)
        {
            B_Pan3.Enabled = false;
            int a = 3;
            await Change_Style_Button(a, 0);
            Zmiana(a);
            B_Pan3.Enabled = true;
        }

        private async void B_Pan4_Click(object sender, EventArgs e)
        {
            B_Pan4.Enabled = false;
            int a = 4;
            await Change_Style_Button(a, 0);
            Zmiana(a);
            OpenChildForm(new Ustawinia());
            B_Pan4.Enabled = true;
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
    private async void B1_Click(object sender, EventArgs e)
        {
            int b = 1;
            b1.Enabled = false;
            await Change_Style_Button(0, b);
            OpenChildForm(new Dodaj_Asortyment());
            Thread.Sleep(200);
            b1.Enabled = true;
        }

        private async void B2_Click(object sender, EventArgs e)
        {
            int b = 2;
            b2.Enabled = false;
            await Change_Style_Button(0, b);
            OpenChildForm(new Dodaj_Klient());
            Thread.Sleep(200);
            b2.Enabled = true;
            
        }

        private async void B3_Click(object sender, EventArgs e)
        {
            int b = 3;
            b3.Enabled = false;
            await Change_Style_Button(0, b);
            OpenChildForm(new Zmien_Asortyment());
            Thread.Sleep(200);
            b3.Enabled = true;

        }

        private async void B4_Click(object sender, EventArgs e)
        {
            int b = 4;
            b4.Enabled = false;
          await Change_Style_Button(0, b);
            b4.Enabled = true;
            
        }

        private async void B5_Click(object sender, EventArgs e)
        {
            int b = 5;
            b5.Enabled = false;
           await Change_Style_Button(0, b);
            OpenChildForm(new Łaczymy());
            b5.Enabled = true;
        }

        private async void B6_Click(object sender, EventArgs e)
        {
            int b = 6;
            b6.Enabled = false;
            await Change_Style_Button(0, b);
            OpenChildForm(new Pozycje_Fakturowe());
            b6.Enabled = true;
        }

        private async void B7_Click(object sender, EventArgs e)
        {
            int b = 7;
            b6.Enabled = false;
            await Change_Style_Button(0, b);
            OpenChildForm(new Menu_Show()); ;
            b6.Enabled = true;
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

        /// <summary>
        /// Zmienia kolor guzika przy kliknieciu wykorzystuje wielowatkowość
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private async Task Change_Style_Button(int a, int b)
        {
            await Task.Run(() =>
            {
                if (b == 0)
                {
                    if (a == 1)
                    {
                        B_Pan1.BackColor = SystemColors.ScrollBar;
                        B_Pan2.BackColor = Color.Transparent;
                        B_Pan3.BackColor = Color.Transparent;
                        B_Pan4.BackColor = Color.Transparent;
                    }
                    if (a == 2)
                    {
                        B_Pan2.BackColor = SystemColors.ScrollBar;
                        B_Pan1.BackColor = Color.Transparent;
                        B_Pan3.BackColor = Color.Transparent;
                        B_Pan4.BackColor = Color.Transparent;

                    }
                    if (a == 3)
                    {
                        B_Pan3.BackColor = SystemColors.ScrollBar;
                        B_Pan1.BackColor = Color.Transparent;
                        B_Pan2.BackColor = Color.Transparent;
                        B_Pan4.BackColor = Color.Transparent;
                    }
                    if (a == 4)
                    {
                        B_Pan4.BackColor = SystemColors.ScrollBar;
                        B_Pan1.BackColor = Color.Transparent;
                        B_Pan2.BackColor = Color.Transparent;
                        B_Pan3.BackColor = Color.Transparent;
                    }



                }
                if (a == 0)
                {
                    if (b == 1)
                    {
                        b1.BackColor = SystemColors.ScrollBar;
                        b2.BackColor = Color.Transparent;
                        b3.BackColor = Color.Transparent;
                        b4.BackColor = Color.Transparent;
                        b5.BackColor = Color.Transparent;
                        b6.BackColor = Color.Transparent;
                        b7.BackColor = Color.Transparent;
                    }
                    if (b == 2)
                    {
                        b2.BackColor = SystemColors.ScrollBar;
                        b1.BackColor = Color.Transparent;
                        b3.BackColor = Color.Transparent;
                        b4.BackColor = Color.Transparent;
                        b5.BackColor = Color.Transparent;
                        b6.BackColor = Color.Transparent;
                        b7.BackColor = Color.Transparent;
                    }
                    if (b == 3)
                    {
                        b3.BackColor = SystemColors.ScrollBar;
                        b1.BackColor = Color.Transparent;
                        b2.BackColor = Color.Transparent;
                        b4.BackColor = Color.Transparent;
                        b5.BackColor = Color.Transparent;
                        b6.BackColor = Color.Transparent;
                        b7.BackColor = Color.Transparent;
                    }
                    if (b == 4)
                    {
                        b4.BackColor = SystemColors.ScrollBar;
                        b1.BackColor = Color.Transparent;
                        b2.BackColor = Color.Transparent;
                        b3.BackColor = Color.Transparent;
                        b5.BackColor = Color.Transparent;
                        b6.BackColor = Color.Transparent;
                        b7.BackColor = Color.Transparent;
                    }
                    if (b == 5)
                    {
                        b5.BackColor = SystemColors.ScrollBar;
                        b1.BackColor = Color.Transparent;
                        b2.BackColor = Color.Transparent;
                        b3.BackColor = Color.Transparent;
                        b4.BackColor = Color.Transparent;
                        b6.BackColor = Color.Transparent;
                        b7.BackColor = Color.Transparent;
                    }
                    if (b == 6)
                    {
                        b6.BackColor = SystemColors.ScrollBar;
                        b1.BackColor = Color.Transparent;
                        b2.BackColor = Color.Transparent;
                        b3.BackColor = Color.Transparent;
                        b4.BackColor = Color.Transparent;
                        b5.BackColor = Color.Transparent;
                        b7.BackColor = Color.Transparent;
                    }
                    if (b == 7)
                    {
                        b7.BackColor = SystemColors.ScrollBar;
                        b1.BackColor = Color.Transparent;
                        b2.BackColor = Color.Transparent;
                        b3.BackColor = Color.Transparent;
                        b4.BackColor = Color.Transparent;
                        b5.BackColor = Color.Transparent;
                        b6.BackColor = Color.Transparent;
                    }
                }
            });
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
                Important_data.Login = logowanie.Uzytkownik;
            }
            else
            {
                Hide();
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
