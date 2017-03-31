namespace Libraries.PRS
{
    /// <summary>
    /// PRS library
    /// </summary>
    /// <remarks>
    /// Compression and decompression are based on <see href="https://sourceforge.net/p/sylverant/libsylverant/ci/master/tree/src/utils/">Lawrence Sebald</see> original implementation.
    /// Compression is also based on <see href="https://github.com/DaanVandenBosch/phantasmal-quest/blob/master/src/data/compression/prs/compress.js">DaanVandenBosch</see> implementation.
    /// </remarks>
    public class PRS
    {
        /// <summary>
        /// Compress a byte array and return the processed data in a new byte array
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Compress(byte[] data)
        {
            Context ctx = new Context(data);
            HashTable hash = new HashTable();

            int compressed_size = PRSCompression.GetMaxCompressedSize(data.Length);
            ctx.ResizeDst(compressed_size);

            PRSCompression.Compress(ctx, hash);

            ctx.ResizeDst(ctx.dst_pos);
            return ctx.GetDst();
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
            ctx.ResizeDst(decompressed_size);
            ctx.Reset();

            PRSDecompression.Decompress(ctx, false);

            return ctx.GetDst();
        }
    }
}
