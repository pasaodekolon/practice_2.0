using System;
using System.Windows.Forms;

namespace FiguresWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            figure_comboBox.SelectedIndex = 0; // Выбор прямоугольника при запуске
            this.Resize += new EventHandler(Form1_Resize);
        }

        private void square_button_Click(object sender, EventArgs e)
        {
            Figure fig = null;
            switch (figure_comboBox.SelectedIndex)
            {
                case 1: // круг
                    fig = new Circle((double)size1_numericUpDown.Value);
                    break;
                case 2: // квадрат
                    fig = new Square1((double)size1_numericUpDown.Value);
                    break;
                case 3: // трапеция
                        // Предполагаем, что у вас есть соответствующие элементы управления для ввода значений
                    fig = new Trapezoid((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value, (double)size3_numericUpDown.Value, (double)size4_numericUpDown.Value, (double)size5_numericUpDown.Value);
                    break;
                case 4: // треугольник
                        // Предполагаем, что у вас есть соответствующие элементы управления для ввода значений
                    fig = new Triangle((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value, (double)size3_numericUpDown.Value, (double)size4_numericUpDown.Value, (double)size5_numericUpDown.Value);
                    break;
            }
            protocol_listBox.Items.Add(fig.ToString() + ": S=" + fig.Square());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            protocol_listBox.Width = this.Width - 40; // Растягивание протокола
            protocol_listBox.Height = this.Height - 80; // Сжатие протокола
        }

        private void figure_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Скрываем все элементы управления
            size1_label.Visible = false;
            size1_numericUpDown.Visible = false;
            size2_label.Visible = false;
            size2_numericUpDown.Visible = false;
            size3_label.Visible = false;
            size3_numericUpDown.Visible = false;
            size4_label.Visible = false;
            size4_numericUpDown.Visible = false;
            size5_label.Visible = false;
            size5_numericUpDown.Visible = false;

            // Показываем нужные элементы управления в зависимости от выбранной фигуры
            switch (figure_comboBox.SelectedIndex)
            {
                case 0: // Прямоугольник
                    size1_label.Visible = true;
                    size1_numericUpDown.Visible = true;
                    size1_label.Text = "Длина:";
                    size2_label.Visible = true;
                    size2_numericUpDown.Visible = true;
                    size2_label.Text = "Ширина:";
                    break;
                case 1: // Круг
                    size1_label.Visible = true;
                    size1_numericUpDown.Visible = true;
                    size1_label.Text = "Радиус:";
                    break;
                case 2: // Квадрат
                    size1_label.Visible = true;
                    size1_numericUpDown.Visible = true;
                    size1_label.Text = "Сторона:";
                    break;
                case 3: // Трапеция
                    size1_label.Visible = true;
                    size1_numericUpDown.Visible = true;
                    size1_label.Text = "Основание 1:";
                    size2_label.Visible = true;
                    size2_numericUpDown.Visible = true;
                    size2_label.Text = "Основание 2:";
                    size3_label.Visible = true;
                    size3_numericUpDown.Visible = true;
                    size3_label.Text = "Высота:";
                    size4_label.Visible = true;
                    size4_numericUpDown.Visible = true;
                    size4_label.Text = "Сторона 1:";
                    size5_label.Visible = true;
                    size5_numericUpDown.Visible = true;
                    size5_label.Text = "Сторона 2:";
                    break;
                case 4: // Треугольник
                    size1_label.Visible = true;
                    size1_numericUpDown.Visible = true;
                    size1_label.Text = "Основание:";
                    size2_label.Visible = true;
                    size2_numericUpDown.Visible = true;
                    size2_label.Text = "Высота:";
                    size3_label.Visible = true;
                    size3_numericUpDown.Visible = true;
                    size3_label.Text = "Сторона 1:";
                    size4_label.Visible = true;
                    size4_numericUpDown.Visible = true;
                    size4_label.Text = "Сторона 2:";
                    size5_label.Visible = true;
                    size5_numericUpDown.Visible = true;
                    size5_label.Text = "Сторона 3:";
                    break;
            }
        }

        private void perimeter_button_Click(object sender, EventArgs e)
        {
            Figure fig = null;
            switch (figure_comboBox.SelectedIndex)
            {
                case 0: // прямоугольник
                    fig = new Rect((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value);
                    break;
                case 1: // круг
                    fig = new Circle((double)size1_numericUpDown.Value);
                    break;
                case 2: // квадрат
                    fig = new Square1((double)size1_numericUpDown.Value);
                    break;
                case 3: // трапеция
                        // Предполагаем, что у вас есть соответствующие элементы управления для ввода значений
                    fig = new Trapezoid((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value, (double)size3_numericUpDown.Value, (double)size4_numericUpDown.Value, (double)size5_numericUpDown.Value);
                    break;
                case 4: // треугольник
                        // Предполагаем, что у вас есть соответствующие элементы управления для ввода значений
                    fig = new Triangle((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value, (double)size3_numericUpDown.Value, (double)size4_numericUpDown.Value, (double)size5_numericUpDown.Value);
                    break;
            }
            protocol_listBox.Items.Add(fig.ToString() + ": P=" + fig.Perimetr);
        }

        private void figure_comboBox_Click(object sender, EventArgs e)
        {

        }
    }
}
