using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Sum " + add(2, 2));
        }

        public static int add(int i, int j) {
            return (i + j);
        }
    }
}
