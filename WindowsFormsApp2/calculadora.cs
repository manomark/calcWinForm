using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_val2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double val1, val2, res;
            val1 = double.Parse(txtbox_val1.Text);
            val2 = double.Parse(txtbox_val2.Text);
            res = val1 - val2;
            txt_resul.Text = res.ToString();
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            double val1, val2, res;
            val1 = double.Parse(txtbox_val1.Text);
            val2 = double.Parse(txtbox_val2.Text);
            res = val1 + val2;
            txt_resul.Text = res.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            double val1, val2, res;
            val1 = double.Parse(txtbox_val1.Text);
            val2 = double.Parse(txtbox_val2.Text);
            res = val1 / val2;
            txt_resul.Text = res.ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            double val1, val2, res;
            val1 = double.Parse(txtbox_val1.Text);
            val2 = double.Parse(txtbox_val2.Text);
            res = val1 * val2;
            txt_resul.Text = res.ToString();
        }

        private void txtbox_val2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            double val1, val2, res;
            txtbox_val1.Text = "";
            txtbox_val2.Text = "";
            txt_resul.Text = "";
        }
    }
}
