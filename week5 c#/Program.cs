namespace week5_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ~100 짝수 출력");
            for (var i = 1; i <= 100; ++i)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            

            Console.WriteLine("0 ~10 while문 작성");
            var whileword = 0;
            while (whileword <= 10)
            {
                Console.WriteLine(whileword);
                ++whileword;
            }
            

            Console.WriteLine("1 ~100 홀수 do while문 작성");
            var dowhileword = 0;
            do
            {
                if (dowhileword % 2 == 1)
                {
                    Console.WriteLine(dowhileword);
                }
                dowhileword++;
            }
            while (dowhileword < 100);
           

            Console.WriteLine("별 피라미드 출력");
            for (int i = 0; i < 8; ++i)
            {
                for (int j = i + 1; j < 8; ++j)
                {
                    Console.Write(' ');
                   
                }

                for (int j = 0; j <= i * 2; ++j)
                {
                    Console.Write('*');
                }
                Console.WriteLine();

                
            }
            

            Console.WriteLine("숫자 5개 입력 최소값 최대값 출력");
            int[] five = new int[5];
            for (int i = 0; i < 5; ++i)
            {
                Console.Write("숫자를 입력하시오 현재 {i}개 : ");
                five[i] = int.Parse(Console.ReadLine());
            }
            Console.Write($"최소 값 {five[0]}, 최대값 {five[4]}");
        }

    }

}



