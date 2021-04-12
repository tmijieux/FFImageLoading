using System.Windows.Input;
using Xamvvm;

namespace FFImageLoading.Forms.Sample
{
	public class PlaceholdersPageModel : BasePageModel
	{
		public PlaceholdersPageModel()
		{
			LoadingPlaceholderCommand = new BaseCommand((arg) =>
			{
				ImageUrl = Helpers.GetRandomImageUrl();
			});

			ErrorPlaceholderCommand = new BaseCommand((arg) =>
			{
				ImageUrl = "http://notexisting.com/notexisting.png";
			});
		}

		public ICommand LoadingPlaceholderCommand { get; set; }

		public ICommand ErrorPlaceholderCommand { get; set; }

		public string ImageUrl { get; set; }
	}
}
