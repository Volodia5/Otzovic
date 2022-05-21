using Microsoft.EntityFrameworkCore;
using ResponcesOnline.Model;
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

namespace ResponcesOnline
{
    /// <summary>
    /// Логика взаимодействия для ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {

        public ProfileWindow()
        {
            InitializeComponent();

            this.Closing += ProfileWindow_Closing;
        }

        private void ProfileWindow_Closing(object sender, EventArgs e)
        {
            CategoriesWindow categoriesWindow = new CategoriesWindow();
            categoriesWindow.Show();
        }

        //public void GetUser(int id)
        //{
        //    db = new otzovic_dbContext();
        //    User user = db.Users.Include(x => x.Role).Where(x => x.Id == id).ToString();
        //    users = db.Users.Find(x => x.).ToString();
        //}
    }
}
