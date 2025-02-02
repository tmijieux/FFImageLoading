﻿using Xamarin.Forms;

namespace FFImageLoading.Forms.Sample
{
    public class App : Application
    {
        public App()
        {
            App.Current.Resources = new ResourceDictionary()
                {
                    { "CustomCacheKeyFactory", new CustomCacheKeyFactory() }
                };

            //CachedImage.FixedOnMeasureBehavior = true;
            //CachedImage.FixedAndroidMotionEventHandler = true;

            //ImageService.Instance.LoadCompiledResource("loading.png").Preload();
            //ImageService.Instance.LoadUrl("https://loremflickr.com/cache/resized/65535_50969551187_3a5354d0b8_b_600_600_nofilter.jpg").DownloadOnly();
            MainPage = new NavigationPage(new MenuPage());
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

