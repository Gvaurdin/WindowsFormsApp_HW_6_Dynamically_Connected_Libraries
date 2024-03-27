using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometryCalculator;

namespace WindowsFormsApp_HW_6_Dynamically_Connected_Libraries
{
    public partial class FormDLL_Task_1 : Form
    {
        public FormDLL_Task_1()
        {
            InitializeComponent();
        }


        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            // проверка, что все необходимые поля заполнены
            if (string.IsNullOrWhiteSpace(sideTextBox.Text) || string.IsNullOrWhiteSpace(lengthTextBox.Text) ||
                string.IsNullOrWhiteSpace(widthTextBox.Text) || string.IsNullOrWhiteSpace(baseTextBox.Text) ||
                string.IsNullOrWhiteSpace(heightTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, введите все данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // парсим значения из текстбоксов
            double side = double.Parse(sideTextBox.Text);
            double length = double.Parse(lengthTextBox.Text);
            double width = double.Parse(widthTextBox.Text);
            double @base = double.Parse(baseTextBox.Text); // @base используется, так как base является зарезервированным словом
            double height = double.Parse(heightTextBox.Text);

            // расчитываем площади с использованием методов из DLL-модуля
            double squareArea = GeometryCalculator.Geometry.CalculateSquareArea(side);
            double rectangleArea = GeometryCalculator.Geometry.CalculateRectangleArea(length, width);
            double triangleArea = GeometryCalculator.Geometry.CalculateTriangleArea(@base, height);

            // результаты
            squareResultLabel.Text = "Площадь квадрата: " + squareArea;
            rectangleResultLabel.Text = "Площадь прямоугольника: " + rectangleArea;
            triangleResultLabel.Text = "Площадь треугольника: " + triangleArea;
        }
    }
}
