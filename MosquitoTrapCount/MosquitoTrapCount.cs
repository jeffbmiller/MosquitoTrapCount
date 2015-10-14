using System;

using Xamarin.Forms;

namespace MosquitoTrapCount
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
			var navPage = new NavigationPage(new MenuView());
			navPage.BarTextColor = Color.White;
            MainPage = navPage;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

