namespace Libraries.PRS
{
    class PRSDecompression
    {
        internal static int Decompress(Context ctx, bool size_only)
        {
            int flag = 0;
            int size = 0;
            int offset = 0;

            // Invert
            size_only = !size_only;

            while (true)
            {
                // Read the flag bit for this pass.
                flag = ReadBit(ctx);

                if (flag == 1)
                {
                    // Flag bit = 1 -> Simple byte copy from src to dst.
                    CopyByte(ctx, size_only);
                }
                else
                {
                    // The flag starts with a zero, so it isn't just a simple byte copy.
                    // Read the next bit to see what we have left to do.
                    flag = ReadBit(ctx);
                    
                    if (flag == 0)
                    {
                        // Flag bit = 0 -> short copy.

                        // Fetch the two bits needed to determine the size.
                        flag = ReadBit(ctx);
                        size = ReadBit(ctx);
                        size = (size | (flag << 1)) + 2;

                        // Fetch the offset byte.
                        offset = ReadByte(ctx);
                        offset = (int)(offset | 0xFFFFFF00);
                    }
                    else
                    {
                        // Flag bit = 1->Either long copy or end of file.

                        offset = ReadShort(ctx);

                        // Two zero bytes implies that this is the end of the file.
                        if (offset == 0)
                        {
                            break;
                        }

                        // Do we need to read a size byte, or is it encoded in what we already got?
                        size = offset & 7;
                        offset >>= 3;

                        if (size == 0)
                        {
                            size = ReadByte(ctx);
                            size += 1;
                        }
                        else
                        {
                            size += 2;
                        }

                        offset = (int)(offset | 0xFFFFE000);
                    }

                    // Copy the data.
                    while (size > 0)
                    {
                        CopyByteAt(ctx, size_only, offset);
                        size -= 1;
                    }
                }
            }
            return ctx.GetDstPostion();
        }

        internal static int ReadBit(Context ctx)
        {
            int result;

            if (ctx.bit_pos == 0)
            {
                ctx.flags = ctx.src[ctx.src_pos];
                ctx.src_pos += 1;
                ctx.bit_pos = 8;
            }
            result = ctx.flags & 1;
            ctx.flags >>= 1;
            ctx.bit_pos -= 1;
            return result;
        }
        internal static int ReadByte(Context ctx)
        {
            int result;
            result = ctx.src[ctx.src_pos];
            ctx.src_pos += 1;
            return result;
        }
        internal static int ReadShort(Context ctx)
        {
            int result;
            result = ctx.src[ctx.src_pos] + (ctx.src[ctx.src_pos + 1] << 8);
            ctx.src_pos += 2;
            return result;
        }

        internal static void CopyByte(Context ctx, bool copy)
        {
            if (copy)
            {
                ctx.dst[ctx.dst_pos] = ctx.src[ctx.src_pos];
            }
            ctx.src_pos += 1;
            ctx.dst_pos += 1;
        }
        internal static void CopyByteAt(Context ctx, bool copy, int offset)
        {
            if (copy)
            {
                ctx.dst[ctx.dst_pos] = ctx.dst[ctx.dst_pos + offset];
            }
            ctx.dst_pos += 1;
        }
    }
}
