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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Tree t;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
            {
                if (b <= a) MessageBox.Show("Перший індекс має бути меншим за другий");
                else if (b >= t.Count) MessageBox.Show("Другий індекс має бути меншим за кількість елементів масиву");
                else
                    label3.Text = Convert.ToString(t.range_read(t, a, b));
            }
            else MessageBox.Show("Введіть усі значення для індексів!");
        }
    }
}
