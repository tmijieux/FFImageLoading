using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FFImageLoading.Forms.Sample
{
    public class BasePageModel : BaseModel
    {
        private Page _currentPage;

        public async Task PushAsync(Func<BasePageModel> vmFactory)
        {
            var nav = Application.Current.MainPage as NavigationPage;
            try
            {
                var vm = vmFactory();
                var vmType = vm.GetType();
                var t = typeof(BasePage<>);
                var baseType = t.MakeGenericType(vmType);
                System.Diagnostics.Debug.WriteLine($"navigating to vm={baseType.FullName}");
                var viewType = AppDomain
                    .CurrentDomain
                    .GetAssemblies()
                    .SelectMany(a => a.GetTypes())
                    .Where(x => baseType.IsAssignableFrom(x) && !x.Equals(t))
                    .First();
                System.Diagnostics.Debug.WriteLine($"resolved view={viewType.FullName}");

                var page = Activator.CreateInstance(viewType) as Page;
                vm._currentPage = page;
                page.BindingContext = vm;
                await nav?.PushAsync(page);
                //vm.Reload();
            }
            catch(Exception e)
            {
                await nav?.DisplayAlert("error", e.ToString(), "ok");
            }
        }

        public Page GetCurrentPage() { return _currentPage;  }
    }
}
