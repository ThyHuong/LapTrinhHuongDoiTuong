using System;
namespace b3 {
    class Program {
        static int n;
        static float[] A;
        static void Main(string[] args) {
            Console.Write("n=");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A=");
            A=new float[n];
            A[0]=float.Parse(Console.ReadLine());
            float min=A[0],max=A[0],tong=0,tich=1;
            if (A[0]<0) tong=tong-A[0];
            for (int i=1;i<n;i++) {
                A[i]=float.Parse(Console.ReadLine());
                if (A[i]>max) max=A[i];
                else if (A[i]<min) min=A[i];
                if (A[i]<0) tong=tong-A[i];
            }
            int k=-1;
            for (int i=0;i<n;i++) {
                if (k==0) tich=tich*A[i];
                if ((A[i]==min)||(A[i]==max)) k=k+1;
                if (k==1) {
                    tich=tich/A[i];
                    break;
                }
            }
            Console.WriteLine("Tong = {0}\nTich = {1}",tong,tich);
            Sort(A);
            ChanLe();
        }
        static void Sort(float[] B) {
            for (int i=0;i<n-1;i++) {
                for (int j=i+1;j<n;j++) {
                    if (B[j]<B[i]) {
                        B[j]=B[j]+B[i];
                        B[i]=B[j]-B[i];
                        B[j]=B[j]-B[i];
                    }
                }
            }
            Console.Write("A_tang = [{0}",B[0]);
            for (int i=1;i<n;i++) {
                Console.Write(", {0}",B[i]);
            }
            Console.WriteLine("]");
        }
        static void ChanLe() {
            int i=0,j=n-1;
            int[] C=new int[n];
            for (int k=0;k<n;k++) C[k]= (int)A[k];
            while (i<j) {
                while (C[i]%2==0) i++;
                while (C[j]%2!=0) j--;
                if (i<j) {
                    C[i]=C[i]+C[j];
                    C[j]=C[i]-C[j];
                    C[i]=C[i]-C[j];
                }
            }
            Console.Write("A_biendoi = [{0}",C[0]);
            for (int k=1;k<n;k++) {
                Console.Write(", {0}",C[k]);
            }
            Console.WriteLine("]");
        }
    }
}