using InsERT.Moria.ModelDanych;
using InsERT.Moria.Sfera;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SferaWinFormsApp
{
    public partial class Logowanie : Form
    {
        private Uchwyt Sfera { get; set; }
        public string Login { get { return ((Uzytkownik)cbUzytkownik.SelectedItem).Login; } }
        public string Haslo { get { return txtHaslo.Text; } }
        public string Uzytkownik { get { return ((Uzytkownik)cbUzytkownik.SelectedItem).Nazwa; } }

        public Logowanie(Uchwyt sfera)
        {
            Sfera = sfera;
            InitializeComponent();
        }
        private void Logowanie_Load(object sender, EventArgs e)
        {
            cbUzytkownik.Items.AddRange(PobierzUzytkownikow());
            cbUzytkownik.SelectedIndex = 0;
        }
        private object[] PobierzUzytkownikow()
        {
            var uzytkownicy = new List<Uzytkownik>();
            using (var conn = Sfera.PodajPolaczenie())
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT Id, Nazwa, Login FROM ModelDanychContainer.Uzytkownicy WHERE Ukryty = 0 AND NOT Osoba_Id IS NULL; ";
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var u = new Uzytkownik
                        {
                            Id = reader.GetGuid(0),
                            Nazwa = reader.GetString(1),
                            Login = reader.GetString(2)
                        };
                        uzytkownicy.Add(u);
                    }
                }
            }
            return uzytkownicy.ToArray();
        }
        private bool CzyDanePoprawne()
        {
            if (string.IsNullOrWhiteSpace(Haslo) || !Sfera.SprawdzHaslo(Login, Haslo))
            {
                MessageBox.Show(this, "Podane hasło jest niepoprawne.", Text);
                return false;
            }
            return true;
        }
        private void Logowanie_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = DialogResult == DialogResult.OK && !CzyDanePoprawne();
        }
    }
}
