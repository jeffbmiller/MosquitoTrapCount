using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MosquitoTrapCount.iOSWatchKitExtension
{
	partial class TrapCountTableRowController : NSObject
	{
		public TrapCountTableRowController (IntPtr handle) : base (handle)
		{
            
		}

        public void Update(DateTime date, string count)
        {
            dateLabel.SetText(date.ToString("MMM d"));
            trapCountLabel.SetText(count);
                
        }


	}
}
