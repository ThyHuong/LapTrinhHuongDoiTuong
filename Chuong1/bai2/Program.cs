using System;
namespace b2 {
    class Program {
        static void Main(string[] args) {
            while (String.Compare(kt,"t",true)!=0) {
                Nhap();
                InKQ(Thuchien());
                Console.Write("Tiep tuc: ");
                kt=Console.ReadLine();
            }
        }
        static float a,b;
        static string toantu,kt="y";
        static void Nhap() {
            Console.Write("a=");
            a=float.Parse(Console.ReadLine());
            Console.Write("b=");
            b=float.Parse(Console.ReadLine());
            Console.Write("Toan tu:");
            toantu=Console.ReadLine();
        }
        static float Thuchien() {
            switch (toantu) {
                case "+": return(a+b);
                case "-": return(a-b);
                case "*": return(a*b);
                case "/": return(a/b);
                default: return(0);
            }
        }
        static void InKQ(float c) {
            Console.WriteLine("{0} {1} {2} = {3}",a,toantu,b,c);
        }
    }
}