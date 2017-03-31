namespace Libraries.PRS
{
    class PRSCompression
    {
        internal static void Compress(Context ctx, HashTable ht)
        {
            ctx.flag_pos = ctx.dst_pos;

            ht.Set(ht.Hash(ctx.src, 0), 0);
            ht.Set(ht.Hash(ctx.src, 1), 1);

            SetBit(ctx, 1);
            CopyLiteral(ctx);
            SetBit(ctx, 1);
            CopyLiteral(ctx);

            int offset1 = 0;
            int offset2 = 0;

            while (ctx.src_pos < ctx.src.Length - 1)
            {
                int mlen1 = FindLongestMatch(ctx, ht, ref offset1, false);

                // Is there a match?
                if (mlen1 != 0)
                {
                    ctx.src_pos += 1;
                    int mlen2 = FindLongestMatch(ctx, ht, ref offset2, true);
                    ctx.src_pos -= 1;

                    // Did the "lazy match" produce something more compressed?
                    if (mlen2 > mlen1)
                    {
                        bool copy_literal = true;
                        // Check if it is a good idea to switch from a short match to a long one.
                        if (mlen1 >= 2 && mlen1 <= 5 && offset2 < offset1)
                        {
                            if (offset1 >= -256 && offset2 < -256)
                            {
                                if (mlen2 - mlen1 < 3)
                                {
                                    copy_literal = false;
                                }
                            }
                        }

                        if (copy_literal)
                        {
                            SetBit(ctx, 1);
                            CopyLiteral(ctx);
                            continue;
                        }
                    }

                    // What kind of match did we find?
                    if (mlen1 >= 2 && mlen1 <= 5 && offset1 >= -256)
                    {
                        // Short match.
                        SetBit(ctx, 0);
                        SetBit(ctx, 0);
                        SetBit(ctx, (mlen1 - 2) & 0x02);
                        SetBit(ctx, (mlen1 - 2) & 0x01);
                        WriteLiteral(ctx, (byte)(offset1));
                        AddIntermediates(ctx, ht, mlen1);
                        ctx.src_pos += mlen1;
                        continue;
                    }
                    else if (mlen1 >= 3 && mlen1 <= 9)
                    {
                        // Long match, short length.
                        SetBit(ctx, 0);
                        SetBit(ctx, 1);
                        WriteLiteral(ctx, (byte)(((offset1 & 0x1F) << 3) | ((mlen1 - 2) & 0x07)));
                        WriteLiteral(ctx, (byte)(offset1 >> 5));
                        AddIntermediates(ctx, ht, mlen1);
                        ctx.src_pos += mlen1;
                        continue;
                    }
                    else if (mlen1 > 9)
                    {
                        // Long match, long length.
                        if (mlen1 > 256)
                        {
                            mlen1 = 256;
                        }

                        SetBit(ctx, 0);
                        SetBit(ctx, 1);
                        WriteLiteral(ctx, (byte)((offset1 & 0x1F) << 3));
                        WriteLiteral(ctx, (byte)(offset1 >> 5));
                        WriteLiteral(ctx, (byte)(mlen1 - 1));
                        AddIntermediates(ctx, ht, mlen1);
                        ctx.src_pos += mlen1;
                        continue;
                    }
                }

                SetBit(ctx, 1);
                CopyLiteral(ctx);
            }

            if (ctx.src_pos < ctx.src.Length)
            {
                SetBit(ctx, 1);
                CopyLiteral(ctx);
            }

            WriteEOF(ctx);

            ctx.ResizeDst(ctx.dst_pos);
        }

        internal static int GetMaxCompressedSize(int length)
        {
            length += 2;
            return length + (length >> 3) + ((length & 0x07) == 0 ? 0 : 1);
        }

        internal static void SetBit(Context ctx, int bit)
        {
            if (ctx.bit_pos-- == 0)
            {
                ctx.dst[ctx.flag_pos] = ctx.flags;
                ctx.flag_pos = ctx.dst_pos;
                ctx.dst_pos += 1;
                ctx.bit_pos = 7;
            }

            ctx.flags >>= 1;
            if (bit != 0)
            {
                ctx.flags |= 0x80;
            }
        }
        internal static void CopyLiteral(Context ctx)
        {
            ctx.dst[ctx.dst_pos] = ctx.src[ctx.src_pos];
            ctx.src_pos += 1;
            ctx.dst_pos += 1;
        }
        internal static void WriteLiteral(Context ctx, byte value)
        {
            ctx.dst[ctx.dst_pos] = value;
            ctx.dst_pos += 1;
        }
        internal static void WriteFinalFlags(Context ctx)
        {
            ctx.flags >>= ctx.bit_pos;
            ctx.dst[ctx.flag_pos] = ctx.flags;
        }
        internal static void WriteEOF(Context ctx)
        {
            SetBit(ctx, 0);
            SetBit(ctx, 1);
            WriteFinalFlags(ctx);
            WriteLiteral(ctx, 0);
            WriteLiteral(ctx, 0);
        }

        internal static int MatchLength(Context ctx, int? s2)
        {
            int length = 0;
            int s1 = ctx.src_pos;
            int end = ctx.src.Length;

            while (s1 < end && ctx.src[s1] == ctx.src[(int)s2])
            {
                length += 1;
                s1 += 1;
                s2 += 1;
            }
            return length;
        }
        internal static int FindLongestMatch(Context ctx, HashTable ht, ref int pos, bool lazy)
        {
            if (ctx.src_pos >= ctx.src.Length)
            {
                return 0;
            }

            // Figure out where we're looking.
            byte hash = ht.Hash(ctx.src, ctx.src_pos);
            int? ent1 = ht.Get(hash);

            // Is there in nothing in the table at that point, bail out now.
            if (ent1 == null)
            {
                if (lazy == false)
                {
                    ht.Set(hash, ctx.src_pos);
                }
                return 0;
            }

            // If we'd go outside the window, truncate the hash chain now.
            if (ctx.src_pos - ent1 > HashTable.MaxWindow)
            {
                ht.hash[hash] = null;
                if (lazy == false)
                {
                    ht.Set(hash, ctx.src_pos);
                }
                return 0;
            }

            // Ok, we have something in the hash table that matches the hash value. 
            // Follow the chain to see if we do, and find the longest match.
            int longest_length = 0;
            int? longest_match = null;

            while (ent1 != null)
            {
                int mlen = MatchLength(ctx, ent1);
                if (mlen > 0)
                {
                    if (mlen > longest_length || mlen >= 256)
                    {
                        longest_length = mlen;
                        longest_match = ent1;
                    }
                }

                // Follow the chain, making sure not to exceed a difference of MaxWindow.
                int? ent2 = ht.GetPrev(ent1);
                if (ent2 != null)
                {
                    // If we'd go outside the window, truncate the hash chain now.
                    if (ctx.src_pos - ent2 > HashTable.MaxWindow)
                    {
                        ht.SetPrev(ent1, null);
                        ent2 = null;
                    }
                }

                // Follow the chain for the next pass.
                ent1 = ent2;
            }

            // Add our current string to the hash.
            if (lazy == false)
            {
                ht.Set(hash, ctx.src_pos);
            }

            // Did we find a match?
            if (longest_length > 0)
            {
                pos = (int)(longest_match - ctx.src_pos);
            }

            return longest_length;
        }
        internal static void AddIntermediates(Context ctx, HashTable ht, int lengh)
        {
            for (int i1 = 1; i1 < lengh; ++i1)
            {
                byte hash = ht.Hash(ctx.src, ctx.src_pos + i1);
                ht.Set(hash, ctx.src_pos + i1);
            }
        }
    }
}
