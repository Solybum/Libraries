using System;
using System.IO;

namespace Libraries.PRS
{
    /// <summary>
    /// PRS library
    /// </summary>
    public class PRS
    {
        /// <summary>
        /// Compress a byte array and return the processed data in a new byte array
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Compress(byte[] data)
        {
            using (MemoryStream src = new MemoryStream(data))
            {
                using (MemoryStream dst = new MemoryStream())
                {
                    long size = src.Length - src.Position;
                    byte[] inputBytes = new byte[size];
                    src.Read(inputBytes, 0, checked((int)size));

                    PRSCompression.Encode(inputBytes, dst);
                    return dst.ToArray();
                }
            }
        }

        /// <summary>
        /// Decompress a byte array and return the processed data in a new byte array
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Decompress(byte[] data)
        {
            Context ctx = new Context(data);

            int decompressed_size = PRSDecompression.Decompress(ctx, true);
            Array.Resize(ref ctx.dst, ctx.dst_pos);
            ctx.Reset();

            PRSDecompression.Decompress(ctx, false);

            return ctx.dst;
        }
    }
}
