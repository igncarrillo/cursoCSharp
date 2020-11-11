using System;

namespace Proyecto25
{
    class A
    {
        public A()
        {
            Console.WriteLine("Soy la clase A");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("Soy la clase B");
        }
    }

    class C : B
        {
            public C()
            {
                Console.WriteLine("Soy la clase C");
            }
        }

    class Prueba
    {
        public static void Main(string[] args)
        {
            C objetoC = new C();
        }
    }
}