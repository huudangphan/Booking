using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Commons.Cryptography
{
    public class CRC64 : HashAlgorithm
    {
        public const UInt64 DefaultPolynomial = 0xD800000000000000;
        public const UInt64 DefaultSeed = 0xffffffffffffffff;
        private UInt64 hash;
        private UInt64 seed;
        private UInt64[] table;
        private static UInt64[] defaultTable;

        public CRC64()
        {
            table = InitializeTable(DefaultPolynomial);
            seed = DefaultSeed;
            Initialize();
        }
        public CRC64(UInt64 polynomial, UInt64 seed)
        {
            table = InitializeTable(polynomial);
            this.seed = seed;
            Initialize();
        }
        public override void Initialize()
        {
            hash = seed;
        }
        protected override void HashCore(byte[] buffer, int start, int length)
        {
            hash = CalculateHash(table, hash, buffer, start, length);
        }
        protected override byte[] HashFinal()
        {
            byte[] hashBuffer = UInt64ToBigEndianBytes(~hash);
            this.HashValue = hashBuffer;
            return hashBuffer;
        }
        public override int HashSize
        {
            get
            {
                return 64;
            }
        }
        public static UInt64 Compute(byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(DefaultPolynomial), DefaultSeed, buffer, 0, buffer.Length);
        }
        public static UInt64 Compute(UInt64 seed, byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(DefaultPolynomial), seed, buffer, 0, buffer.Length);
        }
        public static UInt64 Compute(UInt64 polynomial, UInt64 seed, byte[] buffer)
        {
            return ~CalculateHash(InitializeTable(polynomial), seed, buffer, 0, buffer.Length);
        }
        private static UInt64[] InitializeTable(UInt64 polynomial)
        {
            if (polynomial == DefaultPolynomial && defaultTable != null) return defaultTable;
            UInt64[] createTable = new UInt64[256];
            for (int i = 0; i < 256; i++)
            {
                UInt64 entry = (UInt64)i;
                for (int j = 0; j < 8; j++) if ((entry & 1) == 1) entry = (entry >> 1) ^ polynomial;
                    else entry = entry >> 1;
                createTable[i] = entry;
            }
            if (polynomial == DefaultPolynomial) defaultTable = createTable;
            return createTable;
        }
        private static UInt64 CalculateHash(UInt64[] table, UInt64 seed, byte[] buffer, int start, int size)
        {
            UInt64 crc = seed;
            for (int i = start; i < size; i++) unchecked
                {
                    crc = (crc >> 8) ^ table[buffer[i] ^ crc & 0xff];
                }
            return crc;
        }
        private byte[] UInt64ToBigEndianBytes(UInt64 x)
        {
            return new byte[] {
            (byte)((x >> 56) & 0xff), (byte)((x >> 48) & 0xff), (byte)((x >> 40) & 0xff), (byte)((x >> 32) & 0xff),
            (byte)((x >> 24) & 0xff), (byte)((x >> 16) & 0xff), (byte)((x >> 8) & 0xff), (byte)(x & 0xff)
        };
        }
    }
}
