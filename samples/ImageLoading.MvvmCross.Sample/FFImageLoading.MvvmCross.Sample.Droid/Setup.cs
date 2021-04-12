using Android.Content;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;

namespace FFImageLoading.MvvmCross.Sample.Droid
{
    public class Setup : MvxAndroidSetup
    {
        /// <summary>
        /// Creates the app.
        /// </summary>
        /// <returns>An instance of IMvxApplication.</returns>
        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
    }
}
