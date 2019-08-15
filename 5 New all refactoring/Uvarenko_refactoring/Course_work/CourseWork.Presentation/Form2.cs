using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Course_work;
namespace CourseWork.Presentation
{
    public partial class Form2 : Form
    {
        int g;
        public Form2()
        {
            InitializeComponent();
        }
       public Fenwick_Tree f;
       
       
        public Form1 form;
        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(textBox1.Text, out a))
                if(a<0||a>=f.Count) MessageBox.Show("out of range");
                else
                label3.Text = Convert.ToString(f.read(a));
            else MessageBox.Show("Error!");
            
        }
        private void button2_Cursor(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (a < 0 || a >= f.Count) MessageBox.Show("out of range");
                else
                {
                    
                    f.update(a, b);
                }
            }
            else MessageBox.Show("Error!");
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(textBox1.Text, out a))
                if (a < 0 || a >= f.Count) MessageBox.Show("out of range");
                else
                    label4.Text = Convert.ToString(f.actual(a));
            else MessageBox.Show("Error!");
           
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

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            form.Ref();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
