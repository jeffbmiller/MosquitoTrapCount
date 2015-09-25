using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MosquitoTrapCount
{
    public class MenuViewModel : BaseViewModel
    {
        public MenuViewModel()
        {
            MenuItems = new ObservableCollection<MenuItem>();
            MenuItems.Add(new MenuItem("2015 Trap Counts", Color.FromHex("#879B57"), "Mosquito.png"));
            MenuItems.Add(new MenuItem("Historical Trap Counts", Color.FromHex("#DBA177"), "HistoryIcon.png"));
            MenuItems.Add(new MenuItem("Charts", Color.FromHex("#D48044"), "Chart.png"));
        }

        public ObservableCollection<MenuItem> MenuItems {get;set;}

        private MenuItem selected;
        public MenuItem Selected { 
            get {return selected; } 
            set {
                if (selected == value)
                    return;
                selected = value;
                OnPropertyChanged("Selected");
            }
        }
    }
}

