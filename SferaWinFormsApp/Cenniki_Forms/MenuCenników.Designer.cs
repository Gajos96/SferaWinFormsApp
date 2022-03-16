
namespace SferaWinFormsApp.Cenniki_Forms
{
    partial class Cennik_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cennik_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.b6);
            this.panel1.Controls.Add(this.b5);
            this.panel1.Controls.Add(this.b4);
            this.panel1.Controls.Add(this.b3);
            this.panel1.Controls.Add(this.b2);
            this.panel1.Controls.Add(this.b1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // b1
            // 
            this.b1.Dock = System.Windows.Forms.DockStyle.Top;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b1.Location = new System.Drawing.Point(0, 0);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(800, 55);
            this.b1.TabIndex = 0;
            this.b1.Text = "Dodaj Cennik Główny";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Dock = System.Windows.Forms.DockStyle.Top;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b2.Location = new System.Drawing.Point(0, 55);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(800, 55);
            this.b2.TabIndex = 1;
            this.b2.Text = "Zmiana Sposobu Wyliczania Ceny Sprzedaży";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Dock = System.Windows.Forms.DockStyle.Top;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b3.Location = new System.Drawing.Point(0, 110);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(800, 55);
            this.b3.TabIndex = 2;
            this.b3.Text = "Przecena";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Dock = System.Windows.Forms.DockStyle.Top;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b4.Location = new System.Drawing.Point(0, 165);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(800, 55);
            this.b4.TabIndex = 3;
            this.b4.Text = "Dodaj Próg Cennowy";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Dock = System.Windows.Forms.DockStyle.Top;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b5.Location = new System.Drawing.Point(0, 220);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(800, 55);
            this.b5.TabIndex = 4;
            this.b5.Text = "Dodawanie Cennika Dodatkowego";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Dock = System.Windows.Forms.DockStyle.Top;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b6.Location = new System.Drawing.Point(0, 275);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(800, 55);
            this.b6.TabIndex = 5;
            this.b6.Text = "Cennik Dodatowy Dla Klienta";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // Cennik_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Cennik_Menu";
            this.Text = "MenuCenników";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
    }
}