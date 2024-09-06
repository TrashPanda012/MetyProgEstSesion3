using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvalAge.models;

namespace EvalAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                lblAnswer.Text = string.Empty;
                int age = Convert.ToUInt16(tbAge.Text);
                Evaluate evalue = new Evaluate();
                lblAnswer.Text = "Tienes " + age + " años. " + evalue.EvalAge(age);
                tbAge.Text = " ";
                tbAge.Focus();
            }
            catch (Exception ex)
            {
                lblAnswer.Text = ex.Message;
            }
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
