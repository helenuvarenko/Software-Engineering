using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ServiceCentre
{
    public partial class Form1 : Form
    {
        // создаем объект класса Controller  
        Controller controller = new Controller();

        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                // выводим результат  
                MessageBox.Show(controller.Question(textBox1.Text));

        }
    }

    class Controller
    {
        public string Question(string msg)//msg - то что ищем  
        {
            Model model = new Model();
            return "На даный момент ваш заказ "
                + model.GetAnser(msg);
        }
    }

    class Model
    {
        //question - то что ищем  
        public string GetAnser(string question)
        {
            return DataBase.GetAnser(question);
        }
    }

    static class DataBase
    {
        //question - то что ищем  
        public static string GetAnser(string question)
        {
            string path = "D:\\ИПЗ\\ServiceCentre\\headphones.txt";// путь к базе даных ):  

            // создаем обьект (читатель)  
            using (StreamReader sr =
                new StreamReader(path, Encoding.Default))
            {
                string str = null;
                while (true)
                {
                    //если пустая то это конец  
                    str = sr.ReadLine();
                    if (str != null)
                    {
                        //если считаная строчка   
                        //равна строке для поиска  
                        if (str == question)
                            return "готов";
                    }
                    else
                        return "не готов";
                }
            }
        }
    }
}
