namespace WpfApp5
{
    partial class Form3
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
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label1;
            this.pupilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet = new WpfApp5.schoolDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pupilsTableAdapter = new WpfApp5.schoolDataSetTableAdapters.PupilsTableAdapter();
            this.tableAdapterManager = new WpfApp5.schoolDataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            numberLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pupilsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(463, 65);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(95, 13);
            numberLabel.TabIndex = 8;
            numberLabel.Text = "Номер т. ученика";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(463, 91);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(87, 13);
            adressLabel.TabIndex = 10;
            adressLabel.Text = "Адресс ученика";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(463, 120);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(86, 13);
            dOBLabel.TabIndex = 12;
            dOBLabel.Text = "Дата рождения";
            dOBLabel.Click += new System.EventHandler(this.dOBLabel_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(463, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(77, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "ФИО ученика";
            nameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(463, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 13);
            label1.TabIndex = 20;
            label1.Text = "ID Класса";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pupilsBindingSource
            // 
            this.pupilsBindingSource.DataMember = "Pupils";
            this.pupilsBindingSource.DataSource = this.schoolDataSet;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "schoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(441, 285);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "Intsert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 26);
            this.button2.TabIndex = 17;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(629, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 26);
            this.button3.TabIndex = 18;
            this.button3.Text = "Ubdate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(715, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 26);
            this.button4.TabIndex = 19;
            this.button4.Text = "Display";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pupilsTableAdapter
            // 
            this.pupilsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssessmentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.LessensTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PupilsTableAdapter = this.pupilsTableAdapter;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WpfApp5.schoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(561, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(561, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 20);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(561, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(223, 20);
            this.textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(561, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(223, 20);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(561, 120);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(223, 20);
            this.textBox5.TabIndex = 25;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 437);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(nameLabel);
            this.Controls.Add(numberLabel);
            this.Controls.Add(adressLabel);
            this.Controls.Add(dOBLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Ученики";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pupilsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private schoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource pupilsBindingSource;
        private schoolDataSetTableAdapters.PupilsTableAdapter pupilsTableAdapter;
        private schoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}