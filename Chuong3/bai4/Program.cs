class Triangle {
    public int a,b,c,chuvi;
    public double dientich;
    bool kt=true;
    public Triangle() {
        chuvi=0;
        dientich=0;
    }
    public void Nhap() {
        Console.Write("Nhap canh thu nhat: ");
        a=Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Nhap canh thu hai : ");
        b=Convert.ToInt32(Console.ReadLine()!);
        Console.Write("Nhap canh thu ba  : ");
        c=Convert.ToInt32(Console.ReadLine()!);
        if (((a+b)<=c)||((b+c)<=a)||((a+c)<=b)) kt=false;
    }
    public void Xuat() {
        Tinh(ref chuvi,ref dientich);
        if (kt) {
            Console.WriteLine("Ba canh tam giac da nhap la: {0}, {1}, {2}.",a,b,c);
            Console.WriteLine("Chu vi cua tam giac la {0}.",chuvi);
            Console.WriteLine("Dien tich cua tam giac la {0}.",dientich);
        }
    }
    public void Tinh(ref int p, ref double s) {
        if (kt) {
            p=a+b+c;
            s=Math.Sqrt((p/2)*(p/2-a)*(p/2-b)*(p/2-c));
        }
        else Console.WriteLine("Tam giac da nhap khong hop le.");
    }
    ~Triangle() {
        Console.WriteLine("Doi tuong Triangle da bi huy.");
    }
}
class Program {
    static void Main(string[] args) {
        Triangle tamgiac=new Triangle();
        while (true) {
            Console.WriteLine(" ______________________________________________");
            Console.WriteLine("|                                              |");
            Console.WriteLine("| Bam 1 de nhap 3 canh cua tam giac.           |");
            Console.WriteLine("| Bam 2 de tinh chu vi va dien tich tam giac.  |");
            Console.WriteLine("| Bam 3 de xuat cac gia tri cua tam giac.      |");
            Console.WriteLine("| Bam 0 de thoat khoi chuong trinh.            |");
            Console.WriteLine("|______________________________________________|\n");
            string kt=Console.ReadLine()!;
            if (String.Compare(kt,"0",true)==0) break;
            else switch (kt) {
                case "1": tamgiac.Nhap(); break;
                case "2": tamgiac.Tinh(ref tamgiac.chuvi,ref tamgiac.dientich); break;
                case "3": tamgiac.Xuat(); break;
                default: break;
            }
        }
    }
}