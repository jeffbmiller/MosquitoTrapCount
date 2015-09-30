using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using MosquitoTrapCount.PCL;
using Xamarin.Forms;

namespace MosquitoTrapCount
{
    public class TrapCountCollectionViewModel
    {
        private bool isHistorical;
		private readonly IHUDService hudService;

        public TrapCountCollectionViewModel(bool isHistorical)
        {
			this.hudService = DependencyService.Get<IHUDService> ();
            this.isHistorical = isHistorical;
            Records = new ObservableCollection<TrapCountRecordViewModel>();
        }

        public ObservableCollection<TrapCountRecordViewModel> Records {get;set;}

        public async void Refresh()
        {

            if (isHistorical)
            {
				try
				{
					hudService.Show ();
	                var records = await CityOfBrandonApi.GetHistorical();
	                foreach (var item in records)
	                {
	                    Records.Add(new TrapCountRecordViewModel(item));
	                }
					hudService.Dismiss ();
				}
				catch (Exception e) {
					hudService.ShowError ("Error Communicating With Server");
				}
            }
            else
            {
				
				try {
					hudService.Show ();
	                var records = await CityOfBrandonApi.GetAll2015();
	                foreach (var item in records)
	                {
	                    Records.Add(new TrapCountRecordViewModel(item));
	                }
					hudService.Dismiss ();
				}
				catch (Exception e) {
					hudService.ShowError ("Error Communicating With Server");
				}

            }
           
        }

        public TrapCountRecordViewModel Selected {get;set;}
    }
}

