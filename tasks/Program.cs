//Задание: Ханойские башни
namespace task_1
{
    internal class Program
    {
        static ulong Hanoy(ulong n, char a, char b, char c)
        {
            ulong num = 0;
            if (n != 1)
            {
                num = Hanoy(n-1, a, c, b);
                //Console.WriteLine($"Take from {a} and place to {c}");
                num++;
                num += Hanoy(n-1, b, a, c);
                //Console.WriteLine(num);
            }
            return num;
        }
        static void Main(string[] args)
        {
            char A = 'A', B = 'B', C = 'C';

            Console.Write("Ring count: ");
            ulong k = Convert.ToUInt64(Console.ReadLine());

            ulong res = Hanoy(k, A, B, C);
            Console.WriteLine("Replacement count: " + res);
        }
    }
}