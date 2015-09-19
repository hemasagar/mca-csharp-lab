/* 
 * FileName: Form3.Designer.cs
 * Author:  Hemasagar
 * Course:  MCA
 * College: Bangalore Institute Of Technology
 * Email:   toktok420@gmail.com
 */
namespace mca_partb_02
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
            this.customResultRadio = new System.Windows.Forms.RadioButton();
            this.genderRadio = new System.Windows.Forms.RadioButton();
            this.bloodGroupRadio = new System.Windows.Forms.RadioButton();
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
            this.label1.Location = new System.Drawing.Point(317, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Bank Details Display";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customResultRadio);
            this.panel1.Controls.Add(this.genderRadio);
            this.panel1.Controls.Add(this.bloodGroupRadio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(183, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 66);
            this.panel1.TabIndex = 1;
            // 
            // customResultRadio
            // 
            this.customResultRadio.AutoSize = true;
            this.customResultRadio.Location = new System.Drawing.Point(314, 37);
            this.customResultRadio.Name = "customResultRadio";
            this.customResultRadio.Size = new System.Drawing.Size(201, 17);
            this.customResultRadio.TabIndex = 3;
            this.customResultRadio.Text = "Age >18 ,weight > 45 Kg and Gender";
            this.customResultRadio.UseVisualStyleBackColor = true;
            // 
            // genderRadio
            // 
            this.genderRadio.AutoSize = true;
            this.genderRadio.Location = new System.Drawing.Point(218, 37);
            this.genderRadio.Name = "genderRadio";
            this.genderRadio.Size = new System.Drawing.Size(60, 17);
            this.genderRadio.TabIndex = 2;
            this.genderRadio.Text = "Gender";
            this.genderRadio.UseVisualStyleBackColor = true;
            // 
            // bloodGroupRadio
            // 
            this.bloodGroupRadio.AutoSize = true;
            this.bloodGroupRadio.Location = new System.Drawing.Point(94, 37);
            this.bloodGroupRadio.Name = "bloodGroupRadio";
            this.bloodGroupRadio.Size = new System.Drawing.Size(84, 17);
            this.bloodGroupRadio.TabIndex = 1;
            this.bloodGroupRadio.Text = "Blood Group";
            this.bloodGroupRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select based on which to display result.\r\n";
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.detailsListBox);
            this.detailsPanel.Controls.Add(this.label3);
            this.detailsPanel.Location = new System.Drawing.Point(30, 123);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(153, 258);
            this.detailsPanel.TabIndex = 2;
            // 
            // detailsListBox
            // 
            this.detailsListBox.FormattingEnabled = true;
            this.detailsListBox.Location = new System.Drawing.Point(15, 37);
            this.detailsListBox.Name = "detailsListBox";
            this.detailsListBox.Size = new System.Drawing.Size(120, 212);
            this.detailsListBox.TabIndex = 1;
            this.detailsListBox.SelectedIndexChanged += new System.EventHandler(this.detailsListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select from below list";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(189, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 212);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 504);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form3";
            this.Text = ".Net Lab part-B 02";
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
        private System.Windows.Forms.RadioButton customResultRadio;
        private System.Windows.Forms.RadioButton genderRadio;
        private System.Windows.Forms.RadioButton bloodGroupRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.ListBox detailsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}