﻿using System.Windows.Input;
using Xamvvm;
namespace FFImageLoading.Forms.Sample
{

	public class BaseTransformationPageModel : BasePageModel
	{
		public BaseTransformationPageModel()
		{
			LoadAnotherCommand = new BaseCommand((arg) =>
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
