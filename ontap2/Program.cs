class Apartment {
    protected static List<Apartment> Alist = new List<Apartment>();
    protected string ID="";
    protected float Area;
    protected int Floor;
    protected float Price=0;
    protected static int[] unitPrice = {4,5};
    public Apartment(string ID,float Area,int Floor) {
        this.ID=ID;
        this.Area=Area;
        this.Floor=Floor;
        Alist.Add(this);
    }
    protected void Print() {
        Console.WriteLine("Can ho {0} co dien tich {1:0.00} tang {2} co gia ban {3:0.00}.",this.ID,this.Area,this.Floor,this.Price);
    }
    static Apartment? findByPrice() {
        Apartment? r=default;
        foreach (Apartment a in Alist) {
            if (r==default) {r=a;}
            else {if (a.Price>r.Price) {r=a;}}
        }
        return r;
    }
    public static void getHighestPrice() {
        Console.WriteLine("Can ho co gia ban cao nhat:");
        findByPrice()!.Print();
    }
}
class Basic : Apartment {
    public Basic(string ID,float Area,int Floor) : base(ID,Area,Floor) {
        this.Price=unitPrice[0]*Area;
    }
}
class Condo : Apartment {
    string View;
    public Condo(string ID,float Area,int Floor,string View) : base(ID,Area,Floor) {
        this.View=View;
        this.Price=unitPrice[1]*getViewPrice(View)*Area;
    }
    static float getViewPrice(string View) {
        float r;
        switch (View) {
            case "Bien" : r=float.Parse("1.4");break;
            case "Ho boi" : r=float.Parse("1.1");break;
            case "Thanh pho" : r=float.Parse("1.2");break;
            default: r=1;break;
        }
        return r;
    }
}
class Program {
    static void Main(string[] args) {
        new Condo("C001",float.Parse("500"),3,"Bien");
        Apartment.getHighestPrice();
    }
}