using System;

namespace MathLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, answermath;
            int cols_slagaem, stepenY_math, stepenX_math, x1_math, x2_math, y1_math, y2_math;
            char cont_math;
            do
            {
                answermath = 0;
                stepenX_math = 2;
                stepenY_math = 3;
                x1_math = 2;
                x2_math = 3;
                y1_math = 1;
                y2_math = 3;
                Console.Write("Введите X: ");
                X = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Y: ");
                Y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество слагаемых: ");
                cols_slagaem = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= cols_slagaem; i++) // ColsSlagaem
                {
                    if (i % 2 == 0)
                    {
                        answermath -= Y * Math.Pow(X, stepenX_math) / (y1_math * y2_math);
                        stepenY_math += 3;
                        y1_math += 1;
                        y2_math += 3;
                    }
                    else
                    {
                        answermath += X * Math.Pow(Y, stepenY_math) / (x1_math * x2_math);
                        stepenX_math += 2;
                        x1_math += 2;
                        x2_math += 3;
                    }
                }
                Console.WriteLine("Ответ: {0:F3}", answermath);
                Console.WriteLine("Для повтора введите [ 2 ] , после нажмите Enter");
                cont_math = Convert.ToChar(Console.ReadLine());
                Console.Clear();
            }
            while (cont_math == '2');
        }
    }
}
