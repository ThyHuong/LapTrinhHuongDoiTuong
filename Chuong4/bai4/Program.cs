class Info {
    protected string ID,Hoten,Group;
    static int soluong=0;
    public Info() {
        ID="";
        Hoten="";
        Group="";
        Nhap();
        soluong=soluong+1;
    }
    void Nhap() {
        Console.Write("Nhap ID sinh vien: ");
        ID=Console.ReadLine()!;
        Console.Write("Nhap ten sinh vien: ");
        Hoten=Console.ReadLine()!;
        Console.Write("Nhap lop sinh hoat: ");
        Group=Console.ReadLine()!;
    }
    public static void Xuatsl() {
        Console.WriteLine("Co {0} sinh vien trong lop OOP.",soluong);
    }
}
class DiemTP : Info {
    float tp1,tp2,tp3,dtb;
    public DiemTP() {
        tp1=0;
        tp2=0;
        tp3=0;
        dtb=0;
    }
    public void Nhap() {
        Console.Write("Nhap diem thanh phan 1: ");
        tp1=float.Parse(Console.ReadLine()!);
        Console.Write("Nhap diem thanh phan 2: ");
        tp2=float.Parse(Console.ReadLine()!);
        Console.Write("Nhap diem thanh phan 3: ");
        tp3=float.Parse(Console.ReadLine()!);
        dtb=(tp1+tp2*3+tp3*6)/10;
    }
    public void Xuat() {
        Console.WriteLine("{0,-12} | {1,-30} | {2,-5} | {3,3} | {4,3} | {5,3} | {6,3}","ID","Ten","Lop","TP1","TP2","TP3","DTB");
        Console.WriteLine("{0,-12} | {1,-30} | {2,-5} | {3,3:0.0} | {4,3:0.0} | {5,3:0.0} | {6,3:0.0}",ID,Hoten,Group,tp1,tp2,tp3,dtb);
    }
}
class Program {
    static void Main(string[] args) {
        DiemTP hs1=new DiemTP();
        hs1.Nhap();
        Info.Xuatsl();
        hs1.Xuat();
    }
}