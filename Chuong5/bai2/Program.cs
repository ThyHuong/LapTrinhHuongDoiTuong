class People {
    protected string ID,Hoten,Diachi;
    protected int Tuoi;
    public People(string ID,string Hoten,int Tuoi,string Diachi) {
        this.ID=ID;
        this.Hoten=Hoten;
        this.Tuoi=Tuoi;
        this.Diachi=Diachi;
    }
    public static void Nhap() {
        Console.WriteLine("Nhap ID:");
        string id=Console.ReadLine()!;
        Console.WriteLine("Nhap ho ten:");
        string hoten=Console.ReadLine()!;
        Console.WriteLine("Nhap tuoi:");
        int tuoi=Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine("Nhap dia chi:");
        string diachi=Console.ReadLine()!;
        People n = new People(id,hoten,tuoi,diachi);
    }
    public void Xuat() {
        Console.WriteLine("\nID: {0}",ID);
        Console.WriteLine("Ho va ten: {0}\tTuoi: {1}",Hoten,Tuoi);
        Console.WriteLine("Dia chi: {0}",Diachi);
    }
}
class Students : People {
    protected string Term;
    protected float TP1,TP2,TP3,dtb;
    public Students(string ID,string Hoten,int Tuoi,string Diachi,string Term,float TP1,float TP2,float TP3):base(ID,Hoten,Tuoi,Diachi) {
        this.Term=Term;
        this.TP1=TP1;
        this.TP2=TP2;
        this.TP3=TP3;
    }
    public string GPA() {
        this.dtb=(TP1*2+TP2*2+TP3*6)/10;
        string gpa;
        if (this.dtb>=8.5) {gpa="Gioi";}
        else if (this.dtb>=7) {gpa="Kha";}
        else if (this.dtb>=5.5) {gpa="Trung binh";}
        else if (this.dtb>=4.0) {gpa="Yeu";}
        else gpa="Rot mon";
        return gpa;
    }
    public new void Xuat() {
        base.Xuat();
        string g=GPA();
        Console.WriteLine("Diem mon {0}:",Term);
        Console.WriteLine("TP1: {0:0.0}\tTP2: {1:0.0}\tTP3: {2:0.00}",TP1,TP2,TP3);
        Console.WriteLine("Ket qua: {0:0.00}\t Xep loai: {1}",this.dtb,g);
    }
}
class Lecture : People {
    protected int Kinhnghiem;
    protected string Hocvi,Chucvu;
    public static List<Lecture> ds = new List<Lecture>();
    public Lecture(string ID,string Hoten,int Tuoi,string Diachi,int Kinhnghiem,string Hocvi,string Chucvu):base(ID,Hoten,Tuoi,Diachi) {
        this.Kinhnghiem=Kinhnghiem;
        this.Hocvi=Hocvi;
        this.Chucvu=Chucvu;
        ds.Add(this);
    }
    public static void Sapxep() {
        ds=ds.OrderByDescending(x=>x.Kinhnghiem).ToList();
    }
    public new void Xuat() {
        base.Xuat();
        Console.WriteLine("So nam kinh nghiem: {0}",Kinhnghiem);
        Console.WriteLine("Hoc vi: {0}\tChuc vu: {1}",Hocvi,Chucvu);
    }
}
class Program {
    static void Main(string[] args) {
        Students hs = new Students("211121514121","Do Thi Thy Huong",19,"12345 abcdef","HTTTQL",float.Parse("9.8"),10,float.Parse("8.4"));
        Lecture gv1 = new Lecture("123456789012","Nguyen Van A",35,"98745 bheudoa",3,"TS","Giang vien");
        Lecture gv2 = new Lecture("123456789013","Tran Thi B",37,"3864 bashg",4,"ThS","Giang vien");
        hs.Xuat();
        Lecture.Sapxep();
        foreach (Lecture gv in Lecture.ds) {
            gv.Xuat();
        }
    }
}