using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCaliburn.ViewModels
{
    [Export]
    public class PopupViewModel : Screen
    {
        private int _timesOpened;
        private string _message;
        public string Message
        {
            get 
            {
                Debug.WriteLine("Message is get");
                return _message; 
            }
            set
            {
                if (value == _message) return;
                _message = value;
                NotifyOfPropertyChange(() => Message);
            }
        }
        protected override void OnActivate()
        {
            Debug.WriteLine("---Window is activated---");
            _timesOpened++;

            Message = "Popup number : " + _timesOpened;
        }      
    }
}
