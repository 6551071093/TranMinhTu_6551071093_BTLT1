using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;
using System.Text;
namespace BTb1_12
{
    internal class Program
    {
        public struct HocSinh
        {
            public int MaSo { get; set; }
            public string HoTen { get; set; }
            public double DiemVan { get; set; }
            public double DiemToan { get; set; }
            public double DiemAnh { get; set; }
            public double DiemTB(HocSinh other)
            {
                return (other.DiemVan + other.DiemToan + other.DiemAnh) / 3.0;
            }
            public override string ToString()
            {
                return $"MaSo: {MaSo}, " +
                       $"Ho ten hoc sinh: {HoTen}, " +
                       $"Diem van: {DiemVan:F2}, " +
                       $"Diem toan: {DiemToan:F2}, " +
                       $"Diem anh: {DiemAnh:F2} ";
            }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding=Encoding.UTF8;
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("MSSV: 6551071093, test [3], nhung code nop là [5]");
            Console.WriteLine();
            HocSinh[] student = new HocSinh[5];
            Console.WriteLine("Nhap danh sach hoc sinh: ");
            for(int i = 0; i < student.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Nhap hoc sinh {i+1}: ");

                Console.Write("Ma so hoc sinh: ");
                student[i].MaSo=Convert.ToInt32(Console.ReadLine());

                Console.Write("Ho ten hoc sinh: ");
                student[i].HoTen = Console.ReadLine();

                Console.Write("Diem van: ");
                student[i].DiemVan=Convert.ToDouble(Console.ReadLine());

                Console.Write("Diem toan: ");
                student[i].DiemToan = Convert.ToDouble(Console.ReadLine());

                Console.Write("Diem anh: ");
                student[i].DiemAnh = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Diem trung binh cac hoc sinh: ");
            for(int i = 0;i < student.Length; i++)
            {
                Console.Write($"Hoc sinh {i+1}: ");
                Console.WriteLine($"{student[i].DiemTB(student[i]):F2}");
            }
            Console.WriteLine();
            double maxDTB = student[0].DiemTB(student[0]);
            int index = 0;
            for(int i = 0;i<student.Length; i++)
            {
                if (student[i].DiemTB(student[i]) > maxDTB)
                {
                    maxDTB = student[i].DiemTB(student[i]);
                    index = i;
                }
            }
            Console.WriteLine("Hoc sinh diem trung binh cao nhat: ");
            Console.WriteLine(student[index] +$" DiemTB: {maxDTB:F2}");
            Console.WriteLine();
            for(int i = 0; i < student.Length; i++)
            {
                double dTB = student[i].DiemTB(student[i]);
                Console.WriteLine($"Hoc sinh {i+1}: ");
                Console.WriteLine(student[i]+$" DiemTB: {dTB:F2}");
                
                if (dTB < 5.0)
                {
                    Console.WriteLine("Xep loai: Yeu");
                }
                else if(dTB >=5 && dTB < 6.5)
                {
                    Console.WriteLine("Xep loai: Trung binh");
                }
                else if(dTB>=6.5 &&  dTB < 8.5)
                {
                    Console.WriteLine("Xep loai: Kha");
                }
                else if(dTB >=8.5 && dTB <= 10)
                {
                    Console.WriteLine("Xep loai: Gioi");
                }
                else
                {
                    Console.WriteLine("Error! diem trung binh khong nam trong khoang cach!");
                }
            }
        }
    }
}
/*
 * Sự khác biệt giữa struct (value type) và class (reference type)
 * - Theo bản chất:
 * - Đầu tiên là về class (tham chiếu): 
 *   Một class giống như một ngôi nhà vậy, khi ta muốn cho ai đó sử dụng nhà,
 * ta không thể bưng cả ngôi nhà đưa cho họ được mà ta chỉ đưa chìa khóa (địa chỉ).
 * Nếu người đó dùng chìa khóa vào nhà và sơn lại tường, ngôi nhà gốc của chúng ta
 * chắc chắn sẽ bị đổi màu theo. Sự liên kết này gọi là kiểu tham chiếu(reference type).
 * - Còn về struct, nó ngược lại:
 *   Struct giống như 1 tờ giấy chứa dữ liệu. Khi bạn đưa tờ giấy đó cho một hàm hay 
 * một biến khác, hệ thống sẽ tự động tạo ra 1 bản sao y hệt để đưa đi. Nếu người kia 
 * có vò nát hay sửa chữa điều gì trên tờ giấy đó, tờ gốc không bị thay đổi vẫn nguyên vẹn.
 * sự phân biệt này gọi là kiểu tham trị (value type).
 * - 1 cái ta có thể dựa vào địa chỉ mà đi đến gốc và thay đổi và tác động mọi thứ
 * nghĩa là nhận giá trị cả 2 chiều, 1 cái ta chỉ có thể nhận dữ liệu 1 chiều
 * nếu không thêm công cụ hỗ trợ gì thì tác động như thế nào thì bản gốc vẫn vẹn nguyên.
 * Theo kiến trúc máy tính thì:
 * - Vùng nhớ lưu trữ: struct được cấp phát trên Stack(tốc độ nhanh, tự động dọn dẹp khi dùng xong.
 * class nằm trên bộ nhớ Heap (chậm hơn và phải đợi gom rác Garbage Collector dọn dẹp.
 * - Khả năng kế thừa: theo định nghĩa trên ta cũng đúc kết là
 * class sinh ra là để tạo các cây kế thừa phức tạp.
 * struct bị khóa hoàn toàn, nó không thể kế thừa từ 1 struct hay class khác.
 * - Trạng thái rỗng: class có thể mang giá trị null còn biến kiểu struct không được là null.
 * Nên: class đa dụng nhiều hơn, riêng struct thì chỉ nên dùng khi dữ liệu cho 
 * giá trị đơn lẻ(Tọa độ X/Y, màu sác RGB, Thời gian), kích thước vùng nhờ rất nhỏ(<16 byte),
 * dữ liệu không cần thay đổi sau khi tạo.
*/
