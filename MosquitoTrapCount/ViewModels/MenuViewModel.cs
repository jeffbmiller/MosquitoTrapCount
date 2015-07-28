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
            MenuItems.Add(new MenuItem("2015 Trap Counts", Color.Green, "Mosquito.png"));
            MenuItems.Add(new MenuItem("Historical Trap Counts", Color.Navy, "HistoryIcon.png"));
            MenuItems.Add(new MenuItem("Charts", Color.Purple, "Chart.png"));
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

