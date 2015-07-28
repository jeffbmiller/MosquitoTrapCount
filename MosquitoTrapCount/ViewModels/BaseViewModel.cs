using System;
using System.ComponentModel;

namespace MosquitoTrapCount
{
    public class BaseViewModel : INotifyPropertyChanged
    {        
        public string Title {get;set;}

        private bool isBusy;
        public bool IsBusy
        { 
            get { return isBusy; }
            set
            {
                if (isBusy = value)
                    return;
                isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

      

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
        }
    }
}

