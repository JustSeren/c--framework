namespace BeforeExamApp
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlist1 = new System.Windows.Forms.Button();
            this.btnlist2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnListStndtNotes = new System.Windows.Forms.Button();
            this.btnListStudents = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBtnAboveAvg = new System.Windows.Forms.RadioButton();
            this.rBtnMin = new System.Windows.Forms.RadioButton();
            this.rBtnMax = new System.Windows.Forms.RadioButton();
            this.rBtnAvg = new System.Windows.Forms.RadioButton();
            this.rBtnSum = new System.Windows.Forms.RadioButton();
            this.rBtnCount = new System.Windows.Forms.RadioButton();
            this.rBtnContain = new System.Windows.Forms.RadioButton();
            this.rBtnEnd = new System.Windows.Forms.RadioButton();
            this.rBtnstrt = new System.Windows.Forms.RadioButton();
            this.rBtnFrst = new System.Windows.Forms.RadioButton();
            this.rBtnslctID = new System.Windows.Forms.RadioButton();
            this.rBtnZtoA = new System.Windows.Forms.RadioButton();
            this.rBtnList = new System.Windows.Forms.Button();
            this.rBtnAtoZ = new System.Windows.Forms.RadioButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnlist1
            // 
            this.btnlist1.Location = new System.Drawing.Point(13, 255);
            this.btnlist1.Name = "btnlist1";
            this.btnlist1.Size = new System.Drawing.Size(164, 55);
            this.btnlist1.TabIndex = 1;
            this.btnlist1.Text = "list old";
            this.btnlist1.UseVisualStyleBackColor = true;
            this.btnlist1.Click += new System.EventHandler(this.btnlist1_Click);
            // 
            // btnlist2
            // 
            this.btnlist2.Location = new System.Drawing.Point(608, 264);
            this.btnlist2.Name = "btnlist2";
            this.btnlist2.Size = new System.Drawing.Size(164, 55);
            this.btnlist2.TabIndex = 2;
            this.btnlist2.Text = "list new";
            this.btnlist2.UseVisualStyleBackColor = true;
            this.btnlist2.Click += new System.EventHandler(this.btnlist2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(0, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 562);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnRemoveStudent);
            this.groupBox2.Controls.Add(this.btnListStndtNotes);
            this.groupBox2.Controls.Add(this.btnListStudents);
            this.groupBox2.Controls.Add(this.btnAddStudent);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtLastname);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightCoral;
            this.btnUpdate.Location = new System.Drawing.Point(19, 248);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 39);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.BackColor = System.Drawing.Color.LightCoral;
            this.btnRemoveStudent.Location = new System.Drawing.Point(19, 203);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(195, 39);
            this.btnRemoveStudent.TabIndex = 10;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = false;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnListStndtNotes
            // 
            this.btnListStndtNotes.Location = new System.Drawing.Point(290, 44);
            this.btnListStndtNotes.Name = "btnListStndtNotes";
            this.btnListStndtNotes.Size = new System.Drawing.Size(152, 22);
            this.btnListStndtNotes.TabIndex = 9;
            this.btnListStndtNotes.Text = "List Students Notes";
            this.btnListStndtNotes.UseVisualStyleBackColor = true;
            this.btnListStndtNotes.Click += new System.EventHandler(this.btnListStndtNotes_Click);
            // 
            // btnListStudents
            // 
            this.btnListStudents.Location = new System.Drawing.Point(290, 15);
            this.btnListStudents.Name = "btnListStudents";
            this.btnListStudents.Size = new System.Drawing.Size(152, 23);
            this.btnListStudents.TabIndex = 8;
            this.btnListStudents.Text = "List Students";
            this.btnListStudents.UseVisualStyleBackColor = true;
            this.btnListStudents.Click += new System.EventHandler(this.btnListStudents_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddStudent.Location = new System.Drawing.Point(19, 158);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(195, 39);
            this.btnAddStudent.TabIndex = 7;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(114, 107);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 6;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(114, 79);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 22);
            this.txtLastname.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(114, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "PHONE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "LASTNAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(766, 221);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rBtnAboveAvg);
            this.groupBox3.Controls.Add(this.rBtnMin);
            this.groupBox3.Controls.Add(this.rBtnMax);
            this.groupBox3.Controls.Add(this.rBtnAvg);
            this.groupBox3.Controls.Add(this.rBtnSum);
            this.groupBox3.Controls.Add(this.rBtnCount);
            this.groupBox3.Controls.Add(this.rBtnContain);
            this.groupBox3.Controls.Add(this.rBtnEnd);
            this.groupBox3.Controls.Add(this.rBtnstrt);
            this.groupBox3.Controls.Add(this.rBtnFrst);
            this.groupBox3.Controls.Add(this.rBtnslctID);
            this.groupBox3.Controls.Add(this.rBtnZtoA);
            this.groupBox3.Controls.Add(this.rBtnList);
            this.groupBox3.Controls.Add(this.rBtnAtoZ);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(804, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(780, 709);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sum of Notes";
            // 
            // rBtnAboveAvg
            // 
            this.rBtnAboveAvg.AutoSize = true;
            this.rBtnAboveAvg.Location = new System.Drawing.Point(620, 398);
            this.rBtnAboveAvg.Name = "rBtnAboveAvg";
            this.rBtnAboveAvg.Size = new System.Drawing.Size(134, 20);
            this.rBtnAboveAvg.TabIndex = 14;
            this.rBtnAboveAvg.TabStop = true;
            this.rBtnAboveAvg.Text = "Notes Above Avg";
            this.rBtnAboveAvg.UseVisualStyleBackColor = true;
            // 
            // rBtnMin
            // 
            this.rBtnMin.AutoSize = true;
            this.rBtnMin.Location = new System.Drawing.Point(620, 372);
            this.rBtnMin.Name = "rBtnMin";
            this.rBtnMin.Size = new System.Drawing.Size(81, 20);
            this.rBtnMin.TabIndex = 13;
            this.rBtnMin.TabStop = true;
            this.rBtnMin.Text = "Min Note";
            this.rBtnMin.UseVisualStyleBackColor = true;
            // 
            // rBtnMax
            // 
            this.rBtnMax.AutoSize = true;
            this.rBtnMax.Location = new System.Drawing.Point(620, 346);
            this.rBtnMax.Name = "rBtnMax";
            this.rBtnMax.Size = new System.Drawing.Size(85, 20);
            this.rBtnMax.TabIndex = 12;
            this.rBtnMax.TabStop = true;
            this.rBtnMax.Text = "Max Note";
            this.rBtnMax.UseVisualStyleBackColor = true;
            // 
            // rBtnAvg
            // 
            this.rBtnAvg.AutoSize = true;
            this.rBtnAvg.Location = new System.Drawing.Point(494, 370);
            this.rBtnAvg.Name = "rBtnAvg";
            this.rBtnAvg.Size = new System.Drawing.Size(105, 20);
            this.rBtnAvg.TabIndex = 11;
            this.rBtnAvg.TabStop = true;
            this.rBtnAvg.Text = "Avg of Notes";
            this.rBtnAvg.UseVisualStyleBackColor = true;
            // 
            // rBtnSum
            // 
            this.rBtnSum.AutoSize = true;
            this.rBtnSum.Location = new System.Drawing.Point(494, 344);
            this.rBtnSum.Name = "rBtnSum";
            this.rBtnSum.Size = new System.Drawing.Size(108, 20);
            this.rBtnSum.TabIndex = 10;
            this.rBtnSum.TabStop = true;
            this.rBtnSum.Text = "Sum of Notes";
            this.rBtnSum.UseVisualStyleBackColor = true;
            // 
            // rBtnCount
            // 
            this.rBtnCount.AutoSize = true;
            this.rBtnCount.Location = new System.Drawing.Point(398, 372);
            this.rBtnCount.Name = "rBtnCount";
            this.rBtnCount.Size = new System.Drawing.Size(62, 20);
            this.rBtnCount.TabIndex = 9;
            this.rBtnCount.TabStop = true;
            this.rBtnCount.Text = "Count";
            this.rBtnCount.UseVisualStyleBackColor = true;
            // 
            // rBtnContain
            // 
            this.rBtnContain.AutoSize = true;
            this.rBtnContain.Location = new System.Drawing.Point(398, 346);
            this.rBtnContain.Name = "rBtnContain";
            this.rBtnContain.Size = new System.Drawing.Size(80, 20);
            this.rBtnContain.TabIndex = 8;
            this.rBtnContain.TabStop = true;
            this.rBtnContain.Text = "Contains";
            this.rBtnContain.UseVisualStyleBackColor = true;
            // 
            // rBtnEnd
            // 
            this.rBtnEnd.AutoSize = true;
            this.rBtnEnd.Location = new System.Drawing.Point(292, 372);
            this.rBtnEnd.Name = "rBtnEnd";
            this.rBtnEnd.Size = new System.Drawing.Size(81, 20);
            this.rBtnEnd.TabIndex = 7;
            this.rBtnEnd.TabStop = true;
            this.rBtnEnd.Text = "End With";
            this.rBtnEnd.UseVisualStyleBackColor = true;
            // 
            // rBtnstrt
            // 
            this.rBtnstrt.AutoSize = true;
            this.rBtnstrt.Location = new System.Drawing.Point(292, 346);
            this.rBtnstrt.Name = "rBtnstrt";
            this.rBtnstrt.Size = new System.Drawing.Size(84, 20);
            this.rBtnstrt.TabIndex = 6;
            this.rBtnstrt.TabStop = true;
            this.rBtnstrt.Text = "Start With";
            this.rBtnstrt.UseVisualStyleBackColor = true;
            // 
            // rBtnFrst
            // 
            this.rBtnFrst.AutoSize = true;
            this.rBtnFrst.Location = new System.Drawing.Point(155, 372);
            this.rBtnFrst.Name = "rBtnFrst";
            this.rBtnFrst.Size = new System.Drawing.Size(111, 20);
            this.rBtnFrst.TabIndex = 5;
            this.rBtnFrst.TabStop = true;
            this.rBtnFrst.Text = "First 2 Student";
            this.rBtnFrst.UseVisualStyleBackColor = true;
            // 
            // rBtnslctID
            // 
            this.rBtnslctID.AutoSize = true;
            this.rBtnslctID.Location = new System.Drawing.Point(155, 346);
            this.rBtnslctID.Name = "rBtnslctID";
            this.rBtnslctID.Size = new System.Drawing.Size(98, 20);
            this.rBtnslctID.TabIndex = 4;
            this.rBtnslctID.TabStop = true;
            this.rBtnslctID.Text = "Select by id";
            this.rBtnslctID.UseVisualStyleBackColor = true;
            // 
            // rBtnZtoA
            // 
            this.rBtnZtoA.AutoSize = true;
            this.rBtnZtoA.Location = new System.Drawing.Point(23, 370);
            this.rBtnZtoA.Name = "rBtnZtoA";
            this.rBtnZtoA.Size = new System.Drawing.Size(94, 20);
            this.rBtnZtoA.TabIndex = 3;
            this.rBtnZtoA.TabStop = true;
            this.rBtnZtoA.Text = "Order (Z-A)";
            this.rBtnZtoA.UseVisualStyleBackColor = true;
            // 
            // rBtnList
            // 
            this.rBtnList.Location = new System.Drawing.Point(247, 443);
            this.rBtnList.Name = "rBtnList";
            this.rBtnList.Size = new System.Drawing.Size(188, 76);
            this.rBtnList.TabIndex = 2;
            this.rBtnList.Text = "List by Radio Button";
            this.rBtnList.UseVisualStyleBackColor = true;
            this.rBtnList.Click += new System.EventHandler(this.rBtnList_Click);
            // 
            // rBtnAtoZ
            // 
            this.rBtnAtoZ.AutoSize = true;
            this.rBtnAtoZ.Location = new System.Drawing.Point(23, 344);
            this.rBtnAtoZ.Name = "rBtnAtoZ";
            this.rBtnAtoZ.Size = new System.Drawing.Size(94, 20);
            this.rBtnAtoZ.TabIndex = 1;
            this.rBtnAtoZ.TabStop = true;
            this.rBtnAtoZ.Text = "Order (A-Z)";
            this.rBtnAtoZ.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(774, 307);
            this.dataGridView3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 902);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlist2);
            this.Controls.Add(this.btnlist1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlist1;
        private System.Windows.Forms.Button btnlist2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnListStndtNotes;
        private System.Windows.Forms.Button btnListStudents;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button rBtnList;
        private System.Windows.Forms.RadioButton rBtnAtoZ;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.RadioButton rBtnZtoA;
        private System.Windows.Forms.RadioButton rBtnslctID;
        private System.Windows.Forms.RadioButton rBtnContain;
        private System.Windows.Forms.RadioButton rBtnEnd;
        private System.Windows.Forms.RadioButton rBtnstrt;
        private System.Windows.Forms.RadioButton rBtnFrst;
        private System.Windows.Forms.RadioButton rBtnMin;
        private System.Windows.Forms.RadioButton rBtnMax;
        private System.Windows.Forms.RadioButton rBtnAvg;
        private System.Windows.Forms.RadioButton rBtnSum;
        private System.Windows.Forms.RadioButton rBtnCount;
        private System.Windows.Forms.RadioButton rBtnAboveAvg;
    }
}

