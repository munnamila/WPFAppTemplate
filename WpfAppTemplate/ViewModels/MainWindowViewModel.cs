using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppTemplate.ViewModels
{
    class MainWindowViewModel
    {
        public DelegateCommand CloseAppCommand { get; set; }

        public MainWindowViewModel()
        {
            CloseAppCommand = new DelegateCommand(ExcuteCloseApp);
        }

        private void ExcuteCloseApp()
        {
            Application.Current.Shutdown();
        }
    }
}
