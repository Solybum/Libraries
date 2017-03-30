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

using System;
using System.IO;

namespace prs
{
    public static partial class Prs
    {
        public static byte[] Decompress(byte[] sourceData)
        {
            using (MemoryStream input = new MemoryStream(sourceData))
            {
                using (MemoryStream output = new MemoryStream())
                {
                    Decompress(input, output);
                    return output.ToArray();
                }
            }
        }
        public static void Decompress(Stream input, Stream output)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (output == null)
            {
                throw new ArgumentNullException("output");
            }

            Decode(input, output);
        }

        public static byte[] Compress(byte[] sourceData)
        {
            using (MemoryStream output = new MemoryStream())
            {
                Encode(sourceData, output);
                return output.ToArray();
            }
        }
        public static void Compress(Stream input, Stream output)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (output == null)
            {
                throw new ArgumentNullException("output");
            }

            long size = input.Length - input.Position;
            byte[] inputBytes = new byte[size];
            input.Read(inputBytes, 0, checked((int)size));

            Encode(inputBytes, output);
        }
    }
}
