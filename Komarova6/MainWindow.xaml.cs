using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Komarova6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Circle_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(cx.Text);
            double y = double.Parse(cy.Text);
            double r = double.Parse(cr.Text);

            Circle c = new Circle(x, y, r);

            Ellipse el = new Ellipse();
            el.Width = r * 2;
            el.Height = r * 2;
            el.Stroke = Brushes.Blue;
            el.StrokeThickness = 2;

            Canvas.SetLeft(el, x - r);
            Canvas.SetTop(el, y - r);
            cv.Children.Add(el);

            info.Text = c.Draw();
        }

        // Треугольник (равнобедренный — строим по сторонам)
        private void Triangle_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(tx.Text);
            double y = double.Parse(ty.Text);
            double a = double.Parse(ta.Text);
            double b = double.Parse(tb.Text);
            double c = double.Parse(tc.Text);

            Triangle t = new Triangle(x, y, a, b, c);

            // Высота треугольника по формуле Герона
            double p = (a + b + c) / 2;
            double h = 2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / c;

            // Вершины: основание c по горизонтали, центр посередине
            Point p1 = new Point(x - c / 2, y + h / 3);
            Point p2 = new Point(x + c / 2, y + h / 3);
            Point p3 = new Point(x, y - 2 * h / 3);

            Polygon poly = new Polygon();
            poly.Points.Add(p1);
            poly.Points.Add(p2);
            poly.Points.Add(p3);
            poly.Stroke = Brushes.Red;
            poly.StrokeThickness = 2;
            cv.Children.Add(poly);

            info.Text = t.Draw();
        }
    }
}
