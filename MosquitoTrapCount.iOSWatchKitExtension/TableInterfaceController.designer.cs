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
	[Register ("TableInterfaceController")]
	partial class TableInterfaceController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceTable trapCountTable { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (trapCountTable != null) {
				trapCountTable.Dispose ();
				trapCountTable = null;
			}
		}
	}
}
