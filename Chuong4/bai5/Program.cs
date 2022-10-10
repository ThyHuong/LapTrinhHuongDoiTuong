class Doanhnghiep {
    public string TenDN,MST,Diachi;
    public Doanhnghiep() {
        TenDN="";
        MST="";
        Diachi="";
        Nhap();
    }
    void Nhap() {
        Console.Write("Nhap ten doanh nghiep: ");
        TenDN=Console.ReadLine()!;
        Console.Write("Nhap ma so thue: ");
        MST=Console.ReadLine()!;
        Console.Write("Nhap dia chi cua doanh nghiep: ");
        Diachi=Console.ReadLine()!;
    }
    public void Xuat() {
        Console.WriteLine("{0,-30} | {1,-15} | {2,-100}",TenDN,MST,Diachi);
    }
}
class DanhsachDN {
    List<Doanhnghiep> listDN=new List<Doanhnghiep>();
    int count=0;
    public void Nhap() {
        while (true)
        {
            Doanhnghiep dn=new Doanhnghiep();
            listDN.Add(dn);
            count+=1;
            Console.Write("Tiep tuc nhap? (y/n) ");
            string kt=Console.ReadLine()!;
            if (string.Compare(kt,"n")==0) break;
        }
    }
    public void Xuat() {
        Console.WriteLine("{0,-30} | {1,-15} | {2,-100}","Ten doanh nghiep","Ma so thue","Dia chi");
        for (int i=0;i<count;i++) {
            listDN[i].Xuat();
        }
        Console.WriteLine();
    }
    Doanhnghiep this[string index] {
        get {
            for (int i=0;i<count;i++) {
                if ((listDN[i].MST==index)||(listDN[i].TenDN==index)) return listDN[i];
            }
            return default(Doanhnghiep);
        }
    }
    public void findByName(string ten) {
        Doanhnghiep Indexed=this[ten];
        Console.WriteLine("Ma so thue doanh nghiep can tim: {0}",Indexed.MST);
    }
    public void findByMST(string mst) {
        Doanhnghiep Indexed=this[mst];
        Console.WriteLine("Ten doanh nghiep can tim: {0}",Indexed.TenDN);
        Console.WriteLine("Dia chi doanh nghiep can tim: {0}",Indexed.Diachi);
    }
}
class Program {
    static void Main(string[] args) {
        DanhsachDN dsdn=new DanhsachDN();
        dsdn.Nhap();
        Console.WriteLine("\nDanh sach doanh nghiep:\n");
        dsdn.Xuat();
        Console.Write("Ten doanh nghiep muon tim: ");
        dsdn.findByName(Console.ReadLine()!);
        Console.Write("Ma so thue doanh nghiep muon tim: ");
        dsdn.findByMST(Console.ReadLine()!);
    }
}