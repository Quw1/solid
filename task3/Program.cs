using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
// Порушення якого принципу привело до невірного результату? Які шляхи вирішення?
// Порушено принцип розділення інтерфейсу - fixed
namespace task3
{
    interface IQuad
    {
        public int GetArea();
    }
    class Rectangle : IQuad
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public int GetArea()
        {
            return Width * Height;
        }
    }

    //квадрат наслідується від прямокутника!!!
    class Square : IQuad
    {
        public int Side { get; set; }

        public int GetArea()
        {
            return Side * Side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square rect = new Square();
            rect.Side = 5;
            rect.Side = 10;

            Console.WriteLine(rect.GetArea());
            // Відповідь 100 є правильною
            Console.ReadKey();
        }
    }
}