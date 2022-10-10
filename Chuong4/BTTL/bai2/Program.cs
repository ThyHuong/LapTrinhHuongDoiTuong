class Thangleo {
    string MaThang,LoaiThang,Chieucao;
    int Soluong;
    float Giaban;
    public static List <Thangleo> dsThang=new List<Thangleo>();
    public Thangleo(string[] info) {
        this.MaThang=info[0];
        this.LoaiThang=info[1];
        this.Chieucao=info[2];
        this.Soluong=Convert.ToInt32(info[3]);
        this.Giaban=float.Parse(info[4]);
    }
    public Thangleo(string ma,string loai,string cao,string luong,string gia) {
        this.MaThang=ma;
        this.LoaiThang=loai;
        this.Chieucao=cao;
        this.Soluong=Convert.ToInt32(luong);
        this.Giaban=float.Parse(gia);
    }
    public static Thangleo? findThangbyMa(string ma) {
        foreach(Thangleo thang in dsThang) {
            if (thang.MaThang==ma) {
                return thang;
            }
        }
        return default(Thangleo);
    }
    public static void exportThang() {
        Console.WriteLine(' '+new String('_',64));
        Console.WriteLine("|{0,-10}|{1,-20}|{2,-10}|{3,-10}|{4,-10}|","Mã Thang","Loại Thang","Chiều cao","Số lượng","Giá bán");
        Console.WriteLine('|'+new String('_',10)+'|'+new String('_',20)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',10)+'|');
        foreach(Thangleo thang in dsThang) {
            Console.WriteLine("|{0,-10}|{1,-20}|{2,-10}|{3,10}|{4,10:0.0}|",thang.MaThang,thang.LoaiThang,thang.Chieucao,thang.Soluong,thang.Giaban);
        }
        Console.WriteLine('|'+new String('_',10)+'|'+new String('_',20)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',10)+'|'); 
    }
    public static void findThangbyHeight(int ghduoi,int ghtren) {
        Console.WriteLine(' '+new String('_',64));
        Console.WriteLine("|{0,-10}|{1,-20}|{2,-10}|{3,-10}|{4,-10}|","Mã Thang","Loại Thang","Chiều cao","Số lượng","Giá bán");
        Console.WriteLine('|'+new String('_',10)+'|'+new String('_',20)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',10)+'|');
        foreach (Thangleo Thang in dsThang) {
            int cao=Convert.ToInt32(Thang.Chieucao.Substring(0,Thang.Chieucao.Length-1));
            if ((cao>=ghduoi)&&(cao<=ghtren)) {
                Console.WriteLine("|{0,-10}|{1,-20}|{2,-10}|{3,10}|{4,10:0.0}|",Thang.MaThang,Thang.LoaiThang,Thang.Chieucao,Thang.Soluong,Thang.Giaban);
            }
        }
        Console.WriteLine('|'+new String('_',10)+'|'+new String('_',20)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',10)+'|');
    }
    public static void sortThangbyPrice() {
        dsThang=dsThang.OrderBy(x=>x.Giaban).ToList();
    }
    public static void checkAccessibility(string ma,int need) {
        bool kt=false;
        foreach (Thangleo Thang in dsThang) {
            if (Thang.MaThang==ma) {
                kt=true;
                if (Thang.Soluong>=need) {Console.WriteLine("OK");}
                else {Console.WriteLine("Chỉ còn {0} thang. Không đủ hàng.",Thang.Soluong);}
                break;
            }
        }
        if (kt!=true) {Console.WriteLine("Không tìm thấy mã thang.");}
    }
    public static void compareThang(string loai,int cao) {
        Thangleo min=dsThang[0];
        Thangleo max=dsThang[0];
        bool kt=false;
        foreach (Thangleo Thang in dsThang) {
            if ((Thang.LoaiThang==loai)&&(Convert.ToInt32(Thang.Chieucao.Substring(0,Thang.Chieucao.Length-1))==cao)) {
                if (kt) {
                    if (Thang.Giaban<min.Giaban) {
                        min=Thang;
                    }
                    else if (Thang.Giaban>max.Giaban) {
                        max=Thang;
                    }
                }
                else {
                    min=Thang;
                    max=Thang;
                    kt=true;
                }
            }
        }
        if (kt) {
            Console.WriteLine(' '+new String('_',64));
            Console.WriteLine("|{0,-10}|{1,-20}|{2,-10}|{3,-10}|{4,-10}|","Mã Thang","Loại Thang","Chiều cao","Số lượng","Giá bán");
            Console.WriteLine('|'+new String('_',10)+'|'+new String('_',20)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',10)+'|');
            Console.WriteLine("Thang có mức giá thấp nhất:");
            Console.WriteLine(' '+new String('_',64));
            Console.WriteLine("|{0,-10}|{1,-20}|{2,-10}|{3,10}|{4,10:0.0}|",min.MaThang,min.LoaiThang,min.Chieucao,min.Soluong,min.Giaban);
            Console.WriteLine('|'+new String('_',10)+'|'+new String('_',20)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',10)+'|');
            Console.WriteLine("Thang có mức giá cao nhất:");
            Console.WriteLine(' '+new String('_',64));
            Console.WriteLine("|{0,-10}|{1,-20}|{2,-10}|{3,10}|{4,10:0.0}|",max.MaThang,max.LoaiThang,max.Chieucao,max.Soluong,max.Giaban);
            Console.WriteLine('|'+new String('_',10)+'|'+new String('_',20)+'|'+new String('_',10)+'|'+new String('_',10)+'|'+new String('_',10)+'|');
        }
        else {
            Console.WriteLine("Không tồn tại phân khúc.");
        }
    }
}
class Program {
    static void Main(string[] args) {
        string[] input=File.ReadAllLines("D:\\Personal\\CSharp\\Data\\thangleo.txt");
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        foreach(string a in input) {
            Thangleo Thang=new Thangleo(a.Split(';'));
            Thangleo.dsThang.Add(Thang);
        }
        while (true) {
            Console.WriteLine("\n ______________________________________________");
            Console.WriteLine("|                     MENU                     |");
            Console.WriteLine("| Bấm 1 để thêm mới danh sách.                 |");
            Console.WriteLine("| Bấm 2 để xuất danh sách.                     |");
            Console.WriteLine("| Bấm 3 để tìm sản phẩm.                       |");
            Console.WriteLine("| Bấm 4 để sắp xếp theo giá bán.               |");
            Console.WriteLine("| Bấm 5 để kiểm tra tồn kho.                   |");
            Console.WriteLine("| Bấm 6 để so sánh thang leo cùng phân khúc.   |");
            Console.WriteLine("| Bấm 0 để thoát khỏi chương trình.            |");
            Console.WriteLine("|______________________________________________|\n");
            string kt=Console.ReadLine()!;
            if (String.Compare(kt,"0",true)==0) break;
            else switch (kt) {
                case "1":
                    Console.Write("Nhập mã thang mới: ");
                    string ma=Console.ReadLine()!;
                    if (Thangleo.findThangbyMa(ma)!=null) {
                        Console.WriteLine("Mã thang đã tồn tại.");
                    }
                    else {
                        Console.Write("Loại thang: ");
                        string loai=Console.ReadLine()!;
                        Console.Write("Chiều cao thang: ");
                        string cao=Console.ReadLine()!+"m";
                        Console.Write("Số lượng thang: ");
                        string luong=Console.ReadLine()!;
                        Console.Write("Giá bán thang: ");
                        string gia=Console.ReadLine()!;
                        Thangleo thang=new Thangleo(ma,loai,cao,luong,gia);
                        Thangleo.dsThang.Add(thang);
                        Console.WriteLine("Đã thêm 1 thang.");
                    }break;
                case "2":
                    Thangleo.exportThang();break;
                case "3":
                    Console.Write("Chiều cao thấp nhất: ");
                    int ghduoi=Convert.ToInt32(Console.ReadLine()!);
                    Console.Write("Chiều cao cao nhất: ");
                    int ghtren=Convert.ToInt32(Console.ReadLine()!);
                    Thangleo.findThangbyHeight(ghduoi,ghtren);break;
                case "4":
                    Thangleo.sortThangbyPrice();
                    Console.WriteLine("Đã sắp xếp danh sách thang theo giá bán.");break;
                case "5":
                    Console.Write("Mã thang muốn kiểm tra: ");
                    string makt=Console.ReadLine()!;
                    Console.Write("Số lượng thang cần mua: ");
                    int need=Convert.ToInt32(Console.ReadLine()!);
                    Thangleo.checkAccessibility(makt,need);break;
                case "6":
                    Console.Write("Loại thang muốn so sánh: ");
                    string loaiss=Console.ReadLine()!;
                    Console.Write("Chiều cao muốn so sánh: ");
                    int caoss=Convert.ToInt32(Console.ReadLine()!);
                    Thangleo.compareThang(loaiss,caoss);break;
                default: break;
            }
            Console.Write("Bấm phím bất kỳ để tiếp tục.");
            Console.ReadKey();
        }
    }
}
//1. Cho thuê xe ô tô tự lái***
/* khách hàng thuê xe phải làm hợp đồng
Mỗi hợp đồng chỉ được thuê 1 xe và do 1 nhân viên quản lý*/
//2. Cho thuê căn hộ
//3. Bài toán bán hàng ở siêu thị***
//4. Đăng ký tuyển sinh đại học