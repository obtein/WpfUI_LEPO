using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using WpfUI_LEPO.HelperClasses;

namespace WpfUI_LEPO.Login
{
    class LoginPageVM : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "LoginPage";
            }
        }

    }
}
