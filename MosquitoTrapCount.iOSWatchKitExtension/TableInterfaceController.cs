using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Linq;
using System.Collections.Generic;

namespace MosquitoTrapCount.iOSWatchKitExtension
{
	partial class TableInterfaceController : WatchKit.WKInterfaceController
    {
		public TableInterfaceController (IntPtr handle) : base (handle)
		{
            

		}
        public override void WillActivate()
        {
            base.WillActivate();
            LoadTableData();
        }
        public override void Awake(NSObject context)
        {
            base.Awake(context);
           
//            LoadTableData();
        }

        private void LoadTableData()
        {
            OpenParentApplication(new NSDictionary(), (replyInfo, error) =>
                {   
                    if(error != null) {
                        Console.WriteLine (error);
                        return;
                    }
                    Console.WriteLine(replyInfo);

                    trapCountTable.SetNumberOfRows((int)replyInfo.Count, "TrapCountTableRowController");
        
                    var index = 0;
                    foreach (var d in replyInfo)
                    {
                        var row = trapCountTable.GetRowController(index) as TrapCountTableRowController;
                        row.Update(d.Key.ToString(), d.Value.ToString());
                        index++;
                    }
                });

        }
	}
}
