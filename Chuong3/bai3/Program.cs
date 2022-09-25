class Organization {
    string Name,Country,City,Address,Telephone;
    public Organization() {
        Name=" ";
        Country="VietNam";
        City="HCM city";
        Address="";
        Telephone="0000000000";
    }
    ~Organization() {
        Console.WriteLine("Doi tuong Organization da bi huy.");
    }
    public void Nhap(string ten,string qg,string tp,string dc,string sdt) {
        Name=ten;
        Country=qg;
        City=tp;
        Address=dc;
        Telephone=sdt;
    }
    public void Xuat() {
        Console.WriteLine("\nCac thong tin doanh nghiep da nhap:");
        Console.WriteLine("Ten doanh nghiep: {0}",Name);
        Console.WriteLine("Quoc gia: {0}\tThanh pho: {1}",Country,City);
        Console.WriteLine("Dia chi: {0}\nSo dien thoai: {1}",Address,Telephone);
    }
}
class Program {
    static void Main(string[] args) {
        try {
            string ten,qg,tp,dc,sdt;
            Console.Write("Nhap ten doanh nghiep: ");
            ten=Console.ReadLine()!;
            char s=ten[0];
            Console.Write("Nhap quoc gia: ");
            qg=Console.ReadLine()!;
            s=qg[0];
            Console.Write("Nhap thanh pho: ");
            tp=Console.ReadLine()!;
            s=tp[0];
            Console.Write("Nhap dia chi cu the: ");
            dc=Console.ReadLine()!;
            s=dc[0];
            Console.Write("Nhap so dien thoai: ");
            sdt=Console.ReadLine()!;
            if (sdt.Length!=10) s=sdt[sdt.Length];
            int a=Convert.ToInt32(sdt);
            Organization doanhnghiep=new Organization();
            doanhnghiep.Nhap(ten,qg,tp,dc,sdt);
            doanhnghiep.Xuat();
        }
        catch (Exception e) {
            Console.WriteLine("Nhap thong tin loi.");
            e.ToString();
        }
    }
}