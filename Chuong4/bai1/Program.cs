class Phanso {
    int Tuso,Mauso;
    public Phanso() {
        Tuso=0;
        Mauso=1;
    }
    ~Phanso() {
        Console.WriteLine("Da huy.");
    }
    public void Nhap(int tu,int mau) {
        Tuso=tu;
        Mauso=mau;
    }
    public static void Xuat(Phanso ps) {
        if ((ps.Mauso!=1)&&(ps.Tuso!=0)) {
            Console.Write("{0}/{1} ",ps.Tuso,ps.Mauso);
        }
        else {
            Console.Write("{0} ",ps.Tuso);
        }
    }
    public static void Cong(Phanso ps1,Phanso ps2) {
        int tuCong=ps1.Tuso*ps2.Mauso+ps2.Tuso*ps1.Mauso;
        int mauCong=ps2.Mauso*ps1.Mauso;
        int ucln=Program.UCLN(tuCong,mauCong);
        Phanso Tong=new Phanso();
        if (ucln!=1) {
            tuCong=tuCong/ucln;
            mauCong=mauCong/ucln;
        }
        Tong.Nhap(tuCong,mauCong);
        Phanso.Xuat(ps1);
        Console.Write("+ ");
        Phanso.Xuat(ps2);
        Console.Write("= ");
        Phanso.Xuat(Tong);
        Console.WriteLine();
    }
    public static void Tru(Phanso ps1,Phanso ps2) {
        int tuTru=ps1.Tuso*ps2.Mauso-ps2.Tuso*ps1.Mauso;
        int mauTru=ps2.Mauso*ps1.Mauso;
        int ucln=Program.UCLN(tuTru,mauTru);
        Phanso Hieu=new Phanso();
        if (ucln!=1) {
            tuTru=tuTru/ucln;
            mauTru=mauTru/ucln;
        }
        Hieu.Nhap(tuTru,mauTru);
        Phanso.Xuat(ps1);
        Console.Write("- ");
        Phanso.Xuat(ps2);
        Console.Write("= ");
        Phanso.Xuat(Hieu);
        Console.WriteLine();
    }
    public static void Nhan(Phanso ps1,Phanso ps2) {
        int tuNhan=ps1.Tuso*ps2.Tuso;
        int mauNhan=ps2.Mauso*ps1.Mauso;
        int ucln=Program.UCLN(tuNhan,mauNhan);
        Phanso Tich=new Phanso();
        if (ucln!=1) {
            tuNhan=tuNhan/ucln;
            mauNhan=mauNhan/ucln;
        }
        Tich.Nhap(tuNhan,mauNhan);
        Phanso.Xuat(ps1);
        Console.Write("* ");
        Phanso.Xuat(ps2);
        Console.Write("= ");
        Phanso.Xuat(Tich);
        Console.WriteLine();
    }
    public static void Chia(Phanso ps1,Phanso ps2) {
        int tuChia=ps1.Tuso*ps2.Mauso;
        int mauChia=ps2.Tuso*ps1.Mauso;
        int ucln=Program.UCLN(tuChia,mauChia);
        Phanso Thuong=new Phanso();
        if (ucln!=1) {
            tuChia=tuChia/ucln;
            mauChia=mauChia/ucln;
        }
        Thuong.Nhap(tuChia,mauChia);
        Phanso.Xuat(ps1);
        Console.Write("/ ");
        Phanso.Xuat(ps2);
        Console.Write("= ");
        Phanso.Xuat(Thuong);
        Console.WriteLine();
    }
}
class Program {
    static void Main(string[] args) {
        Phanso ps1=new Phanso();
        Phanso ps2=new Phanso();
        Console.Write("Tu so phan so 1: ");
        int tu1=Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Mau so phan so 1: ");
        int mau1=Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Tu so phan so 2: ");
        int tu2=Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Mau so phan so 2: ");
        int mau2=Convert.ToInt32(Console.ReadLine()!);
        ps1.Nhap(tu1,mau1);
        ps2.Nhap(tu2,mau2);
        Phanso.Cong(ps1,ps2);
        Phanso.Tru(ps1,ps2);
        Phanso.Nhan(ps1,ps2);
        Phanso.Chia(ps1,ps2);
    }
    public static int UCLN(int a,int b) {
        if (a<0) {a=-a;}
        if (b<0) {b=-b;}
        if (a>b) {
            a=a+b;
            b=a-b;
            a=a-b;
        }
        for (int i=a;i>1;i--) {
            if ((a%i==0)&&(b%i==0)) {return i;}
        }
        return 1;
    }
}