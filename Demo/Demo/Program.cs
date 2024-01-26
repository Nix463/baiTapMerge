using System.Net.Security;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            
            Console.Write("Nhap mot so nguyen: ");
            int y = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Phuong trinh");
            int A = x * x + y * y;
            Console.WriteLine(A);
            
        }
    }
}