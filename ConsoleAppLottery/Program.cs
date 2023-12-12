using ConsoleAppLottery;

internal class Program
{
    private static void Main(string[] args)
    {
        LotteryData lotteryData = new LotteryData();
        SysChecks sysChecks = new SysChecks();
        SysInfo sysInfo = new SysInfo();

        char a1Ex = lotteryData.RandomLetter();
        char a2Ex = lotteryData.RandomLetter();
        char a3Ex = lotteryData.RandomLetter();

        short b1Ex = lotteryData.RandomNumber();
        short b2Ex = lotteryData.RandomNumber();
        short b3Ex = lotteryData.RandomNumber();

        char a1 = lotteryData.RandomLetter();
        char a2 = lotteryData.RandomLetter();
        char a3 = lotteryData.RandomLetter();

        short b1 = lotteryData.RandomNumber();
        short b2 = lotteryData.RandomNumber();
        short b3 = lotteryData.RandomNumber();

        char read;
        short readNumber;

        bool endGame = false;

        // Hack!
        // sysInfo.IFn($"\n" +
        //    $"{a1} {b1} {a2} {b2} {a3} {b3}" +
        //    $"\n");

        sysInfo.IFn($"Welcome to the lottery!");
        sysInfo.IFn($"Try to guess the lottery ticket.");
        sysInfo.IFn($"First, you guess the letter of the alphabet, then the number from 0 to 25, and so on 3 times.");
        sysInfo.IFn($"Example of a ticket: {a1Ex} {b1Ex} {a2Ex} {b2Ex} {a3Ex} {b3Ex}");
        sysInfo.IFn($"You have 6 attempts for each letter or number.");
        sysInfo.IFn($"Let's go!");

        int i, k, j, l, m, n;

        for (i = 6; i > 0; i--)
        {
            sysInfo.IFn($"XX XX XX XX XX XX");
            // 1st pass
            sysInfo.IFn($"Enter the first letter. Attempts left: {i}");
            read = sysChecks.IFnReadCheck();
            if (read == a1)
            {
                i = 0;
                for (k = 6; k > 0; k--)
                {
                    sysInfo.IFn($"{a1} XX XX XX XX XX");
                    // 2st pass
                    sysInfo.IFn($"Enter the first number between 0 and 25. Attempts left: {k}");
                    readNumber = sysChecks.IFnReadCheckN();
                    if (readNumber == b1)
                    {
                        k = 0;
                        for (j = 6; j > 0; j--)
                        {
                            sysInfo.IFn($"{a1} {b1} XX XX XX XX");
                            //3st pass
                            sysInfo.IFn($"Enter the second letter. Attempts left: {j}");
                            read = sysChecks.IFnReadCheck();
                            if (read == a2)
                            {
                                j = 0;
                                for (l = 6; l > 0; l--)
                                {
                                    sysInfo.IFn($"{a1} {b1} {a2} XX XX XX");
                                    //4st pass
                                    sysInfo.IFn($"Enter a second number between 0 and 25. Attempts left: {l}");
                                    readNumber = sysChecks.IFnReadCheckN();
                                    if (readNumber == b2)
                                    {
                                        l = 0;
                                        for (m = 6; m > 0; m--)
                                        {
                                            sysInfo.IFn($"{a1} {b1} {a2} {b2} XX XX");
                                            //5st pass
                                            sysInfo.IFn($"Enter the third letter. Attempts left: {m}");
                                            read = sysChecks.IFnReadCheck();
                                            if (read == a3)
                                            {
                                                m = 0;
                                                for (n = 6; n > 0; n--)
                                                {
                                                    sysInfo.IFn($"{a1} {b1} {a2} {b2} {a3} XX");
                                                    //6st pass
                                                    sysInfo.IFn($"Enter the third number between 0 and 25. Attempts left: {n}");
                                                    readNumber = sysChecks.IFnReadCheckN();
                                                    if (readNumber == b3)
                                                    {
                                                        n = 0;
                                                        // Win!
                                                        endGame = true;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        sysInfo.IFn($"You guessed wrong.");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                sysInfo.IFn($"You guessed wrong.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        sysInfo.IFn($"You guessed wrong.");
                                    }
                                }
                            }
                            else
                            {
                                sysInfo.IFn($"You guessed wrong.");
                            }
                        }
                    }
                    else
                    {
                        sysInfo.IFn($"You guessed wrong.");
                    }
                }
            }
            else
            {
                sysInfo.IFn($"You guessed wrong.");
            }
        }

        if (endGame)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            sysInfo.IFn($"Congratulations, you are a winner!!");
            sysInfo.IFn($"{a1} {b1} {a2} {b2} {a3} {b3}");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            sysInfo.IFn($"You lose!");
            sysInfo.IFn($"{a1} {b1} {a2} {b2} {a3} {b3}");
            Console.ResetColor();
        }
    }
}
