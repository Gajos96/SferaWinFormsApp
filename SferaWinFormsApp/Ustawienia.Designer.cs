
namespace SferaWinFormsApp
{
    partial class Ustawinia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ustawinia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Przycisk_FindFile = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.database2DataSet = new SferaWinFormsApp.Database2DataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new SferaWinFormsApp.Database2DataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new SferaWinFormsApp.Database2DataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.Przycisk_FindFile);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 632);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustawienia";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(336, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zmień ▼";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(32, 112);
            this.textBox2.MinimumSize = new System.Drawing.Size(208, 48);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(304, 48);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Wyloguj / \r\nZmień Użytkownika";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Przycisk_FindFile
            // 
            this.Przycisk_FindFile.BackColor = System.Drawing.SystemColors.Menu;
            this.Przycisk_FindFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Przycisk_FindFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Przycisk_FindFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Przycisk_FindFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Przycisk_FindFile.Location = new System.Drawing.Point(336, 48);
            this.Przycisk_FindFile.Name = "Przycisk_FindFile";
            this.Przycisk_FindFile.Size = new System.Drawing.Size(88, 49);
            this.Przycisk_FindFile.TabIndex = 1;
            this.Przycisk_FindFile.Text = "Zmień ▼";
            this.Przycisk_FindFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Przycisk_FindFile.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(32, 48);
            this.textBox1.MinimumSize = new System.Drawing.Size(208, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 48);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Zmiana domymyślego położenia Magazynu Lokalizacji .";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database2DataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = SferaWinFormsApp.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Ustawinia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1298, 663);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.MaximumSize = new System.Drawing.Size(1500000, 150000);
            this.MinimumSize = new System.Drawing.Size(1316, 710);
            this.Name = "Ustawinia";
            this.Text = "Janusz Wypieralaj człowiek suksecu";
            this.Load += new System.EventHandler(this.Ustawinia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Przycisk_FindFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database2DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Database2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}