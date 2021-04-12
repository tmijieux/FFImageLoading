using System.Windows.Input;
using Xamarin.Forms;

namespace FFImageLoading.Forms.Sample
{

    public class BaseTransformationPageModel : BasePageModel
    {
        public BaseTransformationPageModel()
        {
            LoadAnotherCommand = new Command(() =>
            {
                Reload();
            });
        }

        public string ImageUrl { get; set; }

        public ICommand LoadAnotherCommand { get; set; }

        public void Reload()
        {
            ImageUrl = Helpers.GetRandomImageUrl();
        }
    }
}
