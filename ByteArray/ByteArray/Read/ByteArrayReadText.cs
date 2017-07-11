using System;

namespace Libraries.ByteArray
{
    public partial class ByteArray
    {
        /// <summary>
        /// Reads a 1 byte <see cref="char"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public char ReadCharA(int position)
        {
            char result = Convert.ToChar(this._buffer[position]);
            return result;
        }
        /// <summary>
        /// Reads a 2 byte <see cref="char"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public char ReadCharW(int position)
        {
            char result = Convert.ToChar(this._buffer[position + 0] | this._buffer[position + 1] << 8);
            return result;
        }

        /// <summary>
        /// Reads a 1 byte <see cref="char"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public char ReadCharA()
        {
            char result = this.ReadCharA(this._position);
            this._position += 1;
            return result;
        }
        /// <summary>
        /// Reads a 2 byte <see cref="char"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public char ReadCharW()
        {
            char result = this.ReadCharW(this._position);
            this._position += 2;
            return result;
        }

        /// <summary>
        /// Reads an ASCII string until the target length is reached or null character is found, without advancing the internal position
        /// </summary>
        /// <param name="length">Characters to read, use -1 for unlimited length</param>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public string ReadStringA(int length, int position)
        {
            string result = "";
            while (length == -1 || result.Length < length)
            {
                if (this._buffer[position] == 0)
                {
                    break;
                }
                result += ReadCharA(position);
                position += 1;
            }
            return result;
        }
        /// <summary>
        /// Reads an UNICODE string until the target length is reached or null character is found, without advancing the internal position
        /// </summary>
        /// <param name="length">Characters to read, use -1 for unlimited length</param>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public string ReadStringW(int length, int position)
        {
            string result = "";
            while (length == -1 || result.Length < length)
            {
                if (this._buffer[position] == 0)
                {
                    break;
                }
                result += ReadCharW(position);
                position += 2;
            }
            return result;
        }

        /// <summary>
        /// Reads an ASCII string until the target length is reached or null character is found, advancing the internal position
        /// </summary>
        /// <param name="length">Characters to read, use -1 for unlimited length</param>
        /// <returns></returns>
        public string ReadStringA(int length)
        {
            string result = this.ReadStringA(length, this._position);
            if (length == -1)
            {
                this._position += result.Length;
            }
            else
            {
                this._position += length;
            }
            return result;
        }
        /// <summary>
        /// Reads an UNICODE string until the target length is reached or null character is found, advancing the internal position
        /// </summary>
        /// <param name="length">Characters to read, use -1 for unlimited length</param>
        /// <returns></returns>
        public string ReadStringW(int length)
        {
            string result = this.ReadStringW(length, this._position);
            if (length == -1)
            {
                this._position += (result.Length * 2);
            }
            else
            {
                this._position += (length * 2);
            }
            return result;
        }
    }
}
