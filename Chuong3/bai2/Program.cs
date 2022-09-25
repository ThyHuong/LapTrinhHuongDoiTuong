class Meo {
    public string Ten,Giong,Gioitinh;
    public int Tuoi;
    public static int dem;
    public Meo() {
        Ten="";
        Giong="";
        Gioitinh="";
        Tuoi=0;
    }
    public void Nhap(string ten,string giong,string gt,int t) {
        Ten=ten;
        Giong=giong;
        Gioitinh=gt;
        Tuoi=t;
        Dem();
    }
    public void Xuat() {
        Console.WriteLine("Ten: {0}\nGiong: {1}",Ten,Giong);
        Console.WriteLine("Gioi tinh: {0}\nTuoi: {1}",Gioitinh,Tuoi);
    }
    ~Meo() {
        Console.WriteLine("Doi tuong Meo da bi huy.");
    }
    public void Dem() {
        dem++;
    }
}
class Program {
    static void Main(string[] args) {
        List<Meo> list = new List<Meo>();
        while (true) {
            Meo a = new Meo();
            Console.Write("Ten meo: ");
            string Ten=Console.ReadLine()!;
            Console.Write("Giong meo: ");
            string Giong=Console.ReadLine()!;
            Console.Write("Gioi tinh: ");
            string gioitinh=Console.ReadLine()!;
            Console.Write("Tuoi: ");
            int tuoi=Convert.ToInt32(Console.ReadLine()!);
            a.Nhap(Ten,Giong,gioitinh,tuoi);
            list.Add(a);
            Console.Write("Tiep tuc nhap? (y/n)");
            string kt=Console.ReadLine()!;
            if (String.Compare(kt,"n",true)==0) break;
        }
        foreach(Meo a in list) {
            a.Xuat();
        }
        Console.WriteLine("Tong cong da nhap thong tin {0} con meo.",Meo.dem);
    }
}