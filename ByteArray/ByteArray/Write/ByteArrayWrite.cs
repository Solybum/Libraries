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
            _buffer[position] = (byte)(value ? 1 : 0);
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(sbyte value, int position)
        {
            _buffer[position] = (byte)value;
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(byte value, int position)
        {
            _buffer[position] = value;
        }
        /// <summary>
        /// Writes data without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index</param>
        /// <returns></returns>
        public void Write(short value, int position)
        {
            if (_endianess == Endianess.BigEndian)
            {
                _buffer[position + 1] = (byte)value;
                _buffer[position + 0] = (byte)(value >> 8);
            }
            else
            {
                _buffer[position + 0] = (byte)value;
                _buffer[position + 1] = (byte)(value >> 8);
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
            if (_endianess == Endianess.BigEndian)
            {
                _buffer[position + 1] = (byte)value;
                _buffer[position + 0] = (byte)(value >> 8);
            }
            else
            {
                _buffer[position + 0] = (byte)value;
                _buffer[position + 1] = (byte)(value >> 8);
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
            if (_endianess == Endianess.BigEndian)
            {
                _buffer[position + 3] = (byte)value;
                _buffer[position + 2] = (byte)(value >> 8);
                _buffer[position + 1] = (byte)(value >> 16);
                _buffer[position + 0] = (byte)(value >> 24);
            }
            else
            {
                _buffer[position + 0] = (byte)value;
                _buffer[position + 1] = (byte)(value >> 8);
                _buffer[position + 2] = (byte)(value >> 16);
                _buffer[position + 3] = (byte)(value >> 24);
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
            if (_endianess == Endianess.BigEndian)
            {
                _buffer[position + 3] = (byte)value;
                _buffer[position + 2] = (byte)(value >> 8);
                _buffer[position + 1] = (byte)(value >> 16);
                _buffer[position + 0] = (byte)(value >> 24);
            }
            else
            {
                _buffer[position + 0] = (byte)value;
                _buffer[position + 1] = (byte)(value >> 8);
                _buffer[position + 2] = (byte)(value >> 16);
                _buffer[position + 3] = (byte)(value >> 24);
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
            if (_endianess == Endianess.BigEndian)
            {
                _buffer[position + 7] = (byte)value;
                _buffer[position + 6] = (byte)(value >> 8);
                _buffer[position + 5] = (byte)(value >> 16);
                _buffer[position + 4] = (byte)(value >> 24);
                _buffer[position + 3] = (byte)(value >> 32);
                _buffer[position + 2] = (byte)(value >> 40);
                _buffer[position + 1] = (byte)(value >> 48);
                _buffer[position + 0] = (byte)(value >> 56);
            }
            else
            {
                _buffer[position + 0] = (byte)value;
                _buffer[position + 1] = (byte)(value >> 8);
                _buffer[position + 2] = (byte)(value >> 16);
                _buffer[position + 3] = (byte)(value >> 24);
                _buffer[position + 4] = (byte)(value >> 32);
                _buffer[position + 5] = (byte)(value >> 40);
                _buffer[position + 6] = (byte)(value >> 48);
                _buffer[position + 7] = (byte)(value >> 56);
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
            if (_endianess == Endianess.BigEndian)
            {
                _buffer[position + 7] = (byte)value;
                _buffer[position + 6] = (byte)(value >> 8);
                _buffer[position + 5] = (byte)(value >> 16);
                _buffer[position + 4] = (byte)(value >> 24);
                _buffer[position + 3] = (byte)(value >> 32);
                _buffer[position + 2] = (byte)(value >> 40);
                _buffer[position + 1] = (byte)(value >> 48);
                _buffer[position + 0] = (byte)(value >> 56);
            }
            else
            {
                _buffer[position + 0] = (byte)value;
                _buffer[position + 1] = (byte)(value >> 8);
                _buffer[position + 2] = (byte)(value >> 16);
                _buffer[position + 3] = (byte)(value >> 24);
                _buffer[position + 4] = (byte)(value >> 32);
                _buffer[position + 5] = (byte)(value >> 40);
                _buffer[position + 6] = (byte)(value >> 48);
                _buffer[position + 7] = (byte)(value >> 56);
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
            if (_endianess == Endianess.BigEndian)
            {
                Array.Copy(BitConverter.GetBytes(value), 0, _temp, 0, 4);
                _buffer[position + 3] = _temp[0];
                _buffer[position + 2] = _temp[1];
                _buffer[position + 1] = _temp[2];
                _buffer[position + 0] = _temp[3];
            }
            else
            {
                Array.Copy(BitConverter.GetBytes(value), 0, _buffer, position, 4);
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
            if (_endianess == Endianess.BigEndian)
            {
                Array.Copy(BitConverter.GetBytes(value), 0, _temp, 0, 8);
                _buffer[position + 7] = _temp[0];
                _buffer[position + 6] = _temp[1];
                _buffer[position + 4] = _temp[2];
                _buffer[position + 4] = _temp[3];
                _buffer[position + 3] = _temp[4];
                _buffer[position + 2] = _temp[5];
                _buffer[position + 1] = _temp[6];
                _buffer[position + 0] = _temp[7];
            }
            else
            {
                Array.Copy(BitConverter.GetBytes(value), 0, _buffer, position, 8);
            }
        }
        
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(bool value)
        {
            this.Write(value, _position);
            _position += 1;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(sbyte value)
        {
            this.Write(value, _position);
            _position += 1;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(byte value)
        {
            _buffer[_position] = value;
            _position += 1;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(short value)
        {
            this.Write(value, _position);
            _position += 2;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(ushort value)
        {
            this.Write(value, _position);
            _position += 2;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(int value)
        {
            this.Write(value, _position);
            _position += 4;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(uint value)
        {
            this.Write(value, _position);
            _position += 4;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(long value)
        {
            this.Write(value, _position);
            _position += 8;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(ulong value)
        {
            this.Write(value, _position);
            _position += 8;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(float value)
        {
            this.Write(value, _position);
            _position += 4;
        }
        /// <summary>
        /// Writes data advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(double value)
        {
            this.Write(value, _position);
            _position += 8;
        }
    }
}
