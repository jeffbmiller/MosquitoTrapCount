using System;
using UIKit;
using Foundation;
using MosquitoTrapCount.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (iOSBrowserService))]
namespace MosquitoTrapCount.iOS
{
	public class iOSBrowserService : INativeBrowserService
	{

		#region INativeBrowserService implementation

		public void OpenUrl (string url)
		{
			UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
		}

		#endregion
	}
}

