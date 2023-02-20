class Edition {
    protected string title,author;
    public Edition(string title,string author) {
        this.title=title;
        this.author=author;
    }
    public static void CompareTo(string key) {}
    public static bool Search(string author,bool r) {return r;}
    protected virtual void Xuat() {
        Console.Write("{0,-40} | {1,-25} | ",this.title,this.author);
    }
}
class Book : Edition {
    int year;
    string publisher;
    static protected List<Book> list=new List<Book>();
    public static new void CompareTo(string key) {
        if (key=="title") {
            list=list.OrderBy(x=>x.title).ToList();
        }
        else {
            list=list.OrderBy(x=>x.author).ToList();
        }
        foreach (Book x in list) {
            x.Xuat();
        }
    }
    public static new bool Search(string author,bool r) {
        foreach (Book x in list) {
            if (x.author==author) {
                Console.WriteLine("{0,-15} | {1,-40}","Book",x.title);
                r=true;
            }
        }
        return r;
    }
    public Book(string title,string author,int year,string publisher): base(title,author) {
        this.publisher=publisher;
        this.year=year;
        list.Add(this);
    }
    protected override void Xuat() {
        base.Xuat();
        Console.WriteLine("{0,4} | {1,-20}",this.year,this.publisher);
    }
}
class Article : Edition {
    int year;
    string journal;
    static protected List<Article> list=new List<Article>();
    public static new void CompareTo(string key) {
        if (key=="title") {
            list=list.OrderBy(x=>x.title).ToList();
        }
        else {
            list=list.OrderBy(x=>x.author).ToList();
        }
        foreach (Article x in list) {
            x.Xuat();
        }
    }
    public static new bool Search(string author,bool r) {
        foreach (Article x in list) {
            if (x.author==author) {
                Console.WriteLine("{0,-15} | {1,-40}","Article",x.title);
                r=true;
            }
        }
        return r;
    }
    public Article(string title,string author,string journal,int year): base(title,author) {
        this.journal=journal;
        this.year=year;
        list.Add(this);
    }
    protected override void Xuat() {
        base.Xuat();
        Console.WriteLine("{0,-20} | {1,4}",this.journal,this.year);
    }
}
class OnlineResource : Edition {
    string link,abs;
    static protected List<OnlineResource> list=new List<OnlineResource>();
    public static new void CompareTo(string key) {
        if (key=="title") {
            list=list.OrderBy(x=>x.title).ToList();
        }
        else {
            list=list.OrderBy(x=>x.author).ToList();
        }
        foreach (OnlineResource x in list) {
            x.Xuat();
        }
    }
    public static new bool Search(string author,bool r) {
        foreach (OnlineResource x in list) {
            if (x.author==author) {
                Console.WriteLine("{0,-15} | {1,-40}","Online Resource",x.title);
                r=true;
            }
        }
        return r;
    }
    public OnlineResource(string title,string author,string link,string abs): base(title,author) {
        this.link=link;
        this.abs=abs;
        list.Add(this);
    }
    protected override void Xuat() {
        base.Xuat();
        Console.WriteLine("{0,-40} | {1,-60}",this.link,this.abs);
    }
}
class Program {
    static void Main(string[] args) {
        new Book("Book1","Author1",1999,"Publisher1");
        new Book("Book2","Author3",2015,"Publisher2");
        new Article("Article1","Author2","Journal1",2005);
        new Article("Article2","Author1","Journal2",1995);
        new OnlineResource("OnlineResource1","Author3","https://link01.com/essay1","First essay's abstract.");
        new OnlineResource("OnlineResource2","Author2","www.link02.vn/essay02","Second essay's abstract.");
        while (true) {
            Console.WriteLine("\n ______________________________________________");
            Console.WriteLine("|                     __                       |");
            Console.WriteLine("|_____________|\\\\ /| ||_ |\\\\| || ||____________|");
            Console.WriteLine("|             ||\\//| ||_ ||\\| ||_||            |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("|  Bam 1 de them moi danh sach.                |");
            Console.WriteLine("|  Bam 2 de hien thi danh sach.                |");
            Console.WriteLine("|  Bam 3 de tim kiem an pham.                  |");
            Console.WriteLine("|  Bam 0 de thoat khoi chuong trinh.           |");
            Console.WriteLine("|______________________________________________|\n");
            string kt=Console.ReadLine()!;
            if (kt=="0") {break;}
            switch (kt) {
                case "1":
                    Console.Write("Loai an pham muon nhap: (B/A/OR) ");
                    string type=Console.ReadLine()!;
                    Console.Write("Ten an pham: ");
                    string title=Console.ReadLine()!;
                    Console.Write("Tac gia: ");
                    string author=Console.ReadLine()!;
                    switch (type) {
                        case "B":
                            Console.Write("Nam: ");
                            int year=Convert.ToInt32(Console.ReadLine()!);
                            Console.Write("Nha xuat ban: ");
                            string publisher=Console.ReadLine()!;
                            Book b=new Book(title,author,year,publisher);
                            break;
                        case "A":
                            Console.Write("Chu de: ");
                            string journal=Console.ReadLine()!;
                            Console.Write("Nam: ");
                            int nam=Convert.ToInt32(Console.ReadLine()!);
                            Article a=new Article(title,author,journal,nam);
                            break;
                        case "OR":    
                            Console.Write("Duong dan: ");
                            string link=Console.ReadLine()!;
                            Console.Write("Tom tat: ");
                            string abs=Console.ReadLine()!;
                            OnlineResource or=new OnlineResource(title,author,link,abs);
                            break;
                        default: break;
                    }
                    break;
                case "2":
                    Console.Write("Sap xep theo: (title/author)");
                    string key=Console.ReadLine()!;
                    Console.WriteLine("\n---BOOKS---");
                    Console.WriteLine("{0,-40} | {1,-25} | {2,4} | {3,-20}","Title","Author","Year","Publisher");
                    Book.CompareTo(key);
                    Console.WriteLine("\n---ARTICLES---");
                    Console.WriteLine("{0,-40} | {1,-25} | {2,-20} | {3,4}","Title","Author","Journal","Year");
                    Article.CompareTo(key);
                    Console.WriteLine("\n---ONLINE_RESOURCES---");
                    Console.WriteLine("{0,-40} | {1,-25} | {2,-40} | {3,-60}","Title","Author","Link","Abstract");
                    OnlineResource.CompareTo(key);
                    break;
                case "3":
                    Console.Write("Ten tac gia: ");
                    string search=Console.ReadLine()!;
                    Console.WriteLine("\n{0,-15} | {1,-40}","Type","Title");
                    if (OnlineResource.Search(search,Article.Search(search,Book.Search(search,false)))==false) {
                        Console.WriteLine("Khong tim thay an pham cua {0}.",search);
                    }
                    break;
                default: break;
            }
            Console.Write("Bam phim bat ky de tiep tuc.");
            Console.ReadKey();
        }
    }
}