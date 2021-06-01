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

namespace zad1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double wynik;
        double a;
        double b;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
                //wynik = Convert.ToDouble(textBox2.Text);
                a = Convert.ToDouble(textBox.Text);
                b = Convert.ToDouble(textBox1.Text);
                wynik = a + b;
                textBox2.Text = (Convert.ToString("Suma" + textBox.Text + "+" + textBox1.Text + "=" + wynik));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            b = Convert.ToDouble(textBox1.Text);
            wynik = a - b;
            textBox2.Text = (Convert.ToString("Różnica" + textBox.Text + "-" + textBox1.Text + "=" + wynik));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            b = Convert.ToDouble(textBox1.Text);
            wynik = a * b;
            textBox2.Text = (Convert.ToString("Iloczyn" + textBox.Text + "*" + textBox1.Text + "=" + wynik));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(textBox.Text);
            b = Convert.ToDouble(textBox1.Text);

            if (a == 0 || b == 0)
            {
                textBox2.Text = "Nie można dzielić przez 0!";
                MessageBox.Show("Nie można dzielić przez 0!");
            }
            else
            {
               
                wynik = a / b;
                textBox2.Text = (Convert.ToString("Iloraz" + textBox.Text + "/" + textBox1.Text + "=" + wynik));
            }
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
