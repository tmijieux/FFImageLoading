using System.Windows.Input;
using Xamarin.Forms;

namespace FFImageLoading.Forms.Sample
{
    public class PlaceholdersPageModel : BasePageModel
    {
        public PlaceholdersPageModel()
        {
            LoadingPlaceholderCommand = new Command(() =>
            {
                ImageUrl = Helpers.GetRandomImageUrl();
            });

            ErrorPlaceholderCommand = new Command(() =>
            {
                ImageUrl = "http://notexisting.com/notexisting.png";
            });
        }

        public ICommand LoadingPlaceholderCommand { get; set; }

        public ICommand ErrorPlaceholderCommand { get; set; }

        public string ImageUrl { get; set; }
    }
}
