using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Syncfusion.SfChart.XForms.iOS.Renderers;

namespace MosquitoTrapCount.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new SfChartRenderer();
            global::Xamarin.Forms.Forms.Init();

            UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(81, 66, 99);
            UINavigationBar.Appearance.TintColor = UIColor.White;
            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes(){ TextColor = UIColor.White });
            UIApplication.SharedApplication.SetStatusBarStyle (UIStatusBarStyle.LightContent, false);

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}

