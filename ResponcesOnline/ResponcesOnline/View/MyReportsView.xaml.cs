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

namespace ResponcesOnline.View
{
    /// <summary>
    /// Логика взаимодействия для MyReportsView.xaml
    /// </summary>
    public partial class MyReportsView : Window
    {
        public MyReportsView()
        {
            InitializeComponent();

            this.Closing += OpenCategoriesView;
        }

        private void OpenCategoriesView(object sender, EventArgs e)
        {
            CategoriesWindow categoriesWindow = new CategoriesWindow();
            categoriesWindow.Show();
        }
    }
}
