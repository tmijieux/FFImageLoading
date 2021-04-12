using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FFImageLoading.Forms.Sample
{
    public class BasePageModel : BaseModel
    {
        public async Task PushAsync(Func<BasePageModel> vmFactory)
        {
            var nav = Application.Current.MainPage as NavigationPage;
            try
            {
                var vm = vmFactory();
                var vmType = vm.GetType();
                var t = typeof(BasePage<>);
                var type = t.MakeGenericType(vmType);
                System.Diagnostics.Debug.WriteLine($"navigating to vm={type.FullName}");
                var viewType = typeof(BasePageModel)
                    .Assembly
                    .GetTypes()
                    .Where(x => type.IsAssignableFrom(x) && !x.Equals(t))
                    .First();
                System.Diagnostics.Debug.WriteLine($"resolved view={viewType.FullName}");

                var page = Activator.CreateInstance(viewType) as Page;
                await nav?.PushAsync(page);
            }
            catch(Exception e)
            {
                await nav?.DisplayAlert("error", e.ToString(), "ok");
            }
        }

        public Page GetCurrentPage() { return null;  }
    }
}
