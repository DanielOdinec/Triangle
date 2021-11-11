using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
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

       

        private void Run_button_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text); // считываем значение стороны а
            b = Convert.ToDouble(txtB.Text); // считываем значение стороны b
            c = Convert.ToDouble(txtC.Text); // считываем значение стороны b
            Triangle triangle = new Triangle(a, b, c); // создаем объект класса Triangle с именем triangle
            listView1.Items.Add("Сторона а"); // добавляем соответсвующие ячейки в коллекцию
            listView1.Items.Add("Сторона b"); // при клике на кнопку Запуск первый столбец заполнится этими нашими именами
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");
            listView1.Items[0].SubItems.Add(triangle.outputA()); // методы по выводу сторон a,b,c
            listView1.Items[1].SubItems.Add(triangle.outputB()); // Item' y с индексом [i] присваиваем значение сабайтема
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter())); //выводим периметр
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface())); //выводим значение площади
            if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); } // свойтство Triangle.exist
            else listView1.Items[5].SubItems.Add("Не существует");
            listView1.Items[6].SubItems.Add(triangle.TriangleType);
            if (triangle.TriangleType == "равносторонний")
            {
                pictureBox2.Image = Properties.Resources.triangle;
            }
            else if (triangle.TriangleType == "разносторонний")
            {
                pictureBox2.Image = Properties.Resources.raznostoronny;
            }
            else if (triangle.TriangleType == "равнобедренный")
            {
                pictureBox2.Image = Properties.Resources.ravnobedrenny;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.vopros;
            }
        }







    
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            New_form frm = new New_form();
            frm.Show();


        }
        
    }
}
