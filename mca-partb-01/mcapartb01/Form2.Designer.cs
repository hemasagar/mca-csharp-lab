/* 
 * FileName: Form2.Designer.cs
 * Author:  Hemasagar
 * email:   toktok420@gmail.com
 */
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
            this.courseTabCancelBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.courseTabSubmitBtn = new System.Windows.Forms.Button();
            this.CourseNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CourseID1Txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.studentPanelCancelBtn = new System.Windows.Forms.Button();
            this.studentTabSubmitBtn = new System.Windows.Forms.Button();
            this.YrOfAdmsnTxt = new System.Windows.Forms.TextBox();
            this.CourseID2Txt = new System.Windows.Forms.TextBox();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.StudNameTxt = new System.Windows.Forms.TextBox();
            this.USNTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add details";
            // 
            // courseTabCancelBtn
            // 
            this.courseTabCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTabCancelBtn.Location = new System.Drawing.Point(285, 200);
            this.courseTabCancelBtn.Name = "courseTabCancelBtn";
            this.courseTabCancelBtn.Size = new System.Drawing.Size(81, 32);
            this.courseTabCancelBtn.TabIndex = 6;
            this.courseTabCancelBtn.Text = "Reset";
            this.courseTabCancelBtn.UseVisualStyleBackColor = true;
            this.courseTabCancelBtn.Click += new System.EventHandler(this.courseTabResetBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter the Course details";
            // 
            // courseTabSubmitBtn
            // 
            this.courseTabSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTabSubmitBtn.Location = new System.Drawing.Point(183, 202);
            this.courseTabSubmitBtn.Name = "courseTabSubmitBtn";
            this.courseTabSubmitBtn.Size = new System.Drawing.Size(81, 32);
            this.courseTabSubmitBtn.TabIndex = 4;
            this.courseTabSubmitBtn.Text = "Submit";
            this.courseTabSubmitBtn.UseVisualStyleBackColor = true;
            this.courseTabSubmitBtn.Click += new System.EventHandler(this.courseTabSubmitBtn_Click);
            // 
            // CourseNameTxt
            // 
            this.CourseNameTxt.Location = new System.Drawing.Point(196, 142);
            this.CourseNameTxt.Name = "CourseNameTxt";
            this.CourseNameTxt.Size = new System.Drawing.Size(177, 20);
            this.CourseNameTxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Course Name";
            // 
            // CourseID1Txt
            // 
            this.CourseID1Txt.Location = new System.Drawing.Point(193, 80);
            this.CourseID1Txt.Name = "CourseID1Txt";
            this.CourseID1Txt.Size = new System.Drawing.Size(180, 20);
            this.CourseID1Txt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 405);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.courseTabCancelBtn);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.courseTabSubmitBtn);
            this.tabPage1.Controls.Add(this.CourseID1Txt);
            this.tabPage1.Controls.Add(this.CourseNameTxt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(487, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Course";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.studentPanelCancelBtn);
            this.tabPage2.Controls.Add(this.studentTabSubmitBtn);
            this.tabPage2.Controls.Add(this.YrOfAdmsnTxt);
            this.tabPage2.Controls.Add(this.CourseID2Txt);
            this.tabPage2.Controls.Add(this.AddressTxt);
            this.tabPage2.Controls.Add(this.StudNameTxt);
            this.tabPage2.Controls.Add(this.USNTxt);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(487, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Student";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Enter the student details";
            // 
            // studentPanelCancelBtn
            // 
            this.studentPanelCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPanelCancelBtn.Location = new System.Drawing.Point(266, 340);
            this.studentPanelCancelBtn.Name = "studentPanelCancelBtn";
            this.studentPanelCancelBtn.Size = new System.Drawing.Size(75, 37);
            this.studentPanelCancelBtn.TabIndex = 25;
            this.studentPanelCancelBtn.Text = "Reset";
            this.studentPanelCancelBtn.UseVisualStyleBackColor = true;
            this.studentPanelCancelBtn.Click += new System.EventHandler(this.studentTabCancelBtn_Click);
            // 
            // studentTabSubmitBtn
            // 
            this.studentTabSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentTabSubmitBtn.Location = new System.Drawing.Point(145, 340);
            this.studentTabSubmitBtn.Name = "studentTabSubmitBtn";
            this.studentTabSubmitBtn.Size = new System.Drawing.Size(75, 37);
            this.studentTabSubmitBtn.TabIndex = 24;
            this.studentTabSubmitBtn.Text = "Submit";
            this.studentTabSubmitBtn.UseVisualStyleBackColor = true;
            this.studentTabSubmitBtn.Click += new System.EventHandler(this.studentTabSubmitBtn_Click);
            // 
            // YrOfAdmsnTxt
            // 
            this.YrOfAdmsnTxt.Location = new System.Drawing.Point(209, 289);
            this.YrOfAdmsnTxt.Name = "YrOfAdmsnTxt";
            this.YrOfAdmsnTxt.Size = new System.Drawing.Size(177, 20);
            this.YrOfAdmsnTxt.TabIndex = 23;
            // 
            // CourseID2Txt
            // 
            this.CourseID2Txt.Location = new System.Drawing.Point(209, 235);
            this.CourseID2Txt.Name = "CourseID2Txt";
            this.CourseID2Txt.Size = new System.Drawing.Size(177, 20);
            this.CourseID2Txt.TabIndex = 22;
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(209, 164);
            this.AddressTxt.Multiline = true;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(177, 43);
            this.AddressTxt.TabIndex = 21;
            // 
            // StudNameTxt
            // 
            this.StudNameTxt.Location = new System.Drawing.Point(209, 115);
            this.StudNameTxt.Name = "StudNameTxt";
            this.StudNameTxt.Size = new System.Drawing.Size(177, 20);
            this.StudNameTxt.TabIndex = 20;
            // 
            // USNTxt
            // 
            this.USNTxt.Location = new System.Drawing.Point(209, 71);
            this.USNTxt.Name = "USNTxt";
            this.USNTxt.Size = new System.Drawing.Size(177, 20);
            this.USNTxt.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(83, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Admission Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Course ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(83, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "USN";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 465);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = ".Net Lab Part-B 01";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button courseTabSubmitBtn;
        private System.Windows.Forms.TextBox CourseNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CourseID1Txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button courseTabCancelBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button studentPanelCancelBtn;
        private System.Windows.Forms.Button studentTabSubmitBtn;
        private System.Windows.Forms.TextBox YrOfAdmsnTxt;
        private System.Windows.Forms.TextBox CourseID2Txt;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.TextBox StudNameTxt;
        private System.Windows.Forms.TextBox USNTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}