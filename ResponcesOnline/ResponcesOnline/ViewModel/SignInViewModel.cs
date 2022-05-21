using ResponcesOnline.Model;
using ResponcesOnline.Model.Tools;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ResponcesOnline.ViewModel
{
    class SignInViewModel
    {
        private CommandTemplate _openSignUpWindow;
        private CommandTemplate _signingCommand;

        private string _login;
        private string _password;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public CommandTemplate SigningCommand
        {
            get
            {
                if (_signingCommand == null)
                {
                    _signingCommand = new CommandTemplate(obj =>
                    {
                        bool isSignIn = SignIn();

                        if (isSignIn == true)
                        {
                            CategoriesWindow categoriesWindow = new CategoriesWindow();
                            categoriesWindow.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Неправильный логин или пароль !");
                        }
                            
                    });
                }

                return _signingCommand;
            }
        }

        public bool SignIn()
        {
            using (otzovic_dbContext db = new otzovic_dbContext())
            {
                List<User> users = db.Users.ToList();

                foreach (User item in users)
                {
                    if (item.Login == this.Login && item.Password == this.Password)
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public void OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("!!!");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
