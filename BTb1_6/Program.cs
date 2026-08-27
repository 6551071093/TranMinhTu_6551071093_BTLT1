namespace BTb1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSSV: 6551071093");
            Console.WriteLine();
            int bangCuuChuong;
            do
            {
                Console.Write("Nhap so bang cuu chuong: ");
                bangCuuChuong = Convert.ToInt32(Console.ReadLine());
                if(bangCuuChuong < 1 || bangCuuChuong > 9)
                {
                    Console.WriteLine("Error! Moi nhap lai!");
                }
            } while (bangCuuChuong < 1 || bangCuuChuong > 9);
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(bangCuuChuong + " x " + i + " = " + bangCuuChuong * i);
            }
        }
    }
}
