
namespace SferaWinFormsApp.Cenniki_Forms
{
    partial class Zmiana_Progu_Cen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zmiana_Progu_Cen));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Grupa_Label = new System.Windows.Forms.Label();
            this.Cecha_Label = new System.Windows.Forms.Label();
            this.Label_Filtr_Grupa = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Wybierz Cennik :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(32, 64);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(504, 352);
            this.dataGridView1.TabIndex = 18;
            // 
            // Grupa_Label
            // 
            this.Grupa_Label.AutoSize = true;
            this.Grupa_Label.BackColor = System.Drawing.Color.Transparent;
            this.Grupa_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Grupa_Label.Location = new System.Drawing.Point(312, 32);
            this.Grupa_Label.Name = "Grupa_Label";
            this.Grupa_Label.Size = new System.Drawing.Size(98, 20);
            this.Grupa_Label.TabIndex = 20;
            this.Grupa_Label.Text = "Filtr : Grupy";
            this.Grupa_Label.Click += new System.EventHandler(this.Grupa_Label_Click);
            // 
            // Cecha_Label
            // 
            this.Cecha_Label.AutoSize = true;
            this.Cecha_Label.BackColor = System.Drawing.Color.Transparent;
            this.Cecha_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cecha_Label.Location = new System.Drawing.Point(184, 32);
            this.Cecha_Label.Name = "Cecha_Label";
            this.Cecha_Label.Size = new System.Drawing.Size(100, 20);
            this.Cecha_Label.TabIndex = 21;
            this.Cecha_Label.Text = "Filtr : Cechy";
            this.Cecha_Label.Click += new System.EventHandler(this.Cecha_Label_Click);
            // 
            // Label_Filtr_Grupa
            // 
            this.Label_Filtr_Grupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Filtr_Grupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Label_Filtr_Grupa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Filtr_Grupa.Location = new System.Drawing.Point(552, 64);
            this.Label_Filtr_Grupa.Name = "Label_Filtr_Grupa";
            this.Label_Filtr_Grupa.Size = new System.Drawing.Size(504, 352);
            this.Label_Filtr_Grupa.TabIndex = 22;
            // 
            // Zmiana_Progu_Cen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1085, 617);
            this.Controls.Add(this.Label_Filtr_Grupa);
            this.Controls.Add(this.Cecha_Label);
            this.Controls.Add(this.Grupa_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zmiana_Progu_Cen";
            this.Text = "Zmiana_Sposobu_Wyliczania";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Grupa_Label;
        private System.Windows.Forms.Label Cecha_Label;
        private System.Windows.Forms.Panel Label_Filtr_Grupa;
    }
}