
namespace SferaWinFormsApp.Cenniki_Forms
{
    partial class Przecena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Przecena));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._ObniżenieDecimal = new System.Windows.Forms.NumericUpDown();
            this.Sing2 = new System.Windows.Forms.Label();
            this._ObniżenieInt = new System.Windows.Forms.NumericUpDown();
            this.Sing1 = new System.Windows.Forms.Label();
            this.Button_Check1 = new System.Windows.Forms.RadioButton();
            this.Button_Check2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Cecha_ComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ObniżenieDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ObniżenieInt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz Cennik na którym \r\nchce przeprowadzić operacje .";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._ObniżenieDecimal);
            this.panel1.Controls.Add(this.Sing2);
            this.panel1.Controls.Add(this._ObniżenieInt);
            this.panel1.Controls.Add(this.Sing1);
            this.panel1.Location = new System.Drawing.Point(0, 8);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(264, 72);
            this.panel1.TabIndex = 11;
            // 
            // _ObniżenieDecimal
            // 
            this._ObniżenieDecimal.DecimalPlaces = 2;
            this._ObniżenieDecimal.Dock = System.Windows.Forms.DockStyle.Top;
            this._ObniżenieDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._ObniżenieDecimal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this._ObniżenieDecimal.Location = new System.Drawing.Point(8, 74);
            this._ObniżenieDecimal.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this._ObniżenieDecimal.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this._ObniżenieDecimal.Name = "_ObniżenieDecimal";
            this._ObniżenieDecimal.Size = new System.Drawing.Size(248, 27);
            this._ObniżenieDecimal.TabIndex = 3;
            this._ObniżenieDecimal.Visible = false;
            // 
            // Sing2
            // 
            this.Sing2.AutoSize = true;
            this.Sing2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sing2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sing2.Location = new System.Drawing.Point(8, 54);
            this.Sing2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.Sing2.Name = "Sing2";
            this.Sing2.Size = new System.Drawing.Size(55, 20);
            this.Sing2.TabIndex = 2;
            this.Sing2.Text = "Kwota";
            this.Sing2.Visible = false;
            // 
            // _ObniżenieInt
            // 
            this._ObniżenieInt.Dock = System.Windows.Forms.DockStyle.Top;
            this._ObniżenieInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._ObniżenieInt.Location = new System.Drawing.Point(8, 27);
            this._ObniżenieInt.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this._ObniżenieInt.Name = "_ObniżenieInt";
            this._ObniżenieInt.Size = new System.Drawing.Size(248, 27);
            this._ObniżenieInt.TabIndex = 1;
            // 
            // Sing1
            // 
            this.Sing1.AutoSize = true;
            this.Sing1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sing1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Sing1.Location = new System.Drawing.Point(8, 8);
            this.Sing1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.Sing1.Name = "Sing1";
            this.Sing1.Size = new System.Drawing.Size(85, 19);
            this.Sing1.TabIndex = 0;
            this.Sing1.Text = "Korekta %";
            // 
            // Button_Check1
            // 
            this.Button_Check1.AutoSize = true;
            this.Button_Check1.BackColor = System.Drawing.Color.Transparent;
            this.Button_Check1.Checked = true;
            this.Button_Check1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Check1.Location = new System.Drawing.Point(272, 24);
            this.Button_Check1.Name = "Button_Check1";
            this.Button_Check1.Size = new System.Drawing.Size(168, 24);
            this.Button_Check1.TabIndex = 12;
            this.Button_Check1.TabStop = true;
            this.Button_Check1.Text = "Obniżka o Procent";
            this.Button_Check1.UseVisualStyleBackColor = false;
            this.Button_Check1.CheckedChanged += new System.EventHandler(this.Button_Check1_CheckedChanged);
            // 
            // Button_Check2
            // 
            this.Button_Check2.AutoSize = true;
            this.Button_Check2.BackColor = System.Drawing.Color.Transparent;
            this.Button_Check2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Check2.Location = new System.Drawing.Point(272, 56);
            this.Button_Check2.Name = "Button_Check2";
            this.Button_Check2.Size = new System.Drawing.Size(173, 24);
            this.Button_Check2.TabIndex = 13;
            this.Button_Check2.Text = "Obniżka o Wartość";
            this.Button_Check2.UseVisualStyleBackColor = false;
            this.Button_Check2.CheckedChanged += new System.EventHandler(this.Button_Check2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Button_Check1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Cecha_ComboBox);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.Button_Check2);
            this.groupBox1.Location = new System.Drawing.Point(8, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 136);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(704, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 54);
            this.label3.TabIndex = 17;
            this.label3.Text = "Przeceny nie sumują się bo ustawieniu \r\nna zero cennik wraca \r\ndo statusu przed p" +
    "rzecenna";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(544, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 72);
            this.button1.TabIndex = 16;
            this.button1.Text = "Zmień Cenny";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "Czy ujemna\r\nkorekta ceny ?";
            // 
            // Cecha_ComboBox
            // 
            this.Cecha_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cecha_ComboBox.FormattingEnabled = true;
            this.Cecha_ComboBox.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.Cecha_ComboBox.Location = new System.Drawing.Point(392, 88);
            this.Cecha_ComboBox.Name = "Cecha_ComboBox";
            this.Cecha_ComboBox.Size = new System.Drawing.Size(128, 33);
            this.Cecha_ComboBox.TabIndex = 14;
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
            this.dataGridView1.Location = new System.Drawing.Point(10, 100);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1262, 268);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1021, 516);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(968, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(600, 240);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // Przecena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1021, 516);
            this.Controls.Add(this.groupBox2);
            this.Name = "Przecena";
            this.Text = "Przecena";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Przecena_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ObniżenieDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ObniżenieInt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Sing1;
        private System.Windows.Forms.NumericUpDown _ObniżenieDecimal;
        private System.Windows.Forms.Label Sing2;
        private System.Windows.Forms.NumericUpDown _ObniżenieInt;
        private System.Windows.Forms.RadioButton Button_Check1;
        private System.Windows.Forms.RadioButton Button_Check2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cecha_ComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}