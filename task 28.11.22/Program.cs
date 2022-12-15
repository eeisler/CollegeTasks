namespace task_28._11._22
{
    internal class Program
    {
        /*
        1.
        объявите переменную типа double
        в начало памяти, выделенной переменной запишите числа 1 и 2 
        в оставшуюся память запишите символы. (необходимо опеределить сколько символов можно записать)
        */

        unsafe static void Main(string[] args)
        {
            double a;
            void* pnt = &a;

            byte* b = (byte*)pnt;

            *b = 1;
            Console.WriteLine($"адрес указателя {(ulong)b}\n" + $"значение в ячейке {*b}");

            b++;
            *b = 2;
            Console.WriteLine($"адрес указателя {(ulong)b}\n" + $"значение в ячейке {*b}");

            char* pEND = (char*)pnt + 8 - 1;

            while (pEND > b)
            {
                *pEND = '^';
                pEND--;
            }

            Console.WriteLine(a);

            char* q = (char*)pnt;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(q[i]);
            }
        }
    }
}