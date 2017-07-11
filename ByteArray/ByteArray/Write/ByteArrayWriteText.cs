using System;

namespace Libraries.ByteArray
{
    public partial class ByteArray
    {
        /// <summary>
        /// Writes a 1 byte <see cref="char"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void WriteCharA(char value, int position)
        {
            this._buffer[position] = Convert.ToByte(value);
        }
        /// <summary>
        /// Writes a 2 byte <see cref="char"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void WriteCharW(char value, int position)
        {
            ushort tmp = Convert.ToUInt16(value);
            this._buffer[position + 0] = (byte)tmp;
            this._buffer[position + 1] = (byte)(tmp >> 8);
        }

        /// <summary>
        /// Writes a 1 byte <see cref="char"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void WriteCharA(char value)
        {
            this.WriteCharA(value, this._position);
            this._position += 1;
        }
        /// <summary>
        /// Writes a 2 byte <see cref="char"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void WriteCharW(char value)
        {
            this.WriteCharW(value, this._position);
            this._position += 2;
        }

        /// <summary>
        /// Writes an ASCII string, without advancing the internal position.
        /// If the string lenght is less than the target length, the remaining bytes will be set to zero (null)
        /// </summary>
        /// <param name="text">String to write to the byte array</param>
        /// <param name="index">Starting position of the string</param>
        /// <param name="length">Amount of characters to write</param>
        /// <param name="nullTerminated">Appends a null character to the end of the string, this character is not counted in the length parameter</param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void WriteStringA(string text, int index, int length, bool nullTerminated, int position)
        {
            length += index;
            while ((index < length) && (index < text.Length))
            {
                WriteCharA(text[index], position);
                position += 1;
                index++;
            }
            while (index < length)
            {
                WriteCharA('\0', position);
                position += 1;
                index++;
            }
            if (nullTerminated)
            {
                WriteCharA('\0', position);
            }
        }
        /// <summary>
        /// Writes an UNICODE string, without advancing the internal position.
        /// If the string lenght is less than the target length, the remaining bytes will be set to zero (null)
        /// </summary>
        /// <param name="text">String to write to the byte array</param>
        /// <param name="index">Starting position of the string</param>
        /// <param name="length">Amount of characters to write</param>
        /// <param name="nullTerminated">Appends a null character to the end of the string, this character is not counted in the length parameter</param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void WriteStringW(string text, int index, int length, bool nullTerminated, int position)
        {
            length += index;
            while ((index < length) && (index < text.Length))
            {
                WriteCharW(text[index], position);
                position += 2;
                index++;
            }
            while (index < length)
            {
                WriteCharW('\0', position);
                position += 2;
                index++;
            }
            if (nullTerminated)
            {
                WriteCharW('\0', position);
            }
        }

        /// <summary>
        /// Writes an ASCII string, advancing the internal position.
        /// If the string lenght is less than the target length, the remaining bytes will be set to zero (null)
        /// </summary>
        /// <param name="text">String to write to the byte array</param>
        /// <param name="index">Starting position of the string</param>
        /// <param name="length">Amount of characters to write</param>
        /// <param name="nullTerminated">Appends a null character to the end of the string, this character is not counted in the length parameter</param>
        /// <returns></returns>
        public void WriteStringA(string text, int index, int length, bool nullTerminated)
        {
            this.WriteStringA(text, index, length, nullTerminated, this._position);
            this._position += length;
            if (nullTerminated)
            {
                this._position += 1;
            }
        }
        /// <summary>
        /// Writes an UNICODE string, advancing the internal position.
        /// If the string lenght is less than the target length, the remaining bytes will be set to zero (null)
        /// </summary>
        /// <param name="text">String to write to the byte array</param>
        /// <param name="index">Starting position of the string</param>
        /// <param name="length">Amount of characters to write</param>
        /// <param name="nullTerminated">Appends a null character to the end of the string, this character is not counted in the length parameter</param>
        /// <returns></returns>
        public void WriteStringW(string text, int index, int length, bool nullTerminated)
        {
            this.WriteStringW(text, index, length, nullTerminated, this._position);
            this._position += (length * 2);
            if (nullTerminated)
            {
                this._position += 2;
            }
        }
    }
}
