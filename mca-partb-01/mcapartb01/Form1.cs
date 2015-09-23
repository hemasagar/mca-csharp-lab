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

namespace mcapartb01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.MaximizeBox = false;   //Little cosmetic changes to prevent user from maximizing, alternatively can be done in properties window too.
            //this.MinimizeBox = true;
            this.ControlBox = false;      //This property overrides the above no controlbox is displayed at all.  
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (addRadio.Checked)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
                form2.FormClosed += new FormClosedEventHandler(childFormClosed); //Used to detect when the another form is closed.
            }
            else if (displayRadio.Checked)
            {
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
                form3.FormClosed += new FormClosedEventHandler(childFormClosed);
            }
            else
            {
                MessageBox.Show("Please Select an Operation", "Error!");
            }
        }

        //When child form is closed again open parent form.
        void childFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
