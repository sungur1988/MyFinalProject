using FluentValidation;
using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(IMath);
            var tip = typeof(DortIslem);
            var dort = Activator.CreateInstance(tip);
           
            Console.WriteLine(tip.GetMembers());
            Console.WriteLine(tip);

            var methods = tip.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
                foreach (var item in method.GetCustomAttributes())
                {
                    Console.WriteLine(item.GetType().Name);
                }
            }
        }
    }
    public class DortIslem : IMath
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public DortIslem()
        {

        }
        [Cihan]
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
    }

    public interface IMath
    {
    }
    public class CihanAttribute : Attribute
    {

    }
}
