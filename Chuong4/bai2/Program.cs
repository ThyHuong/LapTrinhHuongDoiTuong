class SoPhuc {
    float PhanThuc,PhanAo;
    public SoPhuc() {
        PhanThuc=0;
        PhanAo=0;
    }
    ~SoPhuc() {
        Console.WriteLine("Da huy.");
    }
    public void Nhap(float thuc,float ao) {
        PhanThuc=thuc;
        PhanAo=ao;
    }
    public static void Xuat(SoPhuc sp) {
        if (sp.PhanThuc!=0) {
            if (sp.PhanAo!=0) {
                if (sp.PhanAo>0) {
                    if (sp.PhanAo==1) {Console.Write("{0}+i ",sp.PhanThuc);}
                    else {Console.Write("{0}+{1}i ",sp.PhanThuc,sp.PhanAo);}
                }
                else {
                    if (sp.PhanAo==-1) {Console.Write("{0}-i ",sp.PhanThuc);}
                    else {Console.Write("{0}-{1}i ",sp.PhanThuc,-sp.PhanAo);}
                }
            }
            else {Console.Write("{0} ",sp.PhanThuc);}
        }
        else {
            if (sp.PhanAo!=0) {
                if (sp.PhanAo>0) {
                    if (sp.PhanAo==1) {Console.Write("i ");}
                    else {Console.Write("{1}i ",sp.PhanAo);}
                }
                else {
                    if (sp.PhanAo==-1) {Console.Write("-i ");}
                    else {Console.Write("-{1}i ",-sp.PhanAo);}
                }
            }
            else {Console.Write("0 ");}
        }
    }
    public static void Cong(SoPhuc sp1,SoPhuc sp2) {
        float thucCong=sp1.PhanThuc+sp2.PhanThuc;
        float aoCong=sp2.PhanAo+sp1.PhanAo;
        SoPhuc Tong=new SoPhuc();
        Tong.Nhap(thucCong,aoCong);
        SoPhuc.Xuat(sp1);
        Console.Write("+ ");
        SoPhuc.Xuat(sp2);
        Console.Write("= ");
        SoPhuc.Xuat(Tong);
        Console.WriteLine();
    }
    public static void Tru(SoPhuc sp1,SoPhuc sp2) {
        float thucTru=sp1.PhanThuc-sp2.PhanThuc;
        float aoTru=sp1.PhanAo-sp2.PhanAo;
        SoPhuc Hieu=new SoPhuc();
        Hieu.Nhap(thucTru,aoTru);
        SoPhuc.Xuat(sp1);
        Console.Write("- ");
        SoPhuc.Xuat(sp2);
        Console.Write("= ");
        SoPhuc.Xuat(Hieu);
        Console.WriteLine();
    }
    public static void Nhan(SoPhuc sp1,SoPhuc sp2) {
        float thucNhan=sp1.PhanThuc*sp2.PhanThuc-sp1.PhanAo*sp2.PhanAo;
        float aoNhan=sp1.PhanThuc*sp2.PhanAo+sp2.PhanThuc*sp1.PhanAo;
        SoPhuc Tich=new SoPhuc();
        Tich.Nhap(thucNhan,aoNhan);
        SoPhuc.Xuat(sp1);
        Console.Write("* ");
        SoPhuc.Xuat(sp2);
        Console.Write("= ");
        SoPhuc.Xuat(Tich);
        Console.WriteLine();
    }
    public static void Chia(SoPhuc sp1,SoPhuc sp2) {
        float thucChia=sp1.PhanThuc*sp2.PhanThuc-sp1.PhanAo*(-sp2.PhanAo);
        float aoChia=sp1.PhanThuc*(-sp2.PhanAo)+sp2.PhanThuc*sp1.PhanAo;
        float mau=sp2.PhanAo*sp2.PhanAo+sp2.PhanThuc*sp2.PhanThuc;
        thucChia=thucChia/mau;
        aoChia=aoChia/mau;
        SoPhuc Thuong=new SoPhuc();
        Thuong.Nhap(thucChia,aoChia);
        SoPhuc.Xuat(sp1);
        Console.Write("/ ");
        SoPhuc.Xuat(sp2);
        Console.Write("= ");
        SoPhuc.Xuat(Thuong);
        Console.WriteLine();
    }
}
class Program {
    static void Main(string[] args) {
        SoPhuc sp1=new SoPhuc();
        SoPhuc sp2=new SoPhuc();
        Console.Write("Phan thuc phan so 1: ");
        float thuc1=float.Parse(Console.ReadLine()!);
        Console.Write("Phan ao phan so 1: ");
        float ao1=float.Parse(Console.ReadLine()!);
        Console.Write("Phan thuc phan so 2: ");
        float thuc2=float.Parse(Console.ReadLine()!);
        Console.Write("Phan ao phan so 2: ");
        float ao2=float.Parse(Console.ReadLine()!);
        sp1.Nhap(thuc1,ao1);
        sp2.Nhap(thuc2,ao2);
        SoPhuc.Cong(sp1,sp2);
        SoPhuc.Tru(sp1,sp2);
        SoPhuc.Nhan(sp1,sp2);
        SoPhuc.Chia(sp1,sp2);
    }
}