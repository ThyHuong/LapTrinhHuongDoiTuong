using System;
int n,m,i,j;
Console.Write("Nhap n: ");
n= Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap m: ");
m= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A=");
for (i=1; i<=n; i++)
{
    Random rand = new Random();
    //int a = rand.Next(1,100);
    //Console.WriteLine("Gio [{0}]: {1}", i, a);
    for (j=1; j<=m; j++)
    {
        int a = rand.Next(10);
        Console.Write("{0} ",a);
    }
    Console.WriteLine();
}