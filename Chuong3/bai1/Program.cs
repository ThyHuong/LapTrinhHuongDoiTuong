class Sach {
    public string Tensach,Tacgia;
    public int NamXB,Soluong;
    public Sach() {
        Tensach="";
        Tacgia="";
        NamXB=0;
        Soluong=0;
    }
    public void Nhap(string ten,string tg,int nxb,int sl) {
        Tensach=ten;
        Tacgia=tg;
        NamXB=nxb;
        Soluong=sl;
    }
    public void Xuat() {
        Console.WriteLine("Ten: {0}\nTac gia: {1}",Tensach,Tacgia);
        Console.WriteLine("Nam xuat ban: {0}\nSo luong: {1}",NamXB,Soluong);
    }
    ~Sach() {
        Console.WriteLine("Doi tuong Sach da bi huy.");
    }
}
class Program {
    static void Main(string[] args) {
        List<Sach> list = new List<Sach>();
        while (true) {
            Sach a = new Sach();
            Console.Write("Ten sach: ");
            string Tensach=Console.ReadLine()!;
            Console.Write("Tac gia: ");
            string Tacgia=Console.ReadLine()!;
            Console.Write("Nam xuat ban: ");
            int NamXB=Convert.ToInt32(Console.ReadLine()!);
            Console.Write("So luong: ");
            int Soluong=Convert.ToInt32(Console.ReadLine()!);
            a.Nhap(Tensach,Tacgia,NamXB,Soluong);
            list.Add(a);
            Console.Write("Tiep tuc nhap? (y/n)");
            string kt=Console.ReadLine()!;
            if (String.Compare(kt,"n",true)==0) break;
        }
        foreach(Sach a in list) {
            a.Xuat();
        }
    }
}