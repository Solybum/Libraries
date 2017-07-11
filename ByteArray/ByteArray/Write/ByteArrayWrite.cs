using System;

namespace Libraries.ByteArray
{
    public partial class ByteArray
    {
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(bool value, int position)
        {
            this._buffer[position] = (byte)(value ? 1 : 0);
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(sbyte value, int position)
        {
            this._buffer[position] = (byte)value;
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(byte value, int position)
        {
            this._buffer[position] = value;
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(short value, int position)
        {
            if (this._endianess == Endianess.BigEndian)
            {
                this._buffer[position + 1] = (byte)value;
                this._buffer[position + 0] = (byte)(value >> 8);
            }
            else
            {
                this._buffer[position + 0] = (byte)value;
                this._buffer[position + 1] = (byte)(value >> 8);
            }
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(ushort value, int position)
        {
            if (this._endianess == Endianess.BigEndian)
            {
                this._buffer[position + 1] = (byte)value;
                this._buffer[position + 0] = (byte)(value >> 8);
            }
            else
            {
                this._buffer[position + 0] = (byte)value;
                this._buffer[position + 1] = (byte)(value >> 8);
            }
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(int value, int position)
        {
            if (this._endianess == Endianess.BigEndian)
            {
                this._buffer[position + 3] = (byte)value;
                this._buffer[position + 2] = (byte)(value >> 8);
                this._buffer[position + 1] = (byte)(value >> 16);
                this._buffer[position + 0] = (byte)(value >> 24);
            }
            else
            {
                this._buffer[position + 0] = (byte)value;
                this._buffer[position + 1] = (byte)(value >> 8);
                this._buffer[position + 2] = (byte)(value >> 16);
                this._buffer[position + 3] = (byte)(value >> 24);
            }
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(uint value, int position)
        {
            if (this._endianess == Endianess.BigEndian)
            {
                this._buffer[position + 3] = (byte)value;
                this._buffer[position + 2] = (byte)(value >> 8);
                this._buffer[position + 1] = (byte)(value >> 16);
                this._buffer[position + 0] = (byte)(value >> 24);
            }
            else
            {
                this._buffer[position + 0] = (byte)value;
                this._buffer[position + 1] = (byte)(value >> 8);
                this._buffer[position + 2] = (byte)(value >> 16);
                this._buffer[position + 3] = (byte)(value >> 24);
            }
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(long value, int position)
        {
            if (this._endianess == Endianess.BigEndian)
            {
                this._buffer[position + 7] = (byte)value;
                this._buffer[position + 6] = (byte)(value >> 8);
                this._buffer[position + 5] = (byte)(value >> 16);
                this._buffer[position + 4] = (byte)(value >> 24);
                this._buffer[position + 3] = (byte)(value >> 32);
                this._buffer[position + 2] = (byte)(value >> 40);
                this._buffer[position + 1] = (byte)(value >> 48);
                this._buffer[position + 0] = (byte)(value >> 56);
            }
            else
            {
                this._buffer[position + 0] = (byte)value;
                this._buffer[position + 1] = (byte)(value >> 8);
                this._buffer[position + 2] = (byte)(value >> 16);
                this._buffer[position + 3] = (byte)(value >> 24);
                this._buffer[position + 4] = (byte)(value >> 32);
                this._buffer[position + 5] = (byte)(value >> 40);
                this._buffer[position + 6] = (byte)(value >> 48);
                this._buffer[position + 7] = (byte)(value >> 56);
            }
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(ulong value, int position)
        {
            if (this._endianess == Endianess.BigEndian)
            {
                this._buffer[position + 7] = (byte)value;
                this._buffer[position + 6] = (byte)(value >> 8);
                this._buffer[position + 5] = (byte)(value >> 16);
                this._buffer[position + 4] = (byte)(value >> 24);
                this._buffer[position + 3] = (byte)(value >> 32);
                this._buffer[position + 2] = (byte)(value >> 40);
                this._buffer[position + 1] = (byte)(value >> 48);
                this._buffer[position + 0] = (byte)(value >> 56);
            }
            else
            {
                this._buffer[position + 0] = (byte)value;
                this._buffer[position + 1] = (byte)(value >> 8);
                this._buffer[position + 2] = (byte)(value >> 16);
                this._buffer[position + 3] = (byte)(value >> 24);
                this._buffer[position + 4] = (byte)(value >> 32);
                this._buffer[position + 5] = (byte)(value >> 40);
                this._buffer[position + 6] = (byte)(value >> 48);
                this._buffer[position + 7] = (byte)(value >> 56);
            }
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(float value, int position)
        {
            if (this._endianess == Endianess.BigEndian)
            {
                Array.Copy(BitConverter.GetBytes(value), 0, this._temp, 0, 4);
                this._buffer[position + 3] = this._temp[0];
                this._buffer[position + 2] = this._temp[1];
                this._buffer[position + 1] = this._temp[2];
                this._buffer[position + 0] = this._temp[3];
            }
            else
            {
                Array.Copy(BitConverter.GetBytes(value), 0, this._buffer, position, 4);
            }
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(double value, int position)
        {
            if (this._endianess == Endianess.BigEndian)
            {
                Array.Copy(BitConverter.GetBytes(value), 0, this._temp, 0, 8);
                this._buffer[position + 7] = this._temp[0];
                this._buffer[position + 6] = this._temp[1];
                this._buffer[position + 5] = this._temp[2];
                this._buffer[position + 4] = this._temp[3];
                this._buffer[position + 3] = this._temp[4];
                this._buffer[position + 2] = this._temp[5];
                this._buffer[position + 1] = this._temp[6];
                this._buffer[position + 0] = this._temp[7];
            }
            else
            {
                Array.Copy(BitConverter.GetBytes(value), 0, this._buffer, position, 8);
            }
        }
        
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(bool value)
        {
            this.Write(value, this._position);
            this._position += 1;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(sbyte value)
        {
            this.Write(value, this._position);
            this._position += 1;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(byte value)
        {
            this._buffer[this._position] = value;
            this._position += 1;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(short value)
        {
            this.Write(value, this._position);
            this._position += 2;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(ushort value)
        {
            this.Write(value, this._position);
            this._position += 2;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(int value)
        {
            this.Write(value, this._position);
            this._position += 4;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(uint value)
        {
            this.Write(value, this._position);
            this._position += 4;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(long value)
        {
            this.Write(value, this._position);
            this._position += 8;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(ulong value)
        {
            this.Write(value, this._position);
            this._position += 8;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(float value)
        {
            this.Write(value, this._position);
            this._position += 4;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(double value)
        {
            this.Write(value, this._position);
            this._position += 8;
        }
    }
}
