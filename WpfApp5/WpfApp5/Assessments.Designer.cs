namespace WpfApp5
{
    partial class Assessments
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label pupilsIDLabel;
            System.Windows.Forms.Label subjectIDLabel;
            System.Windows.Forms.Label attendanceLabel;
            System.Windows.Forms.Label assessmentLabel;
            System.Windows.Forms.Label label1;
            this.schoolDataSet = new WpfApp5.schoolDataSet();
            this.assessmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assessmentsTableAdapter = new WpfApp5.schoolDataSetTableAdapters.AssessmentsTableAdapter();
            this.tableAdapterManager = new WpfApp5.schoolDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            pupilsIDLabel = new System.Windows.Forms.Label();
            subjectIDLabel = new System.Windows.Forms.Label();
            attendanceLabel = new System.Windows.Forms.Label();
            assessmentLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "schoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assessmentsBindingSource
            // 
            this.assessmentsBindingSource.DataMember = "Assessments";
            this.assessmentsBindingSource.DataSource = this.schoolDataSet;
            // 
            // assessmentsTableAdapter
            // 
            this.assessmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssessmentsTableAdapter = this.assessmentsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.LessensTableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.PupilsTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WpfApp5.schoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(696, 21);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(73, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Фио ученика";
            // 
            // pupilsIDLabel
            // 
            pupilsIDLabel.AutoSize = true;
            pupilsIDLabel.Location = new System.Drawing.Point(696, 47);
            pupilsIDLabel.Name = "pupilsIDLabel";
            pupilsIDLabel.Size = new System.Drawing.Size(52, 13);
            pupilsIDLabel.TabIndex = 4;
            pupilsIDLabel.Text = "Pupils ID:";
            // 
            // subjectIDLabel
            // 
            subjectIDLabel.AutoSize = true;
            subjectIDLabel.Location = new System.Drawing.Point(696, 78);
            subjectIDLabel.Name = "subjectIDLabel";
            subjectIDLabel.Size = new System.Drawing.Size(60, 13);
            subjectIDLabel.TabIndex = 6;
            subjectIDLabel.Text = "Subject ID:";
            // 
            // attendanceLabel
            // 
            attendanceLabel.AutoSize = true;
            attendanceLabel.Location = new System.Drawing.Point(696, 135);
            attendanceLabel.Name = "attendanceLabel";
            attendanceLabel.Size = new System.Drawing.Size(65, 13);
            attendanceLabel.TabIndex = 8;
            attendanceLabel.Text = "Attendance:";
            // 
            // assessmentLabel
            // 
            assessmentLabel.AutoSize = true;
            assessmentLabel.Location = new System.Drawing.Point(696, 159);
            assessmentLabel.Name = "assessmentLabel";
            assessmentLabel.Size = new System.Drawing.Size(66, 13);
            assessmentLabel.TabIndex = 10;
            assessmentLabel.Text = "Assessment:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 359);
            this.dataGridView1.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(775, 134);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(775, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(774, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(774, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(218, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(775, 47);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(218, 20);
            this.textBox5.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 24);
            this.button1.TabIndex = 19;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(775, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 20);
            this.textBox2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(696, 109);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 13);
            label1.TabIndex = 21;
            label1.Text = "Subject ID:";
            // 
            // Assessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 395);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(pupilsIDLabel);
            this.Controls.Add(subjectIDLabel);
            this.Controls.Add(attendanceLabel);
            this.Controls.Add(assessmentLabel);
            this.Name = "Assessments";
            this.Text = "Assessments";
            this.Load += new System.EventHandler(this.Assessments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assessmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private schoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource assessmentsBindingSource;
        private schoolDataSetTableAdapters.AssessmentsTableAdapter assessmentsTableAdapter;
        private schoolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}