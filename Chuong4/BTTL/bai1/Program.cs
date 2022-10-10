class BDS {
    string MaBDS,TenBDS,Huong,Diachi;
    int Dientich;
    float GiaBan;
    public static List<BDS> dsBDS=new List<BDS>();
    public BDS(string[] info) {
        this.MaBDS=info[0];
        this.TenBDS=info[1];
        this.Huong=info[2];
        this.Diachi=info[3];
        this.Dientich=Convert.ToInt32(info[4]);
        this.GiaBan=float.Parse(info[5]);
    }
    public BDS(string ma,string ten,string huong,string dc,string dt,string gia) {
        this.MaBDS=ma;
        this.TenBDS=ten;
        this.Huong=huong;
        this.Diachi=dc;
        this.Dientich=Convert.ToInt32(dt);
        this.GiaBan=float.Parse(gia);
    }
    public static BDS? findBDSbyID(string id) {
        foreach(BDS bds in dsBDS) {
            if (bds.MaBDS==id) {
                return bds;
            }
        }
        return default(BDS);
    }
    public static void updateBDS(string id) {
        BDS bds=findBDSbyID(id)!;
        if (bds!=null) {
            Console.Write("Tên mới:");
            bds.TenBDS=Console.ReadLine()!;
            Console.Write("Hướng mới:");
            bds.Huong=Console.ReadLine()!;
            Console.Write("Địa chỉ mới:");
            bds.Diachi=Console.ReadLine()!;
            Console.Write("Diện tích mới:");
            bds.Dientich=Convert.ToInt32(Console.ReadLine());
            Console.Write("Giá bán mới:");
            bds.GiaBan=float.Parse(Console.ReadLine()!);
        }
        else {Console.WriteLine("Không tìm thấy bất động sản cần chỉnh sửa.");}
    }
    public static void removeBDS(string id) {
        BDS bds=findBDSbyID(id)!;
        if (bds!=null) {
            dsBDS.Remove(bds);
            Console.WriteLine("Đã xóa 1 bất động sản.");
        }
        else {Console.WriteLine("Không tìm thấy bất động sản cần xóa.");}
    }
    public static void exportBDS() {
        Console.WriteLine(' '+new String('_',100));
        Console.WriteLine("|{0,-5}|{1,-10}|{2,-10}|{3,-50}|{4,-10}|{5,-10}|","MãBDS","Tên","Hướng","Địa chỉ","Diện tích","Giá bán");
        Console.WriteLine('|'+new String('_',5)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',50)+'|'+new String('_',10)+'|'+new String('_',10)+'|');
        foreach(BDS bds in dsBDS) {
            Console.WriteLine("|{0,-5}|{1,-10}|{2,-10}|{3,-50}|{4,10}|{5,10:0.0}|",bds.MaBDS,bds.TenBDS,bds.Huong,bds.Diachi,bds.Dientich,bds.GiaBan);
        }
        Console.WriteLine('|'+new String('_',5)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',50)+'|'+new String('_',10)+'|'+new String('_',10)+'|');
    }
    public static void findBDSbyName(string ten) {
        bool kt=false;
        foreach(BDS bds in dsBDS) {
            if (bds.TenBDS==ten) {
                if (kt==false) {
                    Console.WriteLine(' '+new String('_',100));
                    Console.WriteLine("|{0,-5}|{1,-10}|{2,-10}|{3,-50}|{4,-10}|{5,-10}|","MãBDS","Tên","Hướng","Địa chỉ","Diện tích","Giá bán");
                    Console.WriteLine('|'+new String('_',5)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',50)+'|'+new String('_',10)+'|'+new String('_',10)+'|');
                }
                kt=true;
                Console.WriteLine("|{0,-5}|{1,-10}|{2,-10}|{3,-50}|{4,10}|{5,10:0.0}|",bds.MaBDS,bds.TenBDS,bds.Huong,bds.Diachi,bds.Dientich,bds.GiaBan);
            }
        }
        if (kt==false) {
            Console.WriteLine("Không tìm thấy.");
        }
        else {Console.WriteLine('|'+new String('_',5)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',50)+'|'+new String('_',10)+'|'+new String('_',10)+'|');}
    }
    public static void findBDSbyDir(string huong) {
        bool kt=false;
        foreach(BDS bds in dsBDS) {
            if (bds.Huong==huong) {
                if (kt==false) {
                    Console.WriteLine(' '+new String('_',100));
                    Console.WriteLine("|{0,-5}|{1,-10}|{2,-10}|{3,-50}|{4,-10}|{5,-10}|","MãBDS","Tên","Hướng","Địa chỉ","Diện tích","Giá bán");
                    Console.WriteLine('|'+new String('_',5)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',50)+'|'+new String('_',10)+'|'+new String('_',10)+'|');
                }
                kt=true;
                Console.WriteLine("|{0,-5}|{1,-10}|{2,-10}|{3,-50}|{4,10}|{5,10:0.0}|",bds.MaBDS,bds.TenBDS,bds.Huong,bds.Diachi,bds.Dientich,bds.GiaBan);
            }
        }
        if (kt==false) {
            Console.WriteLine("Khong tim thay.");
        }
        else {Console.WriteLine('|'+new String('_',5)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',50)+'|'+new String('_',10)+'|'+new String('_',10)+'|');}
    }
    public static void findBDSbyPrice(float GiaS,float GiaT) {
        bool kt=false;
        List<BDS> list= dsBDS.OrderBy(x=>x.GiaBan).ToList();
        foreach(BDS bds in list) {
            if (bds.GiaBan<=GiaT&&bds.GiaBan>=GiaS) {
                if (kt==false) {
                    Console.WriteLine(' '+new String('_',100));
                    Console.WriteLine("|{0,-5}|{1,-10}|{2,-10}|{3,-50}|{4,-10}|{5,-10}|","MãBDS","Tên","Hướng","Địa chỉ","Diện tích","Giá bán");
                    Console.WriteLine('|'+new String('_',5)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',50)+'|'+new String('_',10)+'|'+new String('_',10)+'|');
                }
                kt=true;
                Console.WriteLine("|{0,-5}|{1,-10}|{2,-10}|{3,-50}|{4,10}|{5,10:0.0}|",bds.MaBDS,bds.TenBDS,bds.Huong,bds.Diachi,bds.Dientich,bds.GiaBan);
            }
        }
        if (kt==false) {Console.WriteLine("Khong tim thay.");}
        else {
            Console.WriteLine('|'+new String('_',5)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',50)+'|'+new String('_',10)+'|'+new String('_',10)+'|');
        }
    }
}
class Program {
    static void Main(string[] args) {
        string[] input=File.ReadAllLines("D:\\Personal\\CSharp\\Data\\bds.txt");
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        foreach(string a in input) {
            BDS bds=new BDS(a.Split(';'));
            BDS.dsBDS.Add(bds);
        }
        while (true) {
            Console.WriteLine("\n ______________________________________________");
            Console.WriteLine("|                     MENU                     |");
            Console.WriteLine("| Bấm 1 để thêm mới danh sách.                 |");
            Console.WriteLine("| Bấm 2 để sửa thông tin.                      |");
            Console.WriteLine("| Bấm 3 để xóa thông tin.                      |");
            Console.WriteLine("| Bấm 4 để xuất danh sách.                     |");
            Console.WriteLine("| Bấm 5 để tìm theo tên.                       |");
            Console.WriteLine("| Bấm 6 để tìm theo hướng.                     |");
            Console.WriteLine("| Bấm 7 để tìm theo giá.                       |");
            Console.WriteLine("| Bấm 0 để thoát khỏi chương trình.            |");
            Console.WriteLine("|______________________________________________|\n");
            string kt=Console.ReadLine()!;
            if (String.Compare(kt,"0",true)==0) break;
            else switch (kt) {
                case "1":
                    Console.Write("Mã bất động sản mới: ");
                    string id=Console.ReadLine()!;
                    BDS bds=BDS.findBDSbyID(id)!;
                    if (bds==null) {
                        Console.Write("Tên bất động sản: ");
                        string ten=Console.ReadLine()!;
                        Console.Write("Hướng bất động sản: ");
                        string huong=Console.ReadLine()!;
                        Console.Write("Địa chỉ bất động sản: ");
                        string dc=Console.ReadLine()!;
                        Console.Write("Diện tích bất động sản: ");
                        string dt=Console.ReadLine()!;
                        Console.Write("Giá bán: ");
                        string gia=Console.ReadLine()!;
                        BDS a= new BDS(id,ten,huong,dc,dt,gia);
                        BDS.dsBDS.Add(a);
                    }
                    else {Console.WriteLine("Bất động sản đã tồn tại.");}
                    Console.Write("Bấm Enter để tiếp tục.");break;
                case "2":
                    Console.Write("Mã bất động sản cần chỉnh sửa: ");
                    BDS.updateBDS(Console.ReadLine()!);
                    Console.Write("Bấm Enter để tiếp tục.");
                    Console.ReadKey();break;
                case "3":
                    Console.Write("Mã bất động sản cần xóa: ");
                    BDS.removeBDS(Console.ReadLine()!);
                    Console.Write("Bấm Enter để tiếp tục.");
                    Console.ReadKey();break;
                case "4":
                    BDS.exportBDS();
                    Console.Write("Bấm Enter để tiếp tục.");
                    Console.ReadKey();break;
                case "5":
                    Console.Write("Tên bất động sản muốn tìm: ");
                    BDS.findBDSbyName(Console.ReadLine()!);
                    Console.Write("Bấm Enter để tiếp tục.");
                    Console.ReadKey();break;
                case "6":
                    Console.Write("Hướng bất động sản muốn tìm: ");
                    BDS.findBDSbyDir(Console.ReadLine()!);
                    Console.Write("Bấm Enter để tiếp tục.");
                    Console.ReadKey();break;
                case "7": 
                    Console.Write("Giá thấp nhất mong muốn: ");
                    float gias=float.Parse(Console.ReadLine()!);
                    Console.Write("Giá cao nhất mong muốn: ");
                    float giat=float.Parse(Console.ReadLine()!);
                    BDS.findBDSbyPrice(gias,giat);
                    Console.Write("Bấm Enter để tiếp tục.");
                    Console.ReadKey();break;
                default: break;
            }
        }
    }
}