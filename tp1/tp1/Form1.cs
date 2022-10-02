using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtOp1.Text) || string.IsNullOrEmpty(txtOp2.Text))
                MessageBox.Show("attention :zone vide ! ");
            else
            {
                double op1 = Convert.ToDouble(txtOp1.Text);
                double op2 = Convert.ToDouble(txtOp2.Text);
                double res = op1 + op2;
                txtExpression.Text = txtOp1.Text + " + " + txtOp2.Text;
                txtResultat.Text = res.ToString();
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOp1.Text) || string.IsNullOrEmpty(txtOp2.Text))
                MessageBox.Show("attention :zone vide ! ");
            else
            {
                double op1 = Convert.ToDouble(txtOp1.Text);
                double op2 = Convert.ToDouble(txtOp2.Text);
                double res = op1 - op2;
                txtExpression.Text = txtOp1.Text + " - " + txtOp2.Text;
                txtResultat.Text = res.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOp1.Text) || string.IsNullOrEmpty(txtOp2.Text))
                MessageBox.Show("attention :zone vide ! ");
            else
            {
                double op1 = Convert.ToDouble(txtOp1.Text);
                double op2 = Convert.ToDouble(txtOp2.Text);
                double res = op1 * op2;
                txtExpression.Text = txtOp1.Text + " * " + txtOp2.Text;
                txtResultat.Text = res.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOp1.Text) || string.IsNullOrEmpty(txtOp2.Text))
                MessageBox.Show("attention :zone vide ! ");
            else
            {
                double op1 = Convert.ToDouble(txtOp1.Text);
                double op2 = Convert.ToDouble(txtOp2.Text);
                double res = op1 / op2;
                txtExpression.Text = txtOp1.Text + " / " + txtOp2.Text;
                txtResultat.Text = res.ToString();
            }
            if (txtOp2.Text == "0")
            {
                txtResultat.Text = "Erreur";
                MessageBox.Show(" La divison par 0 est impossible ! ");
               

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOp1.Text) || string.IsNullOrEmpty(txtOp2.Text))
                MessageBox.Show("attention : zone vide !!! ");
            else
            {
                double op1 = Convert.ToDouble(txtOp1.Text);
                double op2 = Convert.ToDouble(txtOp2.Text);
                double res = op1 % op2;
                txtExpression.Text = txtOp1.Text + " % " + txtOp2.Text;
                txtResultat.Text = res.ToString();
            }
        }

        private void txtOp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void cmdInitialiser_Click(object sender, EventArgs e)
        {
            txtOp1.Clear();
            txtOp2.Clear(); 
            txtResultat.Clear();
            txtExpression.Clear();
        }
    }
}
