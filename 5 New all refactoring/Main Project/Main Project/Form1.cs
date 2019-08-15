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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Bitmap b;

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bitmap(500, 500);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
        }

        Tree t;
        private void button4_Click(object sender, EventArgs e)//кнопка створити
        {
            bool b = false;
            foreach (char c in textBox1.Text)
            {
                if (!char.IsDigit(c) && c != ' ')
                {
                    b = true;
                    break;
                }
            }
            if (textBox1.Text == "" || b)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                string[] ss = textBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] a = new int[ss.Length];
                int i = 0;
                foreach (string s in ss)
                {
                    if (!int.TryParse(s, out a[i])) MessageBox.Show("Error!");
                    i++;
                }
                t = new Tree(a);

                Refr();
            }
        }
        public void Refr()
        {
            int m = 250 / t.Count;
            g.Clear(Color.FromArgb(0, 0, 0, 0));
            for (int i = t.Count - 1; i > 0; i--)
            {
                g.DrawString(i.ToString(), new Font(FontFamily.Families[15], 15), Brushes.Black, 0, i * m);
                g.DrawString(t.ToString(), new Font(FontFamily.Families[15], 15), Brushes.Black, m, i * m);
                if (i != 0)
                    g.FillRectangle(Brushes.Green, 100 + i * 25, (i - (i & -i) + 1) * m, 20, i * m + 25 - (i - (i & -i) + 1) * m);
            }
            pictureBox1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//сума,індекс
        {
            Form2 f2 = new Form2();
            f2.form = this;
            f2.t = t;

            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)//сума на відрізку
        {
            Form3 f3 = new Form3();
            f3.t = t;
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Заповніть поле числами, розділяючи їх пробілом." +
                " \n\n Натисніть на кнопку 'Створити', щоб створити дерево з відповідними вершинами." +
                " \n\n Натисніть на пункт 'Сума, індекс', щоб вивести діалогове вікно розрахунків. " +
                "\n\n Натисність на пункт 'Сума на відрізку', щоб вивести діалогове вікно розрахунків суми на відрізку.",
                "Допомога");

        }
    } 
}
