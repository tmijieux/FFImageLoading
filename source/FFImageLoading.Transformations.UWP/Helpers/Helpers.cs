using System;

namespace FFImageLoading.Transformations
{
    public static class Helpers
    {
        public static void BlockCopy(Array src, int srcOffset, Array dest, int destOffset, int count)
        {
            Buffer.BlockCopy(src, srcOffset, dest, destOffset, count);
        }

        internal static void BlockCopy(byte[] pixelData, int srcOff, byte[] result, int dstOff, int v)
        {
            throw new NotImplementedException();
        }
    }
}
