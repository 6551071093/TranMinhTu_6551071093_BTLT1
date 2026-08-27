namespace BTb1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSSV: 6551071093");
            Console.WriteLine();
            Console.Write("Nhap 1 so nguyen: ");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if(number == 0)
            {
                Console.WriteLine(number+" la so 0!");
            }
            else if(number > 0)
            {
                Console.WriteLine(number + " la so duong!");
            }
            else if(number < 0)
            {
                Console.WriteLine(number + " la so am!");
            }

            if(number % 2 != 0)
            {
                Console.WriteLine(number + " la so le!");
            }
            else if(number !=0 && number % 2==0)
            {
                Console.WriteLine(number + " la so chan!");
            }

            if(number % 2 == 0 && number % 3 == 0)
            {
                Console.WriteLine(number + " la so chia het cho ca 2 va 3!");
            }
            if(number % 3 == 0)
            {
                Console.WriteLine(number + " la so chia het cho 3!");
            }
        }
    }
}
