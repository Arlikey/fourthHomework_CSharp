namespace fourthHomework
{
    /*internal class MainTask
    {
        static void Main(string[] args)
        {
            Console.Write("Количество кубиков: ");
            int dices = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество ступеней: {Ladder(dices)}");

        }

        static int Ladder(int dices, int i = 2, int count = 0)
        {
            if (dices > 0)
            {
                for (int j = 1; j <= i-1; j++)
                {
                    Console.Write("[]");
                }
                Console.WriteLine();
                return Ladder(dices - i, ++i, ++count);
            }
            else
            {
                return count;
            }
        }
    }*/

    /*class AdditionalTask1
    {
        static void Main()
        {
            Random random = new Random();
            int tries = 1;
            int userChoice = 0;
            int min = 0, max = 101;
            while (userChoice != 3)
            {
                int number = (min + max) / 2;
                Console.WriteLine($"Число предложенное компьютером: {number}");
                Console.Write("Укажите,\n\t1. если предложенное число больше.\n\t2. если предложенное число меньше\n\t3. если число равное загаданному.\n-> ");
                userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        {
                            max = (min + max) / 2 - 1;
                            tries++;
                            break;
                        }
                    case 2:
                        {
                            min = (min + max) / 2 + 1;
                            tries++;
                            break;
                        }
                    case 3:
                        Console.WriteLine($"Компьютер угадал число за {tries} попыт(-ки/ок)");
                        return;
                    default:
                        Console.WriteLine("Ошибка ввода.");
                        return;
                }

            }
        }
    }*/

    /*class AdditionalTask2
    {
        static void Main()
        {
            Console.WriteLine($"Количество дней необходимых для написания статьи - {CountOfDays()}.");
        }

        static int CountOfDays(int needWords = 1300, int pagesPerDay = 50, int days = 0)
        {
            if (needWords <= 0)
            {
                return days;
            }
            else
            {
                return CountOfDays(needWords-pagesPerDay, pagesPerDay, ++days);
            }
        }
    }*/

    /*class AdditionalTask3
    {
        static void Main()
        {
            int[] uniqueArray = GetUniqueNumbers(new int[] { 1, 2, 1, 2, 3, 4, 7, 4, 5, 2, 3, 6 });
            foreach (int numbers in uniqueArray) {
                Console.Write($" {numbers} ");
            }
        }

        static int[] GetUniqueNumbers(int[] inputArray)
        {
            int[] tempArray = new int[inputArray.Length];
            int uniqueCount = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < uniqueCount; j++)
                {
                    if (inputArray[i] == tempArray[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    tempArray[uniqueCount] = inputArray[i];
                    uniqueCount++;
                }
            }

            int[] uniqueArray = new int[uniqueCount];
            Array.Copy(tempArray, uniqueArray, uniqueCount);

            return uniqueArray;
        }
    }*/

    /*class AdditionalTask4
    {
        static void Main()
        {
            Console.Write("Укажите сдвиг для шифрования: ");
            int shift = int.Parse(Console.ReadLine());
            string text = "Hello World";
            text = Crypt(text, shift);
            Console.WriteLine(text);
            Console.WriteLine(Encrypt(text, shift));
        }

        static string Crypt(string text, int shift)
        {
            string crypted = "";
            char firstLetter;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {

                    firstLetter = char.IsUpper(text[i]) ? 'A' : 'a';

                    crypted += (char)((text[i] - firstLetter + shift + 26) % 26 + firstLetter);
                    continue;
                }
                crypted += text[i];
            }
            return crypted;
        }

        static string Encrypt(string text, int shift) => Crypt(text, -shift);
    }*/

    /*class AdditionalTask7
    {
        static void Main()
        {
            Console.WriteLine(MathOperation(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, Operations.Max));
        }

        enum Operations
        {
            Avg,
            Min,
            Max
        }

        static double MathOperation(double[] array, Operations operations)
        {
            switch (operations)
            {
                case Operations.Avg:
                    int avg = 0;
                    foreach (int number in array)
                    {
                        avg += number;
                    }
                    return (double)avg / array.Length;
                case Operations.Min:
                    double min = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        min = min > array[i] ? array[i] : min;
                    }
                    return min;
                case Operations.Max:
                    double max = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        max = max < array[i] ? array[i] : max;
                    }
                    return max;
                default: return -1;
            }
        }
    }*/
}