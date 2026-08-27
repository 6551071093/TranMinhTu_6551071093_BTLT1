namespace BTb1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSSV: 6551071093\n");
           
            Console.Write("Ho ten: ");
            string hoten = Console.ReadLine();
       
            Console.WriteLine();
            Console.Write("Tuoi: ");
            int tuoi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Chieu cao: ");
            decimal cao = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Can nang: ");
            int canNang = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Da tot nghiep(true/false): ");
            bool daTotNghiep = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Ho ten:    \t"+hoten+"\n");
            Console.WriteLine("Tuoi:      \t"+tuoi+" tuoi\n");
            Console.WriteLine("Chieu cao: \t"+cao+" m\n");
            Console.WriteLine("Can nang:  \t"+canNang+" kg\n");
            Console.WriteLine("Da tot nghiep:  "+ daTotNghiep);
            Console.WriteLine();
        }
    }
}
