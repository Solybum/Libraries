using System;

namespace Libraries.ByteArray
{
    /// <summary>
    /// Wrapper to ease data type conversions to and from <see cref="byte"/> arrays
    /// </summary>
    public partial class ByteArray
    {
        private byte[] _buffer;
        private int _position;
        private Endianess _endianess;

        /// <summary>
        /// Reference to the internal buffer
        /// </summary>
        public byte[] Buffer
        {
            get { return _buffer; }
        }
        /// <summary>
        /// Length of the internal buffer
        /// </summary>
        public int Length
        {
            get { return _buffer.Length; }
        }
        /// <summary>
        /// Position in the internal buffer
        /// </summary>
        public int Position
        {
            get { return _position; }
            set
            {
                if (value < 0 || value > _buffer.Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                _position = value;
            }
        }
        /// <summary>
        /// Current endianess
        /// </summary>
        public Endianess Endianess { get; set; }

        /// <summary>
        /// Default constructor.
        /// Little endian by default
        /// </summary>
        /// <param name="size">Size for the internal buffer</param>
        public ByteArray(int size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }
            _buffer = new byte[size];
            _endianess = Endianess.LittleEndian;
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
            _buffer = new byte[size];
            _endianess = endianess;
        }
        /// <summary>
        /// Alternative constructor to act as a wrapper for a byte array
        /// </summary>
        /// <param name="byteArray">Array reference to use as backing array</param>
        public ByteArray(byte[] byteArray)
        {
            _buffer = byteArray ?? throw new ArgumentNullException(nameof(byteArray));
        }
        /// <summary>
        /// Alternative constructor to act as a wrapper for a byte array, with endianess
        /// </summary>
        /// <param name="byteArray">Array reference to use as backing array</param>
        public ByteArray(byte[] byteArray, Endianess endianess)
        {
            if (byteArray == null)
            {
                throw new ArgumentNullException(nameof(byteArray));
            }
            _buffer = byteArray;
            _endianess = endianess;
        }

        /// <summary>
        /// Change the size of the internal array
        /// </summary>
        /// <param name="size">New size of the internal array</param>
        public void Resize(int size)
        {
            if (size == _buffer.Length)
            {
                return;
            }
            if (size < 0 || size > int.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(size));
            }

            Array.Resize(ref _buffer, size);
            if (_position > size)
            {
                _position = size;
            }
        }

        /// <summary>
        /// Sets all the elements of the array to their default value
        /// </summary>
        public void Clear()
        {
            this.Clear(0, _buffer.Length);
        }
        /// <summary>
        /// Sets a range of elements from the array to their default value
        /// </summary>
        /// <param name="index">The starting index of the elements to be cleared</param>
        /// <param name="length">The number of elements to clear</param>
        public void Clear(int index, int length)
        {
            Array.Clear(_buffer, index, length);
        }

        /// <summary>
        /// Fills all the byte array with the provided value
        /// </summary>
        /// <param name="value"></param>
        public void Fill(byte value)
        {
            this.Fill(value, 0, _buffer.Length);
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
                _buffer[i1] = value;
            }
        }

        /// <summary>
        /// Show up to 16 bytes from the current position
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            int tslen = Length - _position;
            if (tslen > 16)
            {
                tslen = 16;
            }
            return string.Format("0x{0:X8}: {1}", _position, BitConverter.ToString(_buffer, _position, tslen).Replace("-", " "));
        }

        /// <summary>
        /// Indexer to access the individual bytes
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public byte this[int offset]
        {
            get { return _buffer[offset]; }
            set { _buffer[offset] = value; }
        }

        /// <summary>
        /// Advances the internal position until the pad boundary is met, zeroing the padded bytes in the process
        /// </summary>
        /// <param name="padding">Number of bytes to pad</param>
        public void Pad(int padding)
        {
            while ((_position % padding) != 0 && _position < _buffer.Length)
            {
                _buffer[_position++] = 0;
            }
        }
    }
}
