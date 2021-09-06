using System;

namespace Job2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "23456789ABCDEFGHIJK";
            char[] ch = str.ToCharArray();
            string vivod = "";
            Console.WriteLine("Введите число");
            int des = Convert.ToInt32(Console.ReadLine());
            if (des > 18)
            {
                for (int i = 0; i < des / 18; i++)
                {
                    vivod = vivod + "K";
                }
                if (des % 18 != 0) vivod = vivod + ch[des % 18 - 1];
            }
            else vivod = Convert.ToString(ch[des]);
            Console.WriteLine(vivod);
        }
    }
}
