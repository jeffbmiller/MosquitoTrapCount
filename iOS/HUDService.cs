using System;
using MosquitoTrapCount.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (HUDService))]
namespace MosquitoTrapCount.iOS
{
	public class HUDService : IHUDService
	{
		public void Show(string message = null)
		{
			BigTed.BTProgressHUD.Show (message);
		}

		public void Dismiss()
		{
			BigTed.BTProgressHUD.Dismiss ();
		}

		public void ShowError(string message)
		{
			BigTed.BTProgressHUD.ShowErrorWithStatus (message);
		}
	}
}

