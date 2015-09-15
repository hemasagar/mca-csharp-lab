namespace mcapartb01
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.addCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courseAddPanel = new System.Windows.Forms.Panel();
            this.coursePanelCancelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.coursePanelSubmitBtn = new System.Windows.Forms.Button();
            this.CourseName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CourseID1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentAddPanel = new System.Windows.Forms.Panel();
            this.studentPanelCancelBtn = new System.Windows.Forms.Button();
            this.studentPanelSubmitBtn = new System.Windows.Forms.Button();
            this.YrOfAdmin = new System.Windows.Forms.TextBox();
            this.CourseID2 = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.StudName = new System.Windows.Forms.TextBox();
            this.USN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.courseAddPanel.SuspendLayout();
            this.studentAddPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add details";
            // 
            // addCombo
            // 
            this.addCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCombo.FormattingEnabled = true;
            this.addCombo.Items.AddRange(new object[] {
            "New Course",
            "New Student"});
            this.addCombo.Location = new System.Drawing.Point(236, 72);
            this.addCombo.Name = "addCombo";
            this.addCombo.Size = new System.Drawing.Size(121, 21);
            this.addCombo.TabIndex = 1;
            this.addCombo.SelectedIndexChanged += new System.EventHandler(this.addCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Select";
            // 
            // courseAddPanel
            // 
            this.courseAddPanel.Controls.Add(this.coursePanelCancelBtn);
            this.courseAddPanel.Controls.Add(this.label5);
            this.courseAddPanel.Controls.Add(this.coursePanelSubmitBtn);
            this.courseAddPanel.Controls.Add(this.CourseName);
            this.courseAddPanel.Controls.Add(this.label4);
            this.courseAddPanel.Controls.Add(this.CourseID1);
            this.courseAddPanel.Controls.Add(this.label3);
            this.courseAddPanel.Location = new System.Drawing.Point(12, 118);
            this.courseAddPanel.Name = "courseAddPanel";
            this.courseAddPanel.Size = new System.Drawing.Size(549, 261);
            this.courseAddPanel.TabIndex = 3;
            // 
            // coursePanelCancelBtn
            // 
            this.coursePanelCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursePanelCancelBtn.Location = new System.Drawing.Point(308, 204);
            this.coursePanelCancelBtn.Name = "coursePanelCancelBtn";
            this.coursePanelCancelBtn.Size = new System.Drawing.Size(81, 32);
            this.coursePanelCancelBtn.TabIndex = 6;
            this.coursePanelCancelBtn.Text = "Cancel";
            this.coursePanelCancelBtn.UseVisualStyleBackColor = true;
            this.coursePanelCancelBtn.Click += new System.EventHandler(this.coursePanelCancelBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter the Course details";
            // 
            // coursePanelSubmitBtn
            // 
            this.coursePanelSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursePanelSubmitBtn.Location = new System.Drawing.Point(206, 206);
            this.coursePanelSubmitBtn.Name = "coursePanelSubmitBtn";
            this.coursePanelSubmitBtn.Size = new System.Drawing.Size(81, 32);
            this.coursePanelSubmitBtn.TabIndex = 4;
            this.coursePanelSubmitBtn.Text = "Submit";
            this.coursePanelSubmitBtn.UseVisualStyleBackColor = true;
            this.coursePanelSubmitBtn.Click += new System.EventHandler(this.coursePanelSubmitBtn_Click);
            // 
            // CourseName
            // 
            this.CourseName.Location = new System.Drawing.Point(206, 146);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(177, 20);
            this.CourseName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Course Name";
            // 
            // CourseID1
            // 
            this.CourseID1.Location = new System.Drawing.Point(203, 84);
            this.CourseID1.Name = "CourseID1";
            this.CourseID1.Size = new System.Drawing.Size(180, 20);
            this.CourseID1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course ID";
            // 
            // studentAddPanel
            // 
            this.studentAddPanel.Controls.Add(this.studentPanelCancelBtn);
            this.studentAddPanel.Controls.Add(this.studentPanelSubmitBtn);
            this.studentAddPanel.Controls.Add(this.YrOfAdmin);
            this.studentAddPanel.Controls.Add(this.CourseID2);
            this.studentAddPanel.Controls.Add(this.Address);
            this.studentAddPanel.Controls.Add(this.StudName);
            this.studentAddPanel.Controls.Add(this.USN);
            this.studentAddPanel.Controls.Add(this.label11);
            this.studentAddPanel.Controls.Add(this.label10);
            this.studentAddPanel.Controls.Add(this.label9);
            this.studentAddPanel.Controls.Add(this.label8);
            this.studentAddPanel.Controls.Add(this.label7);
            this.studentAddPanel.Controls.Add(this.label6);
            this.studentAddPanel.Location = new System.Drawing.Point(15, 109);
            this.studentAddPanel.Name = "studentAddPanel";
            this.studentAddPanel.Size = new System.Drawing.Size(543, 406);
            this.studentAddPanel.TabIndex = 7;
            // 
            // studentPanelCancelBtn
            // 
            this.studentPanelCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPanelCancelBtn.Location = new System.Drawing.Point(323, 359);
            this.studentPanelCancelBtn.Name = "studentPanelCancelBtn";
            this.studentPanelCancelBtn.Size = new System.Drawing.Size(75, 37);
            this.studentPanelCancelBtn.TabIndex = 12;
            this.studentPanelCancelBtn.Text = "Cancel";
            this.studentPanelCancelBtn.UseVisualStyleBackColor = true;
            this.studentPanelCancelBtn.Click += new System.EventHandler(this.studentPanelCancelBtn_Click);
            // 
            // studentPanelSubmitBtn
            // 
            this.studentPanelSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPanelSubmitBtn.Location = new System.Drawing.Point(166, 359);
            this.studentPanelSubmitBtn.Name = "studentPanelSubmitBtn";
            this.studentPanelSubmitBtn.Size = new System.Drawing.Size(75, 37);
            this.studentPanelSubmitBtn.TabIndex = 11;
            this.studentPanelSubmitBtn.Text = "Submit";
            this.studentPanelSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // YrOfAdmin
            // 
            this.YrOfAdmin.Location = new System.Drawing.Point(203, 308);
            this.YrOfAdmin.Name = "YrOfAdmin";
            this.YrOfAdmin.Size = new System.Drawing.Size(177, 20);
            this.YrOfAdmin.TabIndex = 10;
            // 
            // CourseID2
            // 
            this.CourseID2.Location = new System.Drawing.Point(203, 254);
            this.CourseID2.Name = "CourseID2";
            this.CourseID2.Size = new System.Drawing.Size(177, 20);
            this.CourseID2.TabIndex = 9;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(203, 183);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(177, 43);
            this.Address.TabIndex = 8;
            // 
            // StudName
            // 
            this.StudName.Location = new System.Drawing.Point(203, 134);
            this.StudName.Name = "StudName";
            this.StudName.Size = new System.Drawing.Size(177, 20);
            this.StudName.TabIndex = 7;
            // 
            // USN
            // 
            this.USN.Location = new System.Drawing.Point(203, 90);
            this.USN.Name = "USN";
            this.USN.Size = new System.Drawing.Size(177, 20);
            this.USN.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(77, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Admission Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Course";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "USN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter the student details";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseAddPanel);
            this.Controls.Add(this.studentAddPanel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.courseAddPanel.ResumeLayout(false);
            this.courseAddPanel.PerformLayout();
            this.studentAddPanel.ResumeLayout(false);
            this.studentAddPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel courseAddPanel;
        private System.Windows.Forms.Button coursePanelSubmitBtn;
        private System.Windows.Forms.TextBox CourseName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CourseID1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button coursePanelCancelBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel studentAddPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox YrOfAdmin;
        private System.Windows.Forms.TextBox CourseID2;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox StudName;
        private System.Windows.Forms.TextBox USN;
        private System.Windows.Forms.Button studentPanelCancelBtn;
        private System.Windows.Forms.Button studentPanelSubmitBtn;
    }
}