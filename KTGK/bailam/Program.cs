class Hospital {
    static List<Hospital> Benhnhan=new List<Hospital>();
    string? MaBN,TenBN,Benh,BHYT;
    int SoNgay;
    string? ma {
        get {return MaBN;}
        set {MaBN=value;}
    }
    string? ten {
        get {return TenBN;}
        set {TenBN=value;}
    }
    string? B {
        get {return Benh;}
        set {Benh=value;}
    }
    string? bhyt {
        get {return BHYT;}
        set {BHYT=value;}
    }
    int SN {
        get {return SoNgay;}
        set {SoNgay=value;}
    }
    public Hospital(string[] info) {
        this.ma=info[0];
        this.ten=info[1];
        this.B=info[2];
        this.bhyt=info[3];
        this.SN=Convert.ToInt32(info[4]);
        Benhnhan.Add(this);
    }
    public Hospital(string ma,string ten,string benh,string bh,int sn) {
        this.ma=ma;
        this.ten=ten;
        this.B=benh;
        this.bhyt=bh;
        this.SN=sn;
        Benhnhan.Add(this);
    }
    public static void Nhap() {
        bool kt=false;
        Console.Write("Nhap ma benh nhan: ");;
        string mbn=Console.ReadLine()!;
        foreach (Hospital b in Benhnhan) {
            if (b.ma==mbn) {
                Console.WriteLine("Ma benh nhan bi trung.");
                kt=true;
                break;
            }
        }
        if (kt==false) {
            Console.Write("Nhap ten benh nhan: ");
            string ten=Console.ReadLine()!;
            Console.Write("Nhap benh cua benh nhan: ");
            string benh=Console.ReadLine()!;
            Console.Write("Benh nhan co BHYT khong? (Co/Khong) ");
            string BHYT=Console.ReadLine()!;
            Console.Write("So ngay nhap vien cua benh nhan: ");
            int songay=Convert.ToInt32(Console.ReadLine()!);
            Hospital bn=new Hospital(mbn,ten,benh,BHYT,songay);
        }
    }
    public static void updateBN(string ma) {
        bool kt=false;
        foreach (Hospital bn in Benhnhan) {
            if (bn.ma==ma) {
                kt=true;
                Console.Write("Nhap ten benh nhan moi: ");
                bn.ten=Console.ReadLine()!;
                Console.Write("Nhap benh moi: ");
                bn.B=Console.ReadLine()!;
                Console.Write("Co BHYT khong? (Co/Khong) ");
                bn.bhyt=Console.ReadLine()!;
                Console.Write("So ngay nhap vien: ");
                bn.SN=Convert.ToInt32(Console.ReadLine()!);
                Console.WriteLine("Da chinh sua xong thong tin benh nhan.");
            }
        }
        if (kt==false) {Console.WriteLine("Khong tim thay benh nhan.");}
    }
    public static void Thanhtoan() {
        Console.WriteLine("{0}   | {1}                | {2}","MaBN","TenBN","VPhi");
        foreach (Hospital bn in Benhnhan) {
            int price;
            if (bn.bhyt=="Co") {
                price=1500*bn.SN*15;
            }
            else {price=150000*bn.SN;}
            Console.WriteLine("{0} | {1}"+new string(' ',20-bn.ten!.Length)+" | {2}",bn.ma,bn.ten,price);
        }
    }
}
class Program {
    static void Main(string[] args) {
        string[] input=File.ReadAllLines("benhnhan.txt");
        foreach (string chuoi in input) {
            Hospital bn=new Hospital(chuoi.Split(";"));
        }
        string todo="1";
        while (todo!="0") {
            Console.WriteLine("\n******************* MENU *******************");
            Console.WriteLine("*                                          *");
            Console.WriteLine("* Nhap 1 de them moi benh nhan.            *");
            Console.WriteLine("* Nhap 2 de chinh sua thong tin benh nhan. *");
            Console.WriteLine("* Nhap 3 de xuat thong tin vien phi.       *");
            Console.WriteLine("* Nhap 0 de thoat khoi chuong trinh.       *");
            Console.WriteLine("*                                          *");
            Console.WriteLine("********************************************");
            todo=Console.ReadLine()!;
            switch (todo)
            {
                case "1":
                    Hospital.Nhap();
                    break;
                case "2":
                    Console.Write("Nhap ma benh nhan muon sua: ");
                    string ma=Console.ReadLine()!;
                    Hospital.updateBN(ma);
                    break;
                case "3": Hospital.Thanhtoan();break;
                default: break;
            }
            if (todo!="0") {
                Console.Write("Bam phim bat ky de tiep tuc.");
                Console.ReadKey();
            }
        }
    }
}