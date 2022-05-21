using ResponcesOnline.Model;
using ResponcesOnline.View;
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
    class CategoriesViewModel
    {
        private User _user;

        private CommandTemplate _openProfileViewCommand;

        public User user
        {
            get => _user;
            set
            {
                _user = value;
                OnPropertyChanged(nameof(user));
            }
        }

        #region Команды
        //public CommandTemplate OpenProfileViewCommand
        //{
        //    get
        //    {
        //        if (_openProfileViewCommand != null)
        //            _openProfileViewCommand = new CommandTemplate(obj =>
        //            )
        //    }
        //}

        interface IOpenViewProfile
        {
            bool? ShowDialog(ProfileViewModel profileViewModel);
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
