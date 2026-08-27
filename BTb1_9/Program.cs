namespace BTb1_9
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSSV: 6551071093");
            Console.InputEncoding=Encoding.UTF8;
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine();
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Do dai chuoi: " +str.Length+"\n");
            string upperString = "", lowerString="";
            foreach (char s in str)
            {
                if (char.IsUpper(s))
                {
                    upperString += s;
                }
            }
            Console.WriteLine(upperString.Trim());
            foreach (char s in str)
            {
                if (char.IsLower(s))
                {
                    lowerString += s;
                }
            }
            Console.WriteLine(lowerString.Trim());
            Console.WriteLine();
            Console.WriteLine(str.Trim());
            string checkedString = "Nguyễn";
            bool isFound = str.Contains(checkedString);
            // nếu ,StringCamparion.OriginalInorge là không phân biệt Hoa thuòng

            if (isFound)
            {
                Console.WriteLine("chuoi co tu 'Nguyễn': " + str.Trim());
            }
            Console.WriteLine();
            string cleaned=str.Trim();
            string[] words = cleaned.Split(' ');
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            string result = string.Join("-", words);
            Console.WriteLine(result);
        }
    }
}
