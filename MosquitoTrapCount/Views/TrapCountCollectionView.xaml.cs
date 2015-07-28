using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MosquitoTrapCount
{
    public partial class TrapCountCollectionView : ContentPage
    {
        private readonly TrapCountCollectionViewModel viewModel;
        public TrapCountCollectionView(bool isHistorical)
        {
            InitializeComponent();
            BindingContext = (viewModel = new TrapCountCollectionViewModel(isHistorical));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.Refresh();
        }

        public void OnItemSelected (object sender, EventArgs e) {
            ((ListView)sender).SelectedItem = null;
        }
    }
}

