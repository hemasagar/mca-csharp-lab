/* 
 * FileName: Form1.cs
 * Author:  Hemasagar
 * Course:  MCA
 * College: Bangalore Institute Of Technology
 * Email:   toktok420@gmail.com
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mca_partb_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (addRadio.Checked)
            {
                
                Form2 form2 = new Form2();
                form2.Show();
                form2.FormClosed += new FormClosedEventHandler(childFormClosed); //Used to detect when the another form is closed.
            }
            else if (displayRadio.Checked)
            {
                
                Form3 form3 = new Form3();
                form3.Show();
                form3.FormClosed += new FormClosedEventHandler(childFormClosed);
            }
            else
            {
                MessageBox.Show("Please Select an Operation", "Error!");
            }
        }

        private void childFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
