// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MosquitoTrapCount.iOSWatchKitExtension
{
	[Register ("TrapCountTableRowController")]
	partial class TrapCountTableRowController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel dateLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel trapCountLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (dateLabel != null) {
				dateLabel.Dispose ();
				dateLabel = null;
			}
			if (trapCountLabel != null) {
				trapCountLabel.Dispose ();
				trapCountLabel = null;
			}
		}
	}
}
