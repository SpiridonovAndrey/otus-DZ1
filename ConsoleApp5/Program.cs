namespace ConsoleApp5
{
    internal class Program
    {

        static void PrintFirst(string line,int number)
        {
            int i = 0; int j = 0;
            while (i <= 2 * (number - 1))
            {
                j = 0;
                while (j < line.Length + 2 * number-1)
                {
                    if (j == 0) Console.Write("+");
                    else if (i == j - 1 && i==number-1) { Console.Write(line); j = j + line.Length-1; }
                    else Console.Write(" ");
                    j++;
                }
                Console.WriteLine("+"); i++;
            }

        }
        static void PrintSecond(string line, int number)
        {
            int i = 0; int j = 0;
            while (i <= 2 * (number - 1))
            {
                j = 0;
                while (j < line.Length + 2 * number-1)
                {
                    if (j == 0) Console.Write("+");
                    else if ((i + j) % 2 == 0) Console.Write("+");
                    else Console.Write(" ");
                    j++;
                }
                Console.WriteLine("+"); i++;
            }

        }
        static void PrintThird(string line, int number)
        {
            int i = 0; int j = 0;
            while (i <=  line.Length + 2 * number-3)
            {
                j = 0;
                while (j < line.Length + 2 * number - 1)
                {
                    if (j == 0) Console.Write("+");
                    else if (i == j-1) Console.Write("+");
                    else if (line.Length + 2 * number - i-2 == j) Console.Write("+");
                    else Console.Write(" ");
                    j++;
                }
                Console.WriteLine("+"); i++;
            }

        }
        static void Main(string[] args)
        {
            bool result;int number; string line;
            do
            {
                Console.WriteLine("Введите размерность таблицы:");
                result = int.TryParse(Console.ReadLine(), out number);
                if (!result || !((number > 1) && (number < 7))) Console.WriteLine("Неверный ввод! Введите число от 1 до 6");
            } while (!result || !((number > 1) && (number < 7)));
            do
            {
                Console.WriteLine("Введите произвольный текст:");
                line = Console.ReadLine();
                if (line.Length < 1 || (line.Length+ number)>40) Console.WriteLine("Неверный ввод! Введите от 1 до {0} символов",40-number);
            } while (line.Length < 1 || (line.Length + number) > 40);

            int i = 0;int j = 0;string border="";
            while (i < line.Length + 2 * number)
            {
                border = border + "+";
                i++;
            }
            i = 0; Console.WriteLine(border);
            while (i < 3)
            {
                switch (i)
                {
                    case 0:
                        PrintFirst(line, number); break;
                    case 1:
                        PrintSecond(line, number); break;
                    case 2:
                        PrintThird(line, number); break;

                }
                Console.WriteLine(border);
                i++;
            }
        }
    }
}