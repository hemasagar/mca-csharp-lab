/* 
 * FileName: Form3.Designer.cs
 * Author:  Hemasagar
 * Course:  MCA
 * College: Bangalore Institute Of Technology
 * Email:   toktok420@gmail.com
 */
namespace mcapartb01
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yrOfAdmsnRadio = new System.Windows.Forms.RadioButton();
            this.courseRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.detailsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Details Display";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yrOfAdmsnRadio);
            this.panel1.Controls.Add(this.courseRadio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(86, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 81);
            this.panel1.TabIndex = 1;
            // 
            // yrOfAdmsnRadio
            // 
            this.yrOfAdmsnRadio.AutoSize = true;
            this.yrOfAdmsnRadio.Location = new System.Drawing.Point(400, 47);
            this.yrOfAdmsnRadio.Name = "yrOfAdmsnRadio";
            this.yrOfAdmsnRadio.Size = new System.Drawing.Size(108, 17);
            this.yrOfAdmsnRadio.TabIndex = 2;
            this.yrOfAdmsnRadio.Text = "Year of admission";
            this.yrOfAdmsnRadio.UseVisualStyleBackColor = true;
            // 
            // courseRadio
            // 
            this.courseRadio.AutoSize = true;
            this.courseRadio.Location = new System.Drawing.Point(157, 47);
            this.courseRadio.Name = "courseRadio";
            this.courseRadio.Size = new System.Drawing.Size(91, 17);
            this.courseRadio.TabIndex = 1;
            this.courseRadio.Text = "Course Based";
            this.courseRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select the criteria based on which to display details";
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.detailsListBox);
            this.detailsPanel.Controls.Add(this.label3);
            this.detailsPanel.Location = new System.Drawing.Point(12, 152);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(200, 349);
            this.detailsPanel.TabIndex = 2;
            // 
            // detailsListBox
            // 
            this.detailsListBox.FormattingEnabled = true;
            this.detailsListBox.Location = new System.Drawing.Point(15, 37);
            this.detailsListBox.Name = "detailsListBox";
            this.detailsListBox.Size = new System.Drawing.Size(167, 303);
            this.detailsListBox.TabIndex = 4;
            this.detailsListBox.SelectedIndexChanged += new System.EventHandler(this.detailsListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select from the below list";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 303);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 513);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = ".Net Lab Part-B 01";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton courseRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton yrOfAdmsnRadio;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox detailsListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}