using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace MosquitoTrapCount
{
    public class TrapCountCollectionViewModel
    {
        private bool isHistorical;

        public TrapCountCollectionViewModel(bool isHistorical)
        {
            this.isHistorical = isHistorical;
            Records = new ObservableCollection<TrapCountRecordViewModel>();
        }

        public ObservableCollection<TrapCountRecordViewModel> Records {get;set;}

        public async void Refresh()
        {

            if (isHistorical)
            {
                var records = await CityOfBrandonApi.GetHistorical();
                foreach (var item in records)
                {
                    Records.Add(new TrapCountRecordViewModel(item));
                }
            }
            else
            {
                var records = await CityOfBrandonApi.GetAll2015();
                foreach (var item in records)
                {
                    Records.Add(new TrapCountRecordViewModel(item));
                }
            }
           
        }

        public TrapCountRecordViewModel Selected {get;set;}
    }
}

