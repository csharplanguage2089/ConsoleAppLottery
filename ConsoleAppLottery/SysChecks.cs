namespace ConsoleAppLottery
{
    internal class SysChecks
    {
        SysInfo sysInfo = new SysInfo();

        public char IFnReadCheck(char a = default)
        {
            while (true)
            {
                a = Console.ReadKey(true).KeyChar;

                if (char.IsLetter(a))
                {
                    a = char.ToUpper(a);
                    return a;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    sysInfo.IFn($"Enter a letter!");
                    Console.ResetColor();
                }
            }
        }

        public short IFnReadCheckN(string a = default)
        {
            while (true)
            {
                a = Console.ReadLine();
                short b;

                if (short.TryParse(a, out b))
                {
                    return b;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    sysInfo.IFn($"Enter a number from 0 to 25!");
                    Console.ResetColor();
                }
            }
        }
    }
}
