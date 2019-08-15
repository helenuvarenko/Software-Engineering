using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tree_Class;

namespace Main_Project
{
    public partial class Form2 : Form
    {
        int g;
        public Form2()
        {
            InitializeComponent();
        }

        public Tree t;


        public Form1 form;

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(textBox1.Text, out a))
                if (a < 0 || a >= t.Count) MessageBox.Show("Індекс за межами масиву!");
                else
                    label2.Text = Convert.ToString(t.read(a));
            else MessageBox.Show("Введіть усі значення для індексів!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(textBox1.Text, out a))
                if (a < 0 || a >= t.Count) MessageBox.Show("Індекс за межами масиву!");
                else
                    label3.Text = Convert.ToString(t.actual(a));
            else MessageBox.Show("Введіть усі значення для індексів!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                g = int.Parse(textBox1.Text);
                errorProvider1.SetError(textBox1, "");
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(textBox1, ex.Message);
            }

        }
    }
}
