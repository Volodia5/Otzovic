using ResponcesOnline.Model;
using ResponcesOnline.Model.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ResponcesOnline.ViewModel
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        private CommandTemplate _updateUserCommand;
        private User _user;
        private string _nickName;
        private string _login;
        private string _password;

        public string UserName
        {
            get
            {
                return _nickName;
            }
            set
            {
                if (value != _nickName)
                    _nickName = value;
                OnPropertyChanged();
            }
        }

        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                if (value != _login)
                    _login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value != _password)
                    _password = value;
                OnPropertyChanged();
            }
        }

        //public CommandTemplate UpdateUserCommand
        //{

        //}

        public void UpdateUser()
        {
            using (otzovic_dbContext db = new otzovic_dbContext())
            {
                List<User> users = db.Users.ToList();
                //User user; 

                foreach (User item in users)
                {
                    if (item.Login != _login && item.Nickname != _nickName && item.Password != _password)
                    {
                        //db.Users.Where(x => x.Id == user.Id).FirstOrDefault();
                    }

                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
