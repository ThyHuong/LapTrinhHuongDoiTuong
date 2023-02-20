class Room {
    protected string Cname,Cid;
    protected int Time,Price;
    public Room(string Cname,string Cid,int Time) {
        this.Cname=Cname;
        this.Cid=Cid;
        this.Time=Time;
    }
    public static int Revenue() {return 0;}
    protected void Xuat() {
        Console.WriteLine("{0,-25} | {1,-12} | {2,9} | {3,7}",this.Cname,this.Cid,this.Time,this.Price);
    }
    protected static void Print() {}
}
class Standard : Room {
    protected static List<Standard> Slist=new List<Standard>();
    public Standard(string Cname,string Cid,int Time) : base(Cname,Cid,Time) {
        if (this.Time<5) {this.Price=500;}
        else {this.Price=400;}
        this.Price*=this.Time;
        Slist.Add(this);
    }
    public static new int Revenue() {
        int r=0;
        foreach (Standard room in Slist) {
            r+=room.Price;
        }
        return r;
    }
    protected new void Xuat() {
        Console.Write("Standard  | ");
        base.Xuat();
    }
    public static new void Print() {
        foreach (Standard room in Slist) {
            room.Xuat();
        }
    }
}
class VIP : Room {
    protected static List<VIP> Vlist=new List<VIP>();
    protected static List<VIP> Llist=new List<VIP>();
    protected string RoomType;
    public VIP(string Cname,string Cid,int Time,string RoomType) : base(Cname,Cid,Time) {
        this.RoomType=RoomType;
        this.Price=this.Time;
        if (RoomType=="L") {
            if (this.Time<5) {this.Price*=1100;}
            else {this.Price*=1000;}
            Llist.Add(this);
        }
        else {
            if (this.Time<5) {this.Price*=1300;}
            else {this.Price*=1000;}
        }
        Vlist.Add(this);
    }
    public static new int Revenue() {
        int r=0;
        foreach (VIP room in Vlist) {
            r+=room.Price;
        }
        return r;
    }
    protected new void Xuat() {
        if (this.RoomType=="L") {Console.Write("Luxury    | ");}
        else {Console.Write("President | ");}
        base.Xuat();
    }
    public static new void Print() {
        foreach (VIP room in Vlist) {
            room.Xuat();
        }
    }
    public static int Revenue(string key) {
        int r=0;
        foreach (VIP room in Llist) {
            r+=room.Price;
        }
        return r;
    }
}
class Program {
    static void Nhap(ref string Cname,ref string Cid,ref int Time) {
        Console.Write("Ten khach hang: ");
        Cname=Console.ReadLine()!;
        Console.Write("So CMND/CCCD khach hang: ");
        Cid=Console.ReadLine()!;
        Console.Write("So ngay thue: ");
        Time=Convert.ToInt32(Console.ReadLine()!);
    }
    static void Main(string[] args) {
        new Standard("Nguyen Van A","123456789010",5);
        new Standard("Hoang Thi D","123456789013",2);
        new VIP("Tran Thi B","123456789011",3,"L");
        new VIP("Mai Van C","123456789012",7,"P");
        new VIP("Luu Van E","123456789014",6,"L");
        new VIP("Doan Thi G","123456789015",1,"P");
        string Cname="",Cid="",RoomType="";
        int Time=0;
        while (true) {
            Console.WriteLine("\n ______________________________________________");
            Console.WriteLine("|                     __                       |");
            Console.WriteLine("|_____________|\\\\ /| ||_ |\\\\| || ||____________|");
            Console.WriteLine("|             ||\\//| ||_ ||\\| ||_||            |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("|  Bam 1 de them moi danh sach.                |");
            Console.WriteLine("|  Bam 2 de tinh doanh thu thue phong.         |");
            Console.WriteLine("|  Bam 3 de xuat thong tin thue phong.         |");
            Console.WriteLine("|  Bam 4 de xuat thong tin thue Standard.      |");
            Console.WriteLine("|  Bam 5 de tinh doanh thu phong Luxury.       |");
            Console.WriteLine("|  Bam 0 de thoat khoi chuong trinh.           |");
            Console.WriteLine("|______________________________________________|\n");
            string kt=Console.ReadLine()!;
            if (kt=="0") {break;}
            switch (kt) {
                case "1":
                    Console.Write("Loai phong: (Standard/VIP) ");
                    RoomType=Console.ReadLine()!;
                    Nhap(ref Cname,ref Cid,ref Time);
                    if (RoomType=="S") {new Standard(Cname,Cid,Time);}
                    else {
                        Console.Write("Luxury/President: ");
                        new VIP(Cname,Cid,Time,Console.ReadLine()!);
                    }
                    break;
                case "2":
                    Console.WriteLine("Doanh thu phong Standard: {0}",Standard.Revenue());
                    Console.WriteLine("Doanh thu phong VIP: {0}",VIP.Revenue());
                    break;
                case "3":
                    Console.WriteLine("Room Type | {0,-25} | {1,-12} | NumOfDays | Total","Ten khach hang","CMND/CCCD");
                    Standard.Print();
                    VIP.Print();
                    break;
                case "4":
                    Console.WriteLine("Room Type | {0,-25} | {1,-12} | NumOfDays | Total","Ten khach hang","CMND/CCCD");
                    Standard.Print();
                    break;
                case "5":
                    Console.WriteLine("Doanh thu phong Luxury: {0}",VIP.Revenue("L"));
                    break;
                default: break;
            }
            Console.Write("Bam phim bat ky de tiep tuc.");
            Console.ReadKey();
        }
    }
}