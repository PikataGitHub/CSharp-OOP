namespace Problem05._64BitArray
{
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        //Fields
        private const int hashConstant = 666666;
        private int[] bits;

        //Constructors
        public BitArray64(ulong val)
        {
            this.bits = new int[64];

            for (int i = 0; i < 64; i++)
            {
                ulong mask = 1;
                int bit = (int)((val & (mask << i)) >> i);
                bits[64 - i - 1] = bit;
            }
        }

        //Indexers
        public int this[int index]
        {
            get
            {
                return bits[index];
            }
        }

        //Properties
        public ulong DecimalValue
        {
            get
            {
                ulong decimalValue = 0;
                ulong powerOfTwo = 1;

                for (int i = 0; i < 64; i++)
                {
                    powerOfTwo *= 2;

                    if (bits[64 - i - 1] == 1)
                    {
                        decimalValue += powerOfTwo;
                    }
                }
                return decimalValue;
            }
        }

        //Methods
        public override bool Equals(object inputObject)
        {
            if (inputObject == null) { return false; }

            var objAsBitArray = inputObject as BitArray64;

            return string.Join("", bits).Equals(string.Join("", objAsBitArray.bits));
        }

        public override int GetHashCode()
        {
            return (hashConstant + this.bits.GetHashCode()) ^ this.DecimalValue.GetHashCode();
        }

        public static bool operator ==(BitArray64 firstBitArr, BitArray64 secondBitArr)
        {
            return firstBitArr.Equals(secondBitArr);
        }

        public static bool operator !=(BitArray64 firstBitArr, BitArray64 secondBitArr)
        {
            return !firstBitArr.Equals(secondBitArr);
        }

        public override string ToString()
        {
            return string.Join(string.Empty, bits);
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int bit in bits)
            {
                yield return bit;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
