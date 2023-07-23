using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Calculator.Form_type;

namespace Calculator
{
    public partial class Form1 : Form
    {
        List<Button> buttons;
        Point pointStart;
        double num1, num2;
        string input=string.Empty;
        char symbol =' ';
        Culculator myCalc;
        static Size _window =Screen.PrimaryScreen.Bounds.Size;
        int _heigthForm = _window.Height/3;
        int _widthForm = _window.Width/4;
        public Form1()
        {
            InitializeComponent();
            this.Height = _heigthForm;
            this.Width = _widthForm;
            buttons = new List<Button>() {b_0,b_1,b_2,b_3,b_4,b_5,b_6,b_7,b_8,b_9,b_div,b_dot,b_equals,b_multi,b_subs,b_sum };
            myCalc = new Culculator();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                pointStart = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // если нажата левая кнопка мыши
            if ((e.Button & MouseButtons.Left) != 0)
            {
                // получаем новую точку положения формы
                Point deltaPos = new Point(e.X - pointStart.X, e.Y - pointStart.Y);
                // устанавливаем положение формы
                this.Location = new Point(this.Location.X + deltaPos.X,
                  this.Location.Y + deltaPos.Y);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            addChoiceForm();
        }
        private void addChoiceForm()
        {
            var items = new object[] {
            "стандарт",
            "элипс",
            "трапеция",
            "восьмиграник"};
            cb_Visual_type.Items.AddRange(items);
            cb_Visual_type.SelectedValueChanged += CmbChoice_SelectedValueChanged;
            this.Controls.Add(cb_Visual_type);
        }

        private void CmbChoice_SelectedValueChanged(object sender, EventArgs e)
        {
            Form_type.setOriginalForm(this, ((ComboBox)sender).SelectedItem.ToString());
            foreach (var button in buttons)
            {
                Form_type.setOriginalButton(button, ((ComboBox)sender).SelectedItem.ToString());
            }
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

        private void b_close_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_dot_Click(object sender, EventArgs e)
        {
            Display.Text += ".";
            input += ",";
        }


    }
}
