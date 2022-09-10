using System;
namespace b4 {
    class Program {
        static int n;
        static int[,] A;
        static void Main(string[] args) {
            n=Convert.ToInt32(Console.ReadLine());
            String s="";
            for (int d=0;d<n;d++) s=s+Console.ReadLine()+" ";
            int i=0,j=0;
            A=new int[n,n];
            for (int d=0;d<s.Length;d=d+2) {
                A[i,j]=Convert.ToInt32(s[d])-48;
                j++;
                if (j==n) {
                    j=0;
                    i++;
                }
            }
            bool[] B=new bool[n],C=new bool[n];
            int vt=0,tong,max=0,thang,thua;
            for (int f=0;f<n;f++) {
                tong=0;
                thang=0;
                thua=0;
                for (int g=0;g<n;g++) {
                    if (g==f) continue;
                    else {
                        tong=tong+A[f,g];
                        if (A[f,g]==3) thang++;
                        else if (A[f,g]==0) thua++;
                    }
                }
                if (tong>max) {
                    max=tong;
                    vt=f;
                }
                if (thang>thua) B[f]=true;
                else B[f]=false;
                if (thua!=0) C[f]=false;
                else C[f]=true;
            }
            Console.WriteLine(vt+1);
            for (int f=0;f<n;f++) {
                if (B[f]) Console.Write("{0} ",f+1);
            }
            Console.WriteLine();
            for (int f=0;f<n;f++) {
                if (C[f]) Console.Write("{0} ",f+1);
            }
            Console.WriteLine();
        }
    }
}