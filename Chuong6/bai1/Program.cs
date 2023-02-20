abstract class Hinhhoc {
    protected float chuvi,dientich;
    public abstract void tinhChuvi();
    public abstract void tinhDientich();
    public void Xuat() {
        this.tinhChuvi();
        this.tinhDientich();
    }
}
class HinhChuNhat : Hinhhoc {
    protected float dai,rong;
    public HinhChuNhat(float dai,float rong) {
        this.dai=dai;
        this.rong=rong;
    }
    public override void tinhChuvi() {
        chuvi=2*(dai+rong);
    }
    public override void tinhDientich() {
        dientich=dai*rong;
    }
    public new void Xuat() {
        base.Xuat();
        Console.WriteLine("Hinh chu nhat co dai={0:0.0} va rong={1:0.0} co chu vi={2:0.0} va dien tich={3:0.0}.",dai,rong,chuvi,dientich);
    }
}
class Hinhtron : Hinhhoc {
    protected float bankinh;
    public Hinhtron(float bankinh) {
        this.bankinh=bankinh;
    }
    public override void tinhChuvi() {
        chuvi=2*bankinh/100*314;
    }
    public override void tinhDientich() {
        dientich=bankinh*bankinh/100*314;
    }
    public new void Xuat() {
        base.Xuat();
        Console.WriteLine("Hinh tron co ban kinh={0:0.0} co chu vi={1:0.00} va dien tich={2:0.00}.",bankinh,chuvi,dientich);
    }
}
class Hinhtamgiac : Hinhhoc {
    protected float a,b,c;
    public Hinhtamgiac(float a,float b,float c) {
        this.a=a;
        this.b=b;
        this.c=c;
    }
    public override void tinhChuvi() {
        chuvi=a+b+c;
    }
    public override void tinhDientich() {
        dientich=float.Parse(Convert.ToString(Math.Sqrt((chuvi/2)*(chuvi/2-a)*(chuvi/2-b)*(chuvi/2-c))));
    }
    public new void Xuat() {
        base.Xuat();
        Console.WriteLine("Hinh tam giac co 3 canh lan luot {0:0.0}, {1:0.0}, {2:0.0} co chu vi={3:0.0} va dien tich={4:0.00}.",a,b,c,chuvi,dientich);
    }
}
class Hinhvuong : Hinhhoc {
    protected float a;
    public Hinhvuong(float a) {
        this.a=a;
    }
    public override void tinhChuvi() {
        chuvi=4*a;
    }
    public override void tinhDientich() {
        dientich=a*a;
    }
    public new void Xuat() {
        base.Xuat();
        Console.WriteLine("Hinh vuong co canh {0:0.0} co chu vi={1:0.0} va dien tich={2:0.00}.",a,chuvi,dientich);
    }
}
class Program {
    static void Main(string[] args) {
        HinhChuNhat hcn=new HinhChuNhat(5,10);
        Hinhtron ht=new Hinhtron(5);
        Hinhtamgiac htg=new Hinhtamgiac(3,4,5);
        Hinhvuong hv=new Hinhvuong(5);
        hcn.Xuat();
        ht.Xuat();
        htg.Xuat();
        hv.Xuat();
    }
}