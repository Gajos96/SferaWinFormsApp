
namespace SferaWinFormsApp
{
    partial class Dodaj_Klient
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
            this.fdb = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Wybór_Ścieżki = new System.Windows.Forms.Button();
            this.Opis = new System.Windows.Forms.Label();
            this.Text_Path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pobierz_Szablon = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Wybór_Ścieżki);
            this.groupBox1.Controls.Add(this.Opis);
            this.groupBox1.Controls.Add(this.Text_Path);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.MinimumSize = new System.Drawing.Size(760, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz miejsce gdzie znajduję się skończony uzupełniony plik .";
            // 
            // Wybór_Ścieżki
            // 
            this.Wybór_Ścieżki.Location = new System.Drawing.Point(608, 136);
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
            this.Opis.Size = new System.Drawing.Size(946, 116);
            this.Opis.TabIndex = 0;
            this.Opis.Text = "Skrócony opis rozwiązania :\r\nRozwiązanie polegające na automatycznym wprowadzaniu" +
    " nowych klientów za pomocą\r\npliku excel . System zaczytuje pozycję i wprowadza j" +
    "ę do systemu .";
            // 
            // Text_Path
            // 
            this.Text_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_Path.Enabled = false;
            this.Text_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Text_Path.Location = new System.Drawing.Point(8, 136);
            this.Text_Path.Name = "Text_Path";
            this.Text_Path.Size = new System.Drawing.Size(589, 27);
            this.Text_Path.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(408, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 51);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maksymalna ilość pozycji 1000\r\nNadmierna ilość pozycji może powodować\r\nbłędy w ba" +
    "zie danych .";
            // 
            // Pobierz_Szablon
            // 
            this.Pobierz_Szablon.Location = new System.Drawing.Point(208, 88);
            this.Pobierz_Szablon.Name = "Pobierz_Szablon";
            this.Pobierz_Szablon.Size = new System.Drawing.Size(184, 43);
            this.Pobierz_Szablon.TabIndex = 1;
            this.Pobierz_Szablon.Text = "Pobierz Formatkę";
            this.Pobierz_Szablon.UseVisualStyleBackColor = true;
            this.Pobierz_Szablon.Click += new System.EventHandler(this.Pobierz_Szablon_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 40);
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
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Pobierz_Szablon);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(8, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 304);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 288);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton3.Location = new System.Drawing.Point(8, 120);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(137, 24);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.Tag = "";
            this.radioButton3.Text = "Wpisz Symbol";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton2.Location = new System.Drawing.Point(8, 88);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 24);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "";
            this.radioButton2.Text = "AutoSymbol";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(142, 57);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wybierz jedną opcję\r\npo czym chcesz\r\nwyszukiwać klientów";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(208, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(380, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "Zaznacz wartość oraz wybierz ścieżkę do pliku excel ,aby\r\nwykonać polecenie dodaw" +
    "ania kontrahentów .";
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
            // Dodaj_Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(998, 533);
            this.Name = "Dodaj_Klient";
            this.Text = "Dodaj Kotrahenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fdb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Pobierz_Szablon;
        private System.Windows.Forms.Label Opis;
        private System.Windows.Forms.TextBox Text_Path;
        private System.Windows.Forms.Button Wybór_Ścieżki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}