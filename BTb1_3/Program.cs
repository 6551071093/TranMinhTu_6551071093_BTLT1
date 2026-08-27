namespace BTb1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSSV: 6551071093");
            Console.WriteLine();
            Console.Write("Nhap do Celsius: ");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());
            decimal fahrenheit = celsius * 9 / 5 + 32;
            decimal kelvin = celsius + (decimal)273.15;
            Console.WriteLine();
            Console.WriteLine("Nhiet do Fahrenheit:    {0:F2} F\n"+
                              "Nhiet do Kelvin: \t{1:F2} K",fahrenheit,kelvin);

        }
    }
}
