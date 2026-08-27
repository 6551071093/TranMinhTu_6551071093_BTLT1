namespace BTb1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSSV: 6551071093");
            Console.WriteLine();
            bool check = true;
            do
            {
                Console.Write("\nNhap so diem: ");
                double diem = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                if (diem < 0 || diem > 10)
                {
                    Console.WriteLine("Diem khong hop le!");
                }
                else if (diem <= 10 && diem >= 9)
                {
                    Console.WriteLine("Xuat sac!");
                }
                else if (diem < 9 && diem >= 8)
                {
                    Console.WriteLine("Gioi!");
                }
                else if (diem < 8 && diem >= 6.5)
                {
                    Console.WriteLine("Kha!");
                }
                else if (diem < 6.5 && diem >= 5)
                {
                    Console.WriteLine("Trung binh!");
                }
                else if (diem < 5)
                {
                    Console.WriteLine("Yeu!");
                }
            } while (check);
        }
    }
}
