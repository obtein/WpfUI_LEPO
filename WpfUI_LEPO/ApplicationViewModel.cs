﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Wpf.Ui.Input;
using WpfUI_LEPO.HelperClasses;
using WpfUI_LEPO.Login;
using WpfUI_LEPO.Monitor;

namespace WpfUI_LEPO
{
    public class ApplicationViewModel : ObservableObject
    {
        #region Fields

        private ICommand _changePageCommand;

        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;

        #endregion

        public ApplicationViewModel ()
        {
            // Add available pages
            PageViewModels.Add( new LoginPageVM() );
            PageViewModels.Add( new MonitorPageVM() );

            // Set starting page
            CurrentPageViewModel = PageViewModels [0];
        }

        #region Properties / Commands

        public ICommand ChangePageCommand
        {
            get
            {
                if ( _changePageCommand == null )
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangeViewModel( (IPageViewModel)p ),
                        p => p is IPageViewModel );
                }

                return _changePageCommand;
            }
        }

        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if ( _pageViewModels == null )
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                if ( _currentPageViewModel != value )
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged( "CurrentPageViewModel" );
                }
            }
        }

        #endregion

        #region Methods

        private void ChangeViewModel ( IPageViewModel viewModel )
        {
            if ( !PageViewModels.Contains( viewModel ) )
                PageViewModels.Add( viewModel );

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault( vm => vm == viewModel );
        }

        #endregion
    }
}
