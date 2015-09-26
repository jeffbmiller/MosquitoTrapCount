using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Linq;
using System.Collections.Generic;
using MosquitoTrapCount.PCL;

namespace MosquitoTrapCount.iOSWatchKitExtension
{
	partial class TableInterfaceController : WatchKit.WKInterfaceController
    {
		public TableInterfaceController (IntPtr handle) : base (handle)
		{
            

		}

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            LoadTableData();
        }

        private async void LoadTableData()
        {
//            var results = await CityOfBrandonApi.GetAll2015();
//            data = results.ToList();
            var data = new List<DateTime>(){DateTime.Now, DateTime.Now.AddDays(1), DateTime.Now.AddDays(2)};
            trapCountTable.SetNumberOfRows(data.Count, "TrapCountTableRowController");

            foreach (var d in data)
            {
                var row = trapCountTable.GetRowController(data.IndexOf(d)) as TrapCountTableRowController;
                row.Update(d, 1);
            }
        }
	}
}
