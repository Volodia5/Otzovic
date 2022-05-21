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
using ResponcesOnline.View;
using System.Windows.Shapes;

namespace ResponcesOnline
{
    /// <summary>
    /// Логика взаимодействия для CategoriesWindow.xaml
    /// </summary>
    public partial class CategoriesWindow : Window
    {
        public CategoriesWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow window = new ProfileWindow();
            window.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyReportsView window = new MyReportsView();
            window.Show();
            this.Close();
        }
    }
}
