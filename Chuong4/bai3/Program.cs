class Tamgiac {
    float a,b,c;
    bool kt=true;
    public Tamgiac() {
        a=0;
        b=0;
        c=0;
    }
    ~Tamgiac() {
        Console.WriteLine("Da huy.");
    }
    public void Nhap(float x,float y,float z) {
        a=x;
        b=y;
        c=z;
        if ((a+b<=c)||(a+c<=b)||(b+c<=a)) {kt=false;}
    }
    public void Xuat() {
        Console.Write("Tam giac co 3 canh: {0}, {1}, {2} ",a,b,c);
        switch (Kiemtra())
        {
            case 0: Console.WriteLine("khong ton tai.");break;
            case 1: Console.WriteLine("la tam giac thuong.");break;
            case 2: Console.WriteLine("la tam giac vuong.");break;
            case 3: Console.WriteLine("la tam giac can.");break;
            case 4: Console.WriteLine("la tam giac vuong can.");break;
            case 5: Console.WriteLine("la tam giac deu.");break;
            default: break;
        }
    }
    public float Kiemtra() {
        if (kt) {
            if ((a==b)||(b==c)||(a==c)) {
                if ((a==b)&&(a==c)) {return 5;}
                else {
                    if ((a*a+b*b==c*c)||(a*a+c*c==b*b)||(b*b+c*c==a*a)) {
                        return 4;
                    }
                    else {return 3;}
                }
            }
            else {
                if ((a*a+b*b==c*c)||(a*a+c*c==b*b)||(b*b+c*c==a*a)) {
                    return 2;
                }
                else {return 1;}
            }
        }
        else return 0;
    }
}
class Program {
    static void Main(string[] args) {
        Tamgiac tg=new Tamgiac();
        Console.Write("Nhap canh thu nhat: ");
        float a=float.Parse(Console.ReadLine()!);
        Console.Write("Nhap canh thu hai: ");
        float b=float.Parse(Console.ReadLine()!);
        Console.Write("Nhap canh thu ba: ");
        float c=float.Parse(Console.ReadLine()!);
        tg.Nhap(a,b,c);
        tg.Xuat();
    }
}