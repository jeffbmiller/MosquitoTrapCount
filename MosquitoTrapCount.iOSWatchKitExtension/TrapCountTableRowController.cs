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

        public void Update(string date, string count)
        {
            dateLabel.SetText(date);
            trapCountLabel.SetText(count);
                
        }


	}
}
