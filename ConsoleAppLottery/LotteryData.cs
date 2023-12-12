namespace ConsoleAppLottery
{
    internal class LotteryData
    {
        Random random = new Random();

        char[] arrAlphabet = new char[26];
        short[] arrNumbers = new short[26];

        /// <summary>
        /// Assigning random letters of the alphabet
        /// </summary>
        public char RandomLetter(short r1 = default)
        {
            int i;

            for (i = 0; i < arrAlphabet.Length; i++)
            {
                arrAlphabet[i] = (char)('A' + i);
            }
            r1 = (short)random.Next(arrAlphabet[0], arrAlphabet[25]);

            return (char)r1;
        }

        /// <summary>
        /// Assigning random numbers
        /// </summary>
        public short RandomNumber(short r2 = default)
        {
            int k;

            for (k = 0; k < arrNumbers.Length; k++)
            {
                arrNumbers[k] = (short)(1 + k);
            }
            r2 = (short)random.Next(arrNumbers[0], arrNumbers[25]);

            return r2;
        }

        /// <summary>
        /// 
        /// </summary>
        public void TicketGeneration()
        {
            int j;
        }
    }
}
