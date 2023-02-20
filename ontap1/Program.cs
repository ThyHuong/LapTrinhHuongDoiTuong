class Customer {
    protected static List<Customer> cList = new List<Customer>();
    protected string Name;
    protected int Price=0;
    protected char DeoThe;
    public Customer(string Name) {
        this.Name=Name;
    }
    public static void Revenue() {
        int r=0,c=0;
        foreach (Customer x in cList) {
            r+=x.Price;
            c+=1;
        }
        Console.WriteLine("Tong doanh thu cua Asia Park sau khi co {0} khach tham quan: {1}",c,r);
    }
}
class Adult : Customer {
    protected string ID;
    public Adult(string Name,string ID) : base(Name) {
        this.ID=ID;
        this.Price=250;
        this.DeoThe='R';
        cList.Add(this);
    }
    public static void Nhap(ref string Name,ref string ID) {
        Console.Write("Ten khach hang: ");
        Name=Console.ReadLine()!;
        Console.Write("So CMND: ");
        ID=Console.ReadLine()!;
    }
}
class Child : Customer {
    protected float Height;
    public Child(string Name,float Height) : base(Name) {
        this.Height=Height;
        this.DeoThe='B';
        if (this.Height>1) {this.Price=130;}
        cList.Add(this);
    }
    public static void Nhap(ref string Name,ref float Height) {
        Console.Write("Ten khach hang: ");
        Name=Console.ReadLine()!;
        Console.Write("Chieu cao: ");
        Height=float.Parse(Console.ReadLine()!);
    }
}
class Program {
    static void Main(string[] args) {
        new Adult("Nguyen Van A","1234567890");
        new Adult("Tran Thi B","1234567891");
        new Adult("Huynh Van C","1234567892");
        new Child("Mai Thi D",float.Parse("1.35"));
        new Child("Hoang Van E",float.Parse("0.98"));
        new Child("Duong Thi F",float.Parse("1.60"));
        new Child("Le Van G",float.Parse("1.23"));
        new Child("Dang Thi H",float.Parse("0.86"));
        new Child("Chau Van I",float.Parse("1.55"));
        new Child("Truong Thi J",float.Parse("1.48"));
        Customer.Revenue();
    }
}