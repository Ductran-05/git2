using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum;
            sum = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            MessageBox.Show("Sum = " + sum.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close ?", "Demo Form",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (!char.IsDigit(control.Text[control.Text.Length - 1]))
            {
                this.errorProvider1.SetError(control, "This is not a valid number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
