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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //addCombo.Text = "Please Select";
            courseAddPanel.Hide();
            studentAddPanel.Hide();
        }

        private void addCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (addCombo.Text == "New Course")
            {
                studentAddPanel.Hide();
                courseAddPanel.Show();
            }
            else if (addCombo.Text == "New Student")
            {
                courseAddPanel.Hide();
                studentAddPanel.Show();
            }
            else
            {
                MessageBox.Show("An Error Occurred Please reselect");
            }
        }

        private void studentPanelCancelBtn_Click(object sender, EventArgs e)
        {
            studentAddPanel.Hide();
            //new Form2().Show();
        }

        private void coursePanelSubmitBtn_Click(object sender, EventArgs e)
        {

        }

        private void coursePanelCancelBtn_Click(object sender, EventArgs e)
        {
            courseAddPanel.Hide();
        }
    }
}
