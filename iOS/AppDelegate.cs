using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Syncfusion.SfChart.XForms.iOS.Renderers;
using MosquitoTrapCount.PCL;

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

        public async override void HandleWatchKitExtensionRequest(UIApplication application, NSDictionary userInfo, Action<NSDictionary> reply)
        {
            //Kick off Background Task.
            var taskId = UIApplication.SharedApplication.BeginBackgroundTask(() =>
                {
                });

            var results = await CityOfBrandonApi.GetAll2015();
            var dictionary = new NSMutableDictionary();
            foreach(var d in results.OrderByDescending(x=>x.SamplingDate))       
                dictionary.Add(new NSString(d.SamplingDate.ToString("MMM d")), new NSString(d.DailyAvgCount.ToString()));
            reply(dictionary);

            //End Background task
            UIApplication.SharedApplication.EndBackgroundTask(taskId);
          

        }
    }
        
}

