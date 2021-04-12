﻿using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace FFImageLoading.MvvmCross.Sample.Core
{
	/// <summary>
	/// Define the App type.
	/// </summary>
	public class App : MvxApplication
	{
		/// <summary>
		/// Initializes this instance.
		/// </summary>
		public override void Initialize()
		{
			this.CreatableTypes()
				.EndingWith("Service")
				.AsInterfaces()
				.RegisterAsLazySingleton();

			//// Start the app with the Main View Model.
			this.RegisterAppStart<MainViewModel>();
		}
	}
}
