using System;
namespace Prime_Or_Not
{   
    public class Program
    {
        public void primeOrNot(int n)
        {
            int flag=0,c=0;
            if(n==1)
            {
                Console.WriteLine($"{n} is a Non-Prime Number\nFactor : {n}\nNumber of Factors : 1");
                return;
            }
            for(int i=2;i<=n/2;i++)
            {
                if(n%i==0)
                {
                    if(flag==0)
                    {
                        Console.Write($"******************\n{n} is a Non-Prime Number\nFactors : 1\t{i}\t");
                        flag=1;
                    }
                    else
                    {
                        Console.Write($"{i}\t");
                    }
                    c++;
                }
            }
            if(flag==1)
            {
                 Console.Write($"{n}\nNumber of Factors : {c+2}");
            }
            else
            {
                Console.Write($"******************\n{n} is a Prime Number");
            }  
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter the Number : ");
            int n = int.Parse(Console.ReadLine());
            Program p=new();
            p.primeOrNot(n);
        }
    }
}
