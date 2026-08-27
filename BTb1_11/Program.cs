using System.Text;

namespace BTb1_11
{
    public enum TrangThaiDonHang
    {
        ChoDuyet,
        DaDuyet,
        DangGiao,
        HoanThanh,
        DaHuy
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MSSV: 6551071093\n");
            int soNhap = 0;
            do
            {
                Console.WriteLine("===TRANG THAI DON HANG===");
                Console.WriteLine("- 0. Cho duyet ");
                Console.WriteLine("- 1. Da duyet  ");
                Console.WriteLine("- 2: Dang giao");
                Console.WriteLine("- 3. Hoan Thanh");
                Console.WriteLine("- 4. Da huy    ");
                Console.WriteLine("- (-1). Thoat  ");
                Console.Write("Moi ban nhap lua chon: ");
                try
                {
                    soNhap = Convert.ToInt32(Console.ReadLine());
                    if( soNhap == -1)
                    {
                        Console.WriteLine("Thoat thanh cong!");
                        continue;
                    }
                    
                    if (!Enum.IsDefined(typeof(TrangThaiDonHang), soNhap)){
                        throw new ArgumentOutOfRangeException("Gia tri nhap nam ngoai khoang gia tri trong danh sach\n");
                    }
                    TrangThaiDonHang trangThai = (TrangThaiDonHang)soNhap;
                    switch (trangThai)
                    {
                        case TrangThaiDonHang.ChoDuyet:
                            Console.WriteLine("Don hang moi cua ban, dang cho nhan vien xac nhan!\n");
                            break;
                        case TrangThaiDonHang.DaDuyet:
                            Console.WriteLine("Don hang cua ban da duoc duyet!\n");
                            break;
                        case TrangThaiDonHang.DangGiao:
                            Console.WriteLine("Don hang cua ban dang giao den!\n");
                            break;
                        case TrangThaiDonHang.HoanThanh:
                            Console.WriteLine("Don hang cua ban da duoc giao!\n");
                            break;
                        case TrangThaiDonHang.DaHuy:
                            Console.WriteLine("Don hang cua ban da duoc huy!"\n);
                            break;
                    }
                }
                catch (FormatException)//tranh nguoi dung nhap chu
                {
                    Console.WriteLine("Error! Vui long chi nhap so nguyen!\n");
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Error! {ex.ParamName}");
                }
                catch(Exception)
                {
                    Console.WriteLine("Errpr! xay ra loi khong xac dinh!\n");
                }
            }while(soNhap!=-1);
        }
    }
}
