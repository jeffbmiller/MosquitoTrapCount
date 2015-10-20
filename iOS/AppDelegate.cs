using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Syncfusion.SfChart.XForms.iOS.Renderers;
using MosquitoTrapCount.PCL;
using Xamarin;

namespace MosquitoTrapCount.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            new SfChartRenderer();
            global::Xamarin.Forms.Forms.Init();

			#if DEBUG
				Insights.Initialize(Insights.DebugModeKey);
			#else
				Insights.Initialize("3f19f22e7e8b044795c9066e05a67412f4720786");
			#endif

            UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(81, 66, 99);
            UINavigationBar.Appearance.TintColor = UIColor.White;
            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes(){ TextColor = UIColor.White });
            UIApplication.SharedApplication.SetStatusBarStyle (UIStatusBarStyle.LightContent, false);
			UIApplication.SharedApplication.SetStatusBarHidden(false, false);
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

        public async override void HandleWatchKitExtensionRequest(UIApplication application, NSDictionary userInfo, Action<NSDictionary> reply)
        {
            if (userInfo.ContainsKey(new NSString("2015DailyAvg")))
            {
                //Kick off Background Task.
                var taskId = UIApplication.SharedApplication.BeginBackgroundTask(() =>
                    {
                    });

                var results = await CityOfBrandonApi.GetAll2015();
                var dictionary = new NSMutableDictionary();
                foreach (var d in results.OrderByDescending(x=>x.SamplingDate))
                    dictionary.Add(d.SamplingDate.DateTimeToNSDate(), new NSString(d.DailyAvgCount.ToString()));
                reply(dictionary);

                //End Background task
                UIApplication.SharedApplication.EndBackgroundTask(taskId);
            }

        }
    }
        
}

