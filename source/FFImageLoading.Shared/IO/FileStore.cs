﻿using System.IO;

/* Unmerged change from project 'FFImageLoading.Touch'
Before:
using System.Threading.Tasks;
using System.IO;
After:
using System.IO;
using System.Threading;
*/

/* Unmerged change from project 'FFImageLoading.Mac'
Before:
using System.Threading.Tasks;
using System.IO;
After:
using System.IO;
using System.Threading;
*/

/* Unmerged change from project 'FFImageLoading.Tizen'
Before:
using System.Threading.Tasks;
using System.IO;
After:
using System.IO;
using System.Threading;
*/
using System.Threading;
using System.Threading.Tasks;

namespace FFImageLoading.IO
{
	internal static class FileStore
	{
		private const int DefaultBufferSize = 4096;

		public static Stream GetInputStream(string path, bool asynchronous)
		{
			return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, asynchronous);
		}

		public static Stream GetOutputStream(string path, bool asynchronous)
		{
			return new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, DefaultBufferSize, asynchronous);
		}

		public static bool Exists(string path)
		{
			return File.Exists(path);
		}

		public static async Task<byte[]> ReadBytesAsync(string path, CancellationToken token)
		{
			using (var fs = GetInputStream(path, true))
			{
				var buff = new byte[fs.Length];
				await fs.ReadAsync(buff, 0, (int)fs.Length, token).ConfigureAwait(false);
				return buff;
			}
		}

		public static async Task WriteBytesAsync(string path, byte[] data, CancellationToken token)
		{
/* Unmerged change from project 'FFImageLoading.Tizen'
Before:
            using (var fs = GetOutputStream(path, true)) {
After:
            using (var fs = GetOutputStream(path, true))
            {
*/

			using (var fs = GetOutputStream(path, true))
			{
				await fs.WriteAsync(data, 0, data.Length, token).ConfigureAwait(false);
			}
		}
	}
}

