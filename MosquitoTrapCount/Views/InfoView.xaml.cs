using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MosquitoTrapCount
{
	public partial class InfoView : ContentPage
	{
		public InfoView ()
		{
			InitializeComponent ();
		}

		private void WebLinkClicked(object sender, EventArgs args)
		{
			DependencyService.Get<INativeBrowserService> ().OpenUrl("http://opengov.brandon.ca/OpenDataService/opendata.html");
		}
	}
}

