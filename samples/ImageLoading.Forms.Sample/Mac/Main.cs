﻿using AppKit;

namespace FFImageLoading.Forms.Sample.Mac
{
	static class MainClass
	{
		static void Main(string[] args)
		{
			NSApplication.Init();
			NSApplication.SharedApplication.Delegate = new AppDelegate();
			NSApplication.Main(args);
		}
	}
}
