using System;

namespace Libraries.ByteArray
{
    /// <summary>
    /// Wrapper to ease data type conversions to and from <see cref="byte"/> arrays
    /// </summary>
    public partial class ByteArray
    {
        /// <summary>
        /// Temporary buffer for floats.
        /// It's initialized right away
        /// </summary>
        private byte[] _temp = new byte[8];
        /// <summary>
        /// Internal buffer
        /// </summary>
        private byte[] _buffer;
        /// <summary>
        /// Internal position
        /// </summary>
        private int _position;
        /// <summary>
        /// Internal endianess
        /// </summary>
        private Endianess _endianess;

        /// <summary>
        /// Reference to the internal buffer
        /// </summary>
        public byte[] Buffer
        {
            get { return this._buffer; }
        }
        /// <summary>
        /// Length of the internal buffer
        /// </summary>
        public int Length
        {
            get { return this._buffer.Length; }
        }
        /// <summary>
        /// Position in the internal buffer
        /// </summary>
        public int Position
        {
            get { return this._position; }
            set
            {
                if (value < 0 || value > this._buffer.Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                this._position = value;
            }
        }
        /// <summary>
        /// Current endianess
        /// </summary>
        public Endianess Endianess
        {
            get { return this._endianess; }
            set { this._endianess = value; }
        }

        /// <summary>
        /// Default constructor.
        /// Little endian by default
        /// </summary>
        /// <param name="size">Size for the internal buffer</param>
        public ByteArray(int size) : this(size, Endianess.LittleEndian)
        {
        }
        /// <summary>
        /// Constructor with endianess.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="endianess"></param>
        public ByteArray(int size, Endianess endianess)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }
            this._buffer = new byte[size];
            this._endianess = endianess;
        }
        /// <summary>
        /// Alternative constructor to act as a wrapper for a byte array
        /// </summary>
        /// <param name="byteArray">Array reference to use as backing array</param>
        public ByteArray(byte[] byteArray) : this(byteArray, Endianess.LittleEndian)
        {
        }
        /// <summary>
        /// Alternative constructor to act as a wrapper for a byte array, with endianess
        /// </summary>
        /// <param name="byteArray">Array reference to use as backing array</param>
        /// <param name="endianess"></param>
        public ByteArray(byte[] byteArray, Endianess endianess)
        {
            if (byteArray == null)
            {
                throw new ArgumentNullException(nameof(byteArray));
            }
            this._buffer = byteArray;
            this._endianess = endianess;
        }

        /// <summary>
        /// Change the size of the internal array
        /// </summary>
        /// <param name="size">New size of the internal array</param>
        public void Resize(int size)
        {
            if (size == this._buffer.Length)
            {
                return;
            }
            if (size < 0 || size > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }

            Array.Resize(ref this._buffer, size);
            if (this._position > size)
            {
                this._position = size;
            }
        }

        /// <summary>
        /// Sets all the elements of the array to their default value
        /// </summary>
        public void Clear()
        {
            this.Clear(0, this._buffer.Length);
        }
        /// <summary>
        /// Sets a range of elements from the array to their default value
        /// </summary>
        /// <param name="index">The starting index of the elements to be cleared</param>
        /// <param name="length">The number of elements to clear</param>
        public void Clear(int index, int length)
        {
            Array.Clear(this._buffer, index, length);
        }

        /// <summary>
        /// Fills all the byte array with the provided value
        /// </summary>
        /// <param name="value"></param>
        public void Fill(byte value)
        {
            this.Fill(value, 0, this._buffer.Length);
        }
        /// <summary>
        /// Fills a range of elements from the byte array with the provided value starting at index
        /// </summary>
        /// <param name="value">Value to fill in the byte array</param>
        /// <param name="index">Index to start the fill operation</param>
        /// <param name="length">Amount of byes to fill</param>
        public void Fill(byte value, int index, int length)
        {
            for (int i1 = index; i1 < length; i1++)
            {
                this._buffer[i1] = value;
            }
        }

        /// <summary>
        /// Show up to 16 bytes from the current position
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            int tslen = this.Length - this._position;
            if (tslen > 16)
            {
                tslen = 16;
            }
            return string.Format("0x{0:X8}: {1}", this._position, BitConverter.ToString(this._buffer, this._position, tslen).Replace("-", " "));
        }

        /// <summary>
        /// Indexer to access the individual bytes
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public byte this[int offset]
        {
            get { return this._buffer[offset]; }
            set { this._buffer[offset] = value; }
        }

        /// <summary>
        /// Advances the internal position until the pad boundary 
        /// is met or the end of the buffer is reached, zeroing 
        /// the padded bytes in the process
        /// </summary>
        /// <param name="padding">Number of bytes to pad</param>
        public void Pad(int padding)
        {
            while ((this._position % padding) != 0 && this._position < this._buffer.Length)
            {
                this._buffer[this._position++] = 0;
            }
        }
    }
}
