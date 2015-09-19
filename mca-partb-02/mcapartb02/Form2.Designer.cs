/* 
 * FileName: Form3.Designer.cs
 * Author:  Hemasagar
 * Course:  MCA
 * College: Bangalore Institute Of Technology
 * Email:   toktok420@gmail.com
 */
namespace mca_partb_02
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bloodResetBtn = new System.Windows.Forms.Button();
            this.bloodSubmitBtn = new System.Windows.Forms.Button();
            this.bloodID1Txt = new System.Windows.Forms.TextBox();
            this.bloodGroupTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.donorResetBtn = new System.Windows.Forms.Button();
            this.donorSubmitBtn = new System.Windows.Forms.Button();
            this.bloodID2Txt = new System.Windows.Forms.TextBox();
            this.weightTxt = new System.Windows.Forms.TextBox();
            this.contactTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.donorNameTxt = new System.Windows.Forms.TextBox();
            this.donorIDTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Details";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 507);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.bloodResetBtn);
            this.tabPage1.Controls.Add(this.bloodSubmitBtn);
            this.tabPage1.Controls.Add(this.bloodID1Txt);
            this.tabPage1.Controls.Add(this.bloodGroupTxt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(657, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Blood Group";
            // 
            // bloodResetBtn
            // 
            this.bloodResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodResetBtn.Location = new System.Drawing.Point(342, 152);
            this.bloodResetBtn.Name = "bloodResetBtn";
            this.bloodResetBtn.Size = new System.Drawing.Size(95, 33);
            this.bloodResetBtn.TabIndex = 6;
            this.bloodResetBtn.Text = "Reset";
            this.bloodResetBtn.UseVisualStyleBackColor = true;
            this.bloodResetBtn.Click += new System.EventHandler(this.bloodResetBtn_Click);
            // 
            // bloodSubmitBtn
            // 
            this.bloodSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodSubmitBtn.Location = new System.Drawing.Point(223, 153);
            this.bloodSubmitBtn.Name = "bloodSubmitBtn";
            this.bloodSubmitBtn.Size = new System.Drawing.Size(95, 33);
            this.bloodSubmitBtn.TabIndex = 5;
            this.bloodSubmitBtn.Text = "Submit";
            this.bloodSubmitBtn.UseVisualStyleBackColor = true;
            this.bloodSubmitBtn.Click += new System.EventHandler(this.bloodSubmitBtn_Click);
            // 
            // bloodID1Txt
            // 
            this.bloodID1Txt.Location = new System.Drawing.Point(291, 37);
            this.bloodID1Txt.Name = "bloodID1Txt";
            this.bloodID1Txt.Size = new System.Drawing.Size(189, 20);
            this.bloodID1Txt.TabIndex = 4;
            // 
            // bloodGroupTxt
            // 
            this.bloodGroupTxt.Location = new System.Drawing.Point(291, 99);
            this.bloodGroupTxt.Name = "bloodGroupTxt";
            this.bloodGroupTxt.Size = new System.Drawing.Size(189, 20);
            this.bloodGroupTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blood ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Blood Group";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.femaleRadio);
            this.tabPage2.Controls.Add(this.maleRadio);
            this.tabPage2.Controls.Add(this.dobPicker);
            this.tabPage2.Controls.Add(this.donorResetBtn);
            this.tabPage2.Controls.Add(this.donorSubmitBtn);
            this.tabPage2.Controls.Add(this.bloodID2Txt);
            this.tabPage2.Controls.Add(this.weightTxt);
            this.tabPage2.Controls.Add(this.contactTxt);
            this.tabPage2.Controls.Add(this.addressTxt);
            this.tabPage2.Controls.Add(this.donorNameTxt);
            this.tabPage2.Controls.Add(this.donorIDTxt);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(657, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Donor ";
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadio.Location = new System.Drawing.Point(399, 307);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(67, 19);
            this.femaleRadio.TabIndex = 18;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadio.Location = new System.Drawing.Point(310, 307);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(53, 19);
            this.maleRadio.TabIndex = 17;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // dobPicker
            // 
            this.dobPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobPicker.Location = new System.Drawing.Point(296, 260);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(208, 21);
            this.dobPicker.TabIndex = 12;
            // 
            // donorResetBtn
            // 
            this.donorResetBtn.Location = new System.Drawing.Point(355, 432);
            this.donorResetBtn.Name = "donorResetBtn";
            this.donorResetBtn.Size = new System.Drawing.Size(96, 38);
            this.donorResetBtn.TabIndex = 16;
            this.donorResetBtn.Text = "Reset";
            this.donorResetBtn.UseVisualStyleBackColor = true;
            this.donorResetBtn.Click += new System.EventHandler(this.donorResetBtn_Click);
            // 
            // donorSubmitBtn
            // 
            this.donorSubmitBtn.Location = new System.Drawing.Point(206, 432);
            this.donorSubmitBtn.Name = "donorSubmitBtn";
            this.donorSubmitBtn.Size = new System.Drawing.Size(96, 38);
            this.donorSubmitBtn.TabIndex = 15;
            this.donorSubmitBtn.Text = "Submit";
            this.donorSubmitBtn.UseVisualStyleBackColor = true;
            this.donorSubmitBtn.Click += new System.EventHandler(this.donorSubmitBtn_Click);
            // 
            // bloodID2Txt
            // 
            this.bloodID2Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodID2Txt.Location = new System.Drawing.Point(296, 387);
            this.bloodID2Txt.Name = "bloodID2Txt";
            this.bloodID2Txt.Size = new System.Drawing.Size(208, 21);
            this.bloodID2Txt.TabIndex = 14;
            // 
            // weightTxt
            // 
            this.weightTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTxt.Location = new System.Drawing.Point(296, 341);
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.Size = new System.Drawing.Size(208, 21);
            this.weightTxt.TabIndex = 13;
            // 
            // contactTxt
            // 
            this.contactTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTxt.Location = new System.Drawing.Point(296, 205);
            this.contactTxt.Name = "contactTxt";
            this.contactTxt.Size = new System.Drawing.Size(208, 21);
            this.contactTxt.TabIndex = 11;
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.Location = new System.Drawing.Point(296, 122);
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(208, 63);
            this.addressTxt.TabIndex = 10;
            // 
            // donorNameTxt
            // 
            this.donorNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorNameTxt.Location = new System.Drawing.Point(296, 80);
            this.donorNameTxt.Name = "donorNameTxt";
            this.donorNameTxt.Size = new System.Drawing.Size(208, 21);
            this.donorNameTxt.TabIndex = 9;
            // 
            // donorIDTxt
            // 
            this.donorIDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorIDTxt.Location = new System.Drawing.Point(296, 29);
            this.donorIDTxt.Name = "donorIDTxt";
            this.donorIDTxt.Size = new System.Drawing.Size(208, 21);
            this.donorIDTxt.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(174, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Blood ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(174, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Weight";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(174, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Date of birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Donor Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Donor ID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 578);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = ".Net Lab part-B 02";
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bloodResetBtn;
        private System.Windows.Forms.Button bloodSubmitBtn;
        private System.Windows.Forms.TextBox bloodID1Txt;
        private System.Windows.Forms.TextBox bloodGroupTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button donorResetBtn;
        private System.Windows.Forms.Button donorSubmitBtn;
        private System.Windows.Forms.TextBox bloodID2Txt;
        private System.Windows.Forms.TextBox weightTxt;
        private System.Windows.Forms.TextBox contactTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox donorNameTxt;
        private System.Windows.Forms.TextBox donorIDTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
    }
}