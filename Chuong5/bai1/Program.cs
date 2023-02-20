class HinhTron {
    protected float bankinh,duongkinh,dientich;
    public HinhTron(float bankinh) {
        this.bankinh=bankinh;
        this.duongkinh=bankinh*2;
        this.tinhDientich();
    }
    protected void tinhDientich() {
        dientich=bankinh*bankinh/100*314;
    }
    public void Xuat() {
        Console.WriteLine("Hinh tron ban kinh {0:0.00} co duong kinh {1:0.00} va dien tich bang {2:0.00}.",bankinh,duongkinh,dientich);
    }
}
class HinhCau : HinhTron {
    protected float thetich;
    public HinhCau(float bankinh):base(bankinh) {
        this.duongkinh=bankinh*2;
        tinhDientich();
        tinhThetich();
    }
    public new void tinhDientich() {
        dientich=bankinh*bankinh/25*314;
    }
    public void tinhThetich() {
        thetich=bankinh*bankinh*bankinh/75*314;
    }
    public new void Xuat() {
        Console.WriteLine("Hinh cau ban kinh {0:0.00}, duong kinh {1:0.00} co dien tich {2:0.00} va the tich {3:0.00}.",bankinh,duongkinh,dientich,thetich);
    }
}
class HinhTruTron : HinhTron {
    float chieucao,thetich;
    public HinhTruTron(float bankinh,float chieucao):base(bankinh) {
        this.duongkinh=2*bankinh;
        this.chieucao=chieucao;
        tinhDientich();
        tinhThetich();
    }
    public float Chuvi() {
        return duongkinh/100*314;
    }
    public float dtxq() {
        return Chuvi()*chieucao;
    }
    public float dtday() {
        return bankinh*bankinh/100*314;
    }
    public new void tinhDientich() {
        dientich=dtxq()+dtday();
    }
    public void tinhThetich() {
        thetich=314*bankinh*bankinh*chieucao/100;
    }
    public new void Xuat() {
        Console.WriteLine("Hinh tru tron ban kinh {0:0.00}, duong kinh {1:0.00} va cao {2:0.00} co cac thuoc tinh:",bankinh,duongkinh,chieucao);
        Console.WriteLine("Chu vi mat day: {0:0.00}\nDien tich mat day: {1:0.00}",Chuvi(),dtday());
        Console.WriteLine("Dien tich xung quanh: {0:0.00}\nDien tich toan phan: {1:0.00}",dtxq(),dientich);
        Console.WriteLine("The tich: {0:0.00}",thetich);
    }
}
class Program {
    static void Main(string[] args) {
        HinhTron tron = new HinhTron(5);
        HinhCau cau = new HinhCau(5);
        HinhTruTron tru = new HinhTruTron(5,10);
        tron.Xuat();
        cau.Xuat();
        tru.Xuat();
    }
}