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
            Reload();
        }

        public string ImageUrl { get; set; }

        public ICommand LoadAnotherCommand { get; set; }

        public override void Reload()
        {
            ImageUrl = Helpers.GetRandomImageUrl();
        }
    }
}
