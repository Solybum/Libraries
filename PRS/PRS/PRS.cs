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
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Decompress a byte array and return the processed data in a new byte array
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Decompress(byte[] data)
        {
            Context ctx = new Context(data);

            // Get decompressed size, no more no less
            int decompressed_size = PRSDecompression.Decompress(ctx, true);
            // Set the destination buffer
            ctx.ResizeDst(decompressed_size);
            // Reset the flags and positions
            ctx.Reset();
            // Now do the thing
            PRSDecompression.Decompress(ctx, false);
            // Return the decompressed data
            return ctx.GetDst();
        }
    }
}
