// Copyright (c) 2012, Francis Gagné
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
//     * Redistributions of source code must retain the above copyright
//       notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright
//       notice, this list of conditions and the following disclaimer in the
//       documentation and/or other materials provided with the distribution.
//     * Neither the name of the <organization> nor the
//       names of its contributors may be used to endorse or promote products
//       derived from this software without specific prior written permission.

using System.IO;

namespace Libraries.PRS
{
    class PRSCompression
    {
        internal static void Encode(byte[] source, Stream destination)
        {
            byte bitPos = 0;
            byte controlByte = 0;

            int position = 0;
            int currentLookBehindPosition, currentLookBehindLength;
            int lookBehindOffset, lookBehindLength;

            MemoryStream data = new MemoryStream();

            while (position < source.Length)
            {
                currentLookBehindLength = 0;
                lookBehindOffset = 0;
                lookBehindLength = 0;

                for (currentLookBehindPosition = position - 1;
                    (currentLookBehindPosition >= 0) &&
                    (currentLookBehindPosition >= position - 0x1FF0) &&
                    (lookBehindLength < 256);
                    currentLookBehindPosition--)
                {
                    currentLookBehindLength = 1;
                    if (source[currentLookBehindPosition] == source[position])
                    {
                        do
                        {
                            currentLookBehindLength++;
                        } while ((currentLookBehindLength <= 256) &&
                            (position + currentLookBehindLength <= source.Length) &&
                            source[currentLookBehindPosition + currentLookBehindLength - 1] == source[position + currentLookBehindLength - 1]);

                        currentLookBehindLength--;
                        if (((currentLookBehindLength >= 2 && currentLookBehindPosition - position >= -0x100) || currentLookBehindLength >= 3) && currentLookBehindLength > lookBehindLength)
                        {
                            lookBehindOffset = currentLookBehindPosition - position;
                            lookBehindLength = currentLookBehindLength;
                        }
                    }
                }

                if (lookBehindLength == 0)
                {
                    data.WriteByte(source[position++]);
                    PutControlBit(1, ref controlByte, ref bitPos, data, destination);
                }
                else
                {
                    Copy(lookBehindOffset, lookBehindLength, ref controlByte, ref bitPos, data, destination);
                    position += lookBehindLength;
                }
            }

            // EOF
            PutControlBit(0, ref controlByte, ref bitPos, data, destination);
            PutControlBit(1, ref controlByte, ref bitPos, data, destination);
            if (bitPos != 0)
            {
                controlByte = (byte)((controlByte << bitPos) >> 8);
                Flush(ref controlByte, ref bitPos, data, destination);
            }

            destination.WriteByte(0);
            destination.WriteByte(0);
            // End EOF
        }

        internal static void Copy(int offset, int size, ref byte controlByte, ref byte bitPos, MemoryStream data, Stream destination)
        {
            if ((offset >= -0x100) && (size <= 5))
            {
                size -= 2;
                PutControlBit(0, ref controlByte, ref bitPos, data, destination);
                PutControlBit(0, ref controlByte, ref bitPos, data, destination);
                PutControlBit((size >> 1) & 1, ref controlByte, ref bitPos, data, destination);
                data.WriteByte((byte)(offset & 0xFF));
                PutControlBit(size & 1, ref controlByte, ref bitPos, data, destination);
            }
            else
            {
                if (size <= 9)
                {
                    PutControlBit(0, ref controlByte, ref bitPos, data, destination);
                    data.WriteByte((byte)(((offset << 3) & 0xF8) | ((size - 2) & 0x07)));
                    data.WriteByte((byte)((offset >> 5) & 0xFF));
                    PutControlBit(1, ref controlByte, ref bitPos, data, destination);
                }
                else
                {
                    PutControlBit(0, ref controlByte, ref bitPos, data, destination);
                    data.WriteByte((byte)((offset << 3) & 0xF8));
                    data.WriteByte((byte)((offset >> 5) & 0xFF));
                    data.WriteByte((byte)(size - 1));
                    PutControlBit(1, ref controlByte, ref bitPos, data, destination);
                }
            }
        }
        internal static void PutControlBit(int bit, ref byte controlByte, ref byte bitPos, MemoryStream data, Stream destination)
        {
            controlByte >>= 1;
            controlByte |= (byte)(bit << 7);
            bitPos++;
            if (bitPos >= 8)
            {
                Flush(ref controlByte, ref bitPos, data, destination);
            }
        }
        internal static void Flush(ref byte controlByte, ref byte bitPos, MemoryStream data, Stream destination)
        {
            destination.WriteByte(controlByte);
            controlByte = 0;
            bitPos = 0;

            byte[] bytes = data.ToArray();
            destination.Write(bytes, 0, bytes.Length);
            data.SetLength(0);
        }
    }
}
