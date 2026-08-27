using System.Security.Cryptography;

namespace BTb1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSSV: 6551071093");
            Console.WriteLine();
            Console.WriteLine("Nhap mang: ");
            int soPhanTu = 10;
            int[] array = new int[soPhanTu];
            for (int i = 0; i < soPhanTu; i++)
            {
                Console.Write("array[" + i + "] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Mang da nhap: ");
            for(int i=0; i < soPhanTu; i++)
            {
                Console.WriteLine("array[" + i + "] = " + array[i]);
            }
            int sum=0;
            int max = array[0], min = array[0];
            for (int i = 0;i < soPhanTu; i++)
            { 
                sum += array[i];
            }
            Console.WriteLine("Tong cua mang: " + sum);
            Console.WriteLine("Trung binh cua mang: "+(double)sum/soPhanTu);
            int index1=0,index2=0;
            for(int i=0;i<soPhanTu; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index1 = i;
                }
                else if (array[i] < min)
                {
                    min = array[i];
                    index2 = i;
                }
            }
            Console.WriteLine("Phan tu lon nhat trong mang: " + max + " nam o vi tri: "+index1);
            Console.WriteLine("Phan tu nho nhat trong mang: "+min+ " nam o vi tri: "+index2);
            int countEven = 0,countOdd = 0;
            for(int i = 0; i < soPhanTu; i++)
            {
                if(array[i] % 2 == 0)
                {
                    countEven++;
                }
                else if (array[i] % 2 != 0)
                {
                    countOdd++;
                }
            }
            Console.WriteLine("So phan tu chan trong mang: "+countEven);
            Console.WriteLine("So phan tu le trong mang: "+countOdd);
            Console.WriteLine();
            Console.WriteLine("Mang dao nguoc: ");
            for(int i = soPhanTu - 1; i >= 0; --i)
            {
                Console.WriteLine("array[" + i + "] = " + array[i]);
            }
        }
    }
}
