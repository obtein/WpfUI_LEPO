using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using WpfUI_LEPO.HelperClasses;

namespace WpfUI_LEPO.Monitor
{
    class MonitorPageVM : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "MonitorPage";
            }
        }
    }
}
