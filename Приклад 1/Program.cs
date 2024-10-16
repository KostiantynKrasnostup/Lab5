using System;

namespace ConsoleApp19
{
    interface Operations<T>
    {
        
        double Add(T var1, T var2);
        double Sub(T var1, T var2);
    }

    
    class MyClass<T> : Operations<T>
    {
        public double Add(T var1, T var2)
        {
            double res = Convert.ToDouble(var1) + Convert.ToDouble(var2);
            return res;
        }

        public double Sub(T var1, T var2)
        {
            double res = Convert.ToDouble(var1) - Convert.ToDouble(var2);
            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            MyClass<int> mc1 = new MyClass<int>();
            double res1 = mc1.Add(23, 48);
            Console.WriteLine("res1 = {0}", res1);

            MyClass<float> mc2 = new MyClass<float>();
            double res2 = mc2.Sub(8.804f, 1.704f);
            Console.WriteLine("res2 = {0:f}", res2);

            Console.ReadKey();
        }
    }
}
