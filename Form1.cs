using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double num1, num2;
        string input=string.Empty;
        char symbol =' ';
        Culculator myCalc;
        public Form1()
        {
            myCalc = new Culculator();
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void b_0_Click(object sender, EventArgs e)
        {
            Display.Text += 0;
            input += 0;
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            Display.Text += 1;
            input += 1;
        }
        private void b_2_Click(object sender, EventArgs e)
        {
            Display.Text += 2;
            input += 2;
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            Display.Text += 3;
            input += 3;
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            Display.Text += 4;
            input += 4;
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            Display.Text += 5;
            input += 5;
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            Display.Text += 6;
            input += 6;
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            Display.Text += 7;
            input += 7;
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            Display.Text += 8;
            input += 8;
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            Display.Text += 9;
            input += 9;
        }

        private void b_sum_Click(object sender, EventArgs e)
        {
            if (input == string.Empty)
                return;
            if (symbol == ' ')
            {
                Display.Text += "+";
                symbol = '+';
                num1 = double.Parse(input);
                input = string.Empty;                
            }
            else 
                b_equals_Click(sender, e);
        }

        private void b_subs_Click(object sender, EventArgs e)
        {
            if (input == string.Empty)
                return;
            if (symbol == ' ')
            {
                Display.Text += "-";
                symbol = '-';
                num1 = double.Parse(input);
                input = string.Empty;
            }
            else
                b_equals_Click(sender, e);
           
        }

        private void b_multi_Click(object sender, EventArgs e)
        {
            if (input == string.Empty)
                return;
            if (symbol == ' ')
            {
                Display.Text += "*";
                symbol = '*';
                num1 = double.Parse(input);
                input = string.Empty;
            }
            else
                b_equals_Click(sender, e);
           
        }

        private void b_div_Click(object sender, EventArgs e)
        {
            if (input == string.Empty)
                return;
            if (symbol == ' ')
            {
                Display.Text += "/";
                symbol = '/';
                num1 = double.Parse(input);
                input = string.Empty;
            }
            else
                b_equals_Click(sender, e);
           
        }

        private void b_equals_Click(object sender, EventArgs e)
        {
            if (input == string.Empty)
                return;
            Display.Text += "=";
            num2 = double.Parse(input);
            input = string.Empty;
            if (num2 != 0) { 
                Display.Text += myCalc.funcCalc(symbol, num1, num2) + "\n";
                symbol = ' '; }
            else {                
                MessageBox.Show("Деление на ноль запрещенно!");
                Display.Text += "error";
                    }
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, Display.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void b_load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            Display.Text = fileText;
        }

        private void b_dot_Click(object sender, EventArgs e)
        {
            Display.Text += ".";
            input += ",";
        }


    }
}
