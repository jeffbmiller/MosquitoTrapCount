using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace MosquitoTrapCount
{
	public class TrapCountYearGroup : ObservableCollection<TrapCountRecordViewModel>
	{
		public TrapCountYearGroup (int year, IEnumerable<TrapCountRecordViewModel> records)
		{
			this.Year = year;
			foreach (var item in records) {
				Add (item);
			}
		}

		public int Year { get; set; }
	}
}

