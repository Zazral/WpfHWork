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
using System.Windows.Shapes;

namespace WpfHWork
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MaWin = new MainWindow();
            MaWin.Show();
            Close();
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            txtbox.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string[] str;
            str = txtbox.Text.Split(' ');
            lstbox.Items.Clear();
            foreach (string el in str)
            {
                lstbox.Items.Add(el);
            }
        }
    }
}
