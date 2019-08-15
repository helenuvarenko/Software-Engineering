using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Course_work;
namespace CourseWork.Presentation
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
          
            b=new Bitmap(500,500);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
    

        }
        Fenwick_Tree f;
        private void button1_Click(object sender, EventArgs e)
        {
            bool b = false;
            foreach (char c in t.Text)
            {
                if (!char.IsDigit(c) && c != ' ')
                {
                    b = true;
                    break;
                }
            }
            if (t.Text == ""||b)
            {
                MessageBox.Show("Error!");
            }
            else
            {
                string[] ss = t.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] a = new int[ss.Length];
                int i = 0;
                foreach (string s in ss)
                {
                   if(!int.TryParse(s, out a[i]))  MessageBox.Show("Error!");
                    i++;
                }
                f = new Fenwick_Tree(a);

                Ref();
            }
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void Ref()
        {
            int m = 250 / f.Count;
            g.Clear(Color.FromArgb(0, 0, 0, 0));
            for (int i = f.Count - 1; i >= 0; i--)
            {
                g.DrawString(i.ToString(), new Font(FontFamily.Families[15], 15), Brushes.Black, 0, i * m);
                g.DrawString(f[i][0].ToString(), new Font(FontFamily.Families[15], 15), Brushes.Black, m, i * m);
                if(i!=0)
                g.FillRectangle(Brushes.Green, 100 + i * 25, (i - (i & -i) + 1) * m,  20, i * m + 25 - (i - (i & -i) + 1) * m);
            }
            pictureBox1.Refresh();
        }


        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void сумаЗмінаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.form = this;
            f2.f = f;
            
            f2.Show();
        }

        private void сумаНаВідрізкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.f = f;
            //f2.txt = t.Text;
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void t_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void допомогаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заповніть поле простими числами, розділяючи їх пробілом. \n\n Натисніть на кнопку Створити дерево щоб створити дерево з відповідними вершинами. \n\n Натисніть на пункт Сума, зміна, щоб вивести діалогове вікно розрахунків. \n\n Натисність на пункт Сума на відрізку, щоб вивести діалогове вікно розрахунків суми на відрізку.", "Допомога");
        }

        
    }
}
