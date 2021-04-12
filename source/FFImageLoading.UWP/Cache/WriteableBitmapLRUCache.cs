﻿using System;
using FFImageLoading.Work;
using Windows.UI.Xaml.Media.Imaging;

namespace FFImageLoading.Cache
{
	public class WriteableBitmapLRUCache : LRUCache<string, Tuple<BitmapSource, ImageInformation>>
	{
		public WriteableBitmapLRUCache(int capacity) : base(capacity)
		{
		}

		public override int GetValueSize(Tuple<BitmapSource, ImageInformation> value)
		{
			if (value?.Item2 == null)
				return 0;

			return value.Item2.CurrentHeight * value.Item2.CurrentWidth * 4;
		}
	}
}
