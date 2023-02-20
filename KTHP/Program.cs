abstract class NHANVIEN {
    public string MaNV,HoTenNV;
    protected float HsLuong;
    protected int LuongCb;
    public NHANVIEN(string MaNV,string HoTenNV,float HsLuong,int LuongCb) {
        this.MaNV=MaNV;
        this.HoTenNV=HoTenNV;
        this.HsLuong=HsLuong;
        this.LuongCb=LuongCb;
    }
    public abstract float TINHLUONG();
    public void Xuat() {
        Console.WriteLine("{0,5} - {1,-30} - {2:0.00}",this.MaNV,this.HoTenNV,this.TINHLUONG());
    }
}
class CTV : NHANVIEN {
    protected float PhuCap;
    public CTV(string MaNV,string HoTenNV,float HsLuong,int LuongCb,float PhuCap) : base(MaNV,HoTenNV,HsLuong,LuongCb) {
        this.PhuCap=PhuCap;
        QUANLYNHANVIEN.dsNV.Add(this);
    }
    public override float TINHLUONG() {
        float r;
        r=this.HsLuong*this.LuongCb*75/100+this.PhuCap;
        return r;
    }
}
class NHANVIENCT : NHANVIEN {
    protected float KPI;
    public NHANVIENCT(string MaNV,string HoTenNV,float HsLuong,int LuongCb,float KPI) : base(MaNV,HoTenNV,HsLuong,LuongCb) {
        this.KPI=KPI;
        QUANLYNHANVIEN.dsNV.Add(this);
    }
    public override float TINHLUONG() {
        float r;
        r=this.HsLuong*this.LuongCb*(1+this.KPI);
        return r;
    }
}
class QUANLY : NHANVIEN {
    protected float PhuCapQl;
    public QUANLY(string MaNV,string HoTenNV,float HsLuong,int LuongCb,float PhuCapQl) : base(MaNV,HoTenNV,HsLuong,LuongCb) {
        this.PhuCapQl=PhuCapQl;
        QUANLYNHANVIEN.dsNV.Add(this);
    }
    public override float TINHLUONG() {
        float r;
        r=this.HsLuong*this.LuongCb*2+this.PhuCapQl;
        return r;
    }
}
class QUANLYNHANVIEN {
    public static List<NHANVIEN> dsNV = new List<NHANVIEN>();
    public QUANLYNHANVIEN(int x,int y,int z) {
        for (int i = 0; i < x; i++) {addCTV();}
        for (int i = 0; i < y; i++) {addNVCT();}
        for (int i = 0; i < z; i++) {addQL();}
    }
    public static void addCTV() {
        Console.Write("Ma nhan vien: ");
        string MaNV=Console.ReadLine()!;
        Console.Write("Ho ten nhan vien: ");
        string HotenNV=Console.ReadLine()!;
        Console.Write("He so luong: ");
        float HsLuong=float.Parse(Console.ReadLine()!);
        Console.Write("Phu cap: ");
        float PhuCap=float.Parse(Console.ReadLine()!);
        new CTV(MaNV,HotenNV,HsLuong,4000000,PhuCap);
    }
    public static void addNVCT() {
        Console.Write("Ma nhan vien: ");
        string MaNV=Console.ReadLine()!;
        Console.Write("Ho ten nhan vien: ");
        string HotenNV=Console.ReadLine()!;
        Console.Write("He so luong: ");
        float HsLuong=float.Parse(Console.ReadLine()!);
        Console.Write("KPI: ");
        float KPI=float.Parse(Console.ReadLine()!);
        new NHANVIENCT(MaNV,HotenNV,HsLuong,4000000,KPI);
    }
    public static void addQL() {
        Console.Write("Ma nhan vien: ");
        string MaNV=Console.ReadLine()!;
        Console.Write("Ho ten nhan vien: ");
        string HotenNV=Console.ReadLine()!;
        Console.Write("He so luong: ");
        float HsLuong=float.Parse(Console.ReadLine()!);
        Console.Write("Phu cap quan ly: ");
        float PhuCapQl=float.Parse(Console.ReadLine()!);
        new QUANLY(MaNV,HotenNV,HsLuong,4000000,PhuCapQl);
    }
    public static void TINHLUONG() {
        foreach (NHANVIEN nv in dsNV) {
            Console.WriteLine("{0,5} - {1,-30} - {2:0.00}",nv.MaNV,nv.HoTenNV,nv.TINHLUONG());
        }
    }
    public static void MaxMin() {
        NHANVIEN? max=default,min=default;
        foreach (NHANVIEN nv in dsNV) {
            if (max==default) {
                max=nv;
                min=nv;
            }
            else if (max.TINHLUONG()<nv.TINHLUONG()) {max=nv;}
            else if (min.TINHLUONG()>nv.TINHLUONG()) {min=nv;}
        }
        Console.WriteLine("Nhan vien co luong thap nhat:");
        min.Xuat();
        Console.WriteLine("Nhan vien co luong cao nhat:");
        max.Xuat();
    }
}
class Program {
    static void Main(string[] args) {
        new QUANLYNHANVIEN(2,2,3);
        QUANLYNHANVIEN.TINHLUONG();
        QUANLYNHANVIEN.MaxMin();
    }
}