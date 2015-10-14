using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MosquitoTrapCount
{
    public partial class MenuView : ContentPage
    {
        private MenuViewModel viewModel;
        public MenuView()
        {
            InitializeComponent();
            BindingContext = viewModel = new MenuViewModel();
			NavigationPage.SetBackButtonTitle (this, "Back");
        }

		private void OnInfoClicked(object sender, EventArgs args)
		{
			this.Navigation.PushAsync (new InfoView ());

		}

        private void OnTapped (object sender, EventArgs args)
        {
            if (viewModel.Selected == null)
                return;
            if (viewModel.Selected.Title == "2015 Trap Counts")
                this.Navigation.PushAsync(new TrapCountCollectionView(false));
            if (viewModel.Selected.Title == "Historical Trap Counts")
                this.Navigation.PushAsync(new TrapCountCollectionView(true));
            if (viewModel.Selected.Title == "Charts"){
                var carouselPage = new CarouselPage()
                {
                    Children =
                    {                        
                        new YTDTrapsChartView(),
                        new YTDAvgChartView()
                    }
                };                   
                carouselPage.Title = "Charts";
                this.Navigation.PushAsync(carouselPage);
            }

            ((ListView)sender).SelectedItem = null;
        }
    }
}

