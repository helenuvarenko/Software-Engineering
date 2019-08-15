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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Fenwick_Tree f;

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (b <= a) MessageBox.Show("a must be < b");
                else if (b >= f.Count) MessageBox.Show("b must be < f.count");
                else
                    label3.Text = Convert.ToString(f.range_read(f, a, b));
            }
            else MessageBox.Show("Error!");
        }
    }
}
