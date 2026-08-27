namespace BTb1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSSV: 6551071093");

            Console.WriteLine();
            Console.WriteLine("Nhap so thuc a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Nhap so thuc b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            bool check = true;
            while (check)
            {
                Console.WriteLine("1. Phep cong");
                Console.WriteLine("2. Phep tru");
                Console.WriteLine("3. Phep nhan");
                Console.WriteLine("4. Phep chia");
                Console.WriteLine("5. Phep chia lay nguyen");
                Console.WriteLine("6. Phep chia lay du");
                Console.WriteLine("7. phep luy thua");
                Console.WriteLine("0. Thoat!");
                Console.WriteLine("Lua chon cua ban: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        double tong = a + b;
                        Console.WriteLine(a+" + "+b+" = "+tong);
                        break;
                    case 2:
                        double hieu = a - b;
                        Console.WriteLine(a + " - " + b + " = " + hieu);
                        break;
                    case 3:
                        double tich = a * b;
                        Console.WriteLine(a + " * " + b + " = " + tich);
                        break;
                    case 4:
                        if (b == 0)
                        {
                            Console.WriteLine("Error! do mau = 0");
                            break;
                        }
                        else if (a == 0)
                        {
                            double thuong = 0;
                            Console.WriteLine(a + " / " + b + " = " + thuong);
                            break;
                        }
                        else
                        {
                            double thuong = a / b;
                            Console.WriteLine(a+" / "+b+" = "+thuong);
                            break;
                        }
                    case 5:
                        if (b == 0)
                        {
                            Console.WriteLine("Error! do mau = 0");
                            break;
                        }
                        else if (a == 0)
                        {
                            double thuongNguyen = 0;
                            Console.WriteLine(a+" / "+b+" = "+thuongNguyen);
                            break;
                        }
                        else
                        {
                            double thuongNguyen = a / b;
                            thuongNguyen = Math.Truncate(thuongNguyen);
                            thuongNguyen = (int)thuongNguyen;
                            Console.WriteLine(a + " / " + b + " = " + thuongNguyen);
                            break;
                        }
                    case 6:
                        if (b == 0)
                        {
                            Console.WriteLine("Error! do mau = 0");
                            break;
                        }
                        else if (a == 0)
                        {
                            double thuongLayDu = 0;
                            Console.WriteLine(a+" % "+b+" = "+thuongLayDu);
                            break;
                        }
                        else if(a<0 && b > 0)
                        {
                            double thuongLayDu = ((a % b) + b) % b;
                            Console.WriteLine(a + " % " + b + " = " + thuongLayDu);
                            break;
                        }
                        else
                        {
                            double thuongLayDu = a%b;
                            Convert.ToInt32(thuongLayDu);
                            Console.WriteLine(a+" % "+b+" = "+thuongLayDu);
                            break;
                        }
                    case 7:
                        if(a==0 && (b==0 || b<0))
                        {
                            Console.WriteLine("Error ! 0^0");
                            break;
                        }
                        else if(b == 0 || a==1)
                        {
                            Console.WriteLine(a + "^" + b + " = " +1);
                            break;
                        }
                        else if(b==-1)
                        {
                            double luyThua = 1 / a;
                            Console.WriteLine(a + "^(" +-1+ ") = " +luyThua);
                            break;
                        }
                        else
                        {
                            double luyThua= Math.Pow(a, b);
                            Console.WriteLine(a + "^" +b+ " = " + luyThua);
                            break;
                        }
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Error! Nhap sai. Moi nhap lai!");
                        break;
                }
            }
        }
    }
}
