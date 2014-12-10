using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BaseCaliburn.ViewModels
{
    [Export(typeof(IShell))]
    public class HomeViewModel : Screen
    {
        [Import]
        public PopupViewModel PopupViewModel { get; set; }

        public void StartApp()
        {
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;

            IoC.Get<IWindowManager>().ShowWindow(PopupViewModel);
        }
    }
}
