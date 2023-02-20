interface Istatus {
    void Xuat();
}
class Mayquat : Istatus {
    protected bool x=true;
    public Mayquat(bool x) {
        this.x=x;
    }
    public void status() {
        if (x) {x=false;} else {x=true;}
    }
    public void Xuat() {
        string kt;
        if (x) {kt="ON";} else {kt="OFF";}
        Console.WriteLine("May quat dang o trang thai {0}.",kt);
    }
}
class Dieuhoa : Istatus {
    protected bool x=true;
    public Dieuhoa(bool x) {
        this.x=x;
    }
    public void status() {
        if (x) {x=false;} else {x=true;}
    }
    public void Xuat() {
        string kt;
        if (x) {kt="ON";} else {kt="OFF";}
        Console.WriteLine("Dieu hoa dang o trang thai {0}.",kt);
    }
}
class Tivi : Istatus {
    protected bool x=true;
    public Tivi(bool x) {
        this.x=x;
    }
    public void status() {
        if (x) {x=false;} else {x=true;}
    }
    public void Xuat() {
        string kt;
        if (x) {kt="ON";} else {kt="OFF";}
        Console.WriteLine("Tivi dang o trang thai {0}.",kt);
    }
}
class Program {
    static void Main(string[] args) {
        Mayquat mq=new Mayquat(true);
        Dieuhoa dh=new Dieuhoa(false);
        Tivi tv=new Tivi(false);
        tv.status();
        mq.Xuat();
        dh.Xuat();
        tv.Xuat();
    }
}