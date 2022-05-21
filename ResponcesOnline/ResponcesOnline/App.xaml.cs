using ResponcesOnline.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ResponcesOnline
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_Startup(object sender, StartupEventArgs e)
        {
            SignInViewModel viewModel = new SignInViewModel();
            SignInWindow window = new SignInWindow();

            window.Closing += viewModel.OnClosing;

            window.DataContext = viewModel;
            window.Show();
        }
    }
}
