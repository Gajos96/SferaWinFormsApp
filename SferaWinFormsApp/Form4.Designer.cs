
namespace SferaWinFormsApp
{
    partial class Dodaj_Asortyment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodaj_Asortyment));
            this.fdb = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pobierz_Szablon = new System.Windows.Forms.Button();
            this.Wybór_Ścieżki = new System.Windows.Forms.Button();
            this.Opis = new System.Windows.Forms.Label();
            this.Text_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Kod_Cn = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Stawka_Vat = new System.Windows.Forms.CheckBox();
            this.opis_pozycji = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Grupa = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Pobierz_Szablon);
            this.groupBox1.Controls.Add(this.Wybór_Ścieżki);
            this.groupBox1.Controls.Add(this.Opis);
            this.groupBox1.Controls.Add(this.Text_Path);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.MinimumSize = new System.Drawing.Size(760, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maks 999 pozycji";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(771, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Pobierz_Szablon
            // 
            this.Pobierz_Szablon.Location = new System.Drawing.Point(610, 34);
            this.Pobierz_Szablon.Name = "Pobierz_Szablon";
            this.Pobierz_Szablon.Size = new System.Drawing.Size(140, 35);
            this.Pobierz_Szablon.TabIndex = 1;
            this.Pobierz_Szablon.Text = "Pobierz Formatkę";
            this.Pobierz_Szablon.UseVisualStyleBackColor = true;
            this.Pobierz_Szablon.Click += new System.EventHandler(this.Pobierz_Szablon_Click);
            // 
            // Wybór_Ścieżki
            // 
            this.Wybór_Ścieżki.Location = new System.Drawing.Point(610, 137);
            this.Wybór_Ścieżki.Name = "Wybór_Ścieżki";
            this.Wybór_Ścieżki.Size = new System.Drawing.Size(140, 33);
            this.Wybór_Ścieżki.TabIndex = 2;
            this.Wybór_Ścieżki.Text = "Wybór ścieżki";
            this.Wybór_Ścieżki.UseVisualStyleBackColor = true;
            this.Wybór_Ścieżki.Click += new System.EventHandler(this.Wybór_Ścieżki_Click);
            // 
            // Opis
            // 
            this.Opis.Location = new System.Drawing.Point(6, 18);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(598, 116);
            this.Opis.TabIndex = 0;
            this.Opis.Text = "Skrócony opis rozwiązania :\r\nRozwiązanie polegające na automatycznym wprowadzaniu" +
    " nowych pozycji asortymentowych\r\nza pomocą formatki excelowskiej.";
            // 
            // Text_Path
            // 
            this.Text_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_Path.Enabled = false;
            this.Text_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Text_Path.Location = new System.Drawing.Point(3, 137);
            this.Text_Path.Name = "Text_Path";
            this.Text_Path.Size = new System.Drawing.Size(589, 27);
            this.Text_Path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz miejsce gdzie znajduję się skończony uzupełniony plik .";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wykonaj operację wprowadzania nowych towarów asortymentowych";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(607, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "Wykonaj !";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Grupa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Kod_Cn);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.Stawka_Vat);
            this.groupBox2.Controls.Add(this.opis_pozycji);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 282);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jeśli wartość nie jest zaznaczona zostanie\r\nokreślona jako wartość domyślna .";
            // 
            // Kod_Cn
            // 
            this.Kod_Cn.AutoSize = true;
            this.Kod_Cn.Location = new System.Drawing.Point(9, 155);
            this.Kod_Cn.Name = "Kod_Cn";
            this.Kod_Cn.Size = new System.Drawing.Size(78, 21);
            this.Kod_Cn.TabIndex = 9;
            this.Kod_Cn.Text = "Kod CN";
            this.Kod_Cn.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 128);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(87, 21);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Kod EAN";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Stawka_Vat
            // 
            this.Stawka_Vat.AutoSize = true;
            this.Stawka_Vat.Location = new System.Drawing.Point(9, 101);
            this.Stawka_Vat.Name = "Stawka_Vat";
            this.Stawka_Vat.Size = new System.Drawing.Size(137, 21);
            this.Stawka_Vat.TabIndex = 7;
            this.Stawka_Vat.Text = "Nazwa Angielska";
            this.Stawka_Vat.UseVisualStyleBackColor = true;
            // 
            // opis_pozycji
            // 
            this.opis_pozycji.AutoSize = true;
            this.opis_pozycji.Location = new System.Drawing.Point(9, 74);
            this.opis_pozycji.Name = "opis_pozycji";
            this.opis_pozycji.Size = new System.Drawing.Size(107, 21);
            this.opis_pozycji.TabIndex = 6;
            this.opis_pozycji.Text = "Opis Pozycji";
            this.opis_pozycji.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Grupa
            // 
            this.Grupa.AutoSize = true;
            this.Grupa.Location = new System.Drawing.Point(9, 182);
            this.Grupa.Name = "Grupa";
            this.Grupa.Size = new System.Drawing.Size(70, 21);
            this.Grupa.TabIndex = 11;
            this.Grupa.Text = "Grupa";
            this.Grupa.UseVisualStyleBackColor = true;
            // 
            // Dodaj_Asortyment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(998, 533);
            this.Name = "Dodaj_Asortyment";
            this.Text = "Dodaj_Asortyment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fdb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Pobierz_Szablon;
        private System.Windows.Forms.Label Opis;
        private System.Windows.Forms.TextBox Text_Path;
        private System.Windows.Forms.Button Wybór_Ścieżki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox Stawka_Vat;
        private System.Windows.Forms.CheckBox opis_pozycji;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.CheckBox Kod_Cn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Grupa;
    }
}