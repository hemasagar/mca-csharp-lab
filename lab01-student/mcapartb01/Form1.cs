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
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
           this.MaximizeBox = false;
           this.MinimizeBox = true;
           //this.CancelButton = false;
            
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
                //this.Close();

                form2.FormClosed += new FormClosedEventHandler(childFormClosed);
            }
            else if (displayRadio.Checked)
            {
                this.Hide();
                Form3 form3 = new Form3();

                form3.Show();
                //this.Close();

                form3.FormClosed += new FormClosedEventHandler(childFormClosed);
            }
            else
            {
                MessageBox.Show("Please Select an Operation", "Error!");
            }
        }

        void childFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
