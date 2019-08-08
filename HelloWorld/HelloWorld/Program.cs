using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {

            try {
                String number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            } catch {
                Console.WriteLine("Can't convert to byte");
            }


            //Console.WriteLine("Sum " + add(2, 2));
        }

        //public static int add(int i, int j) {
        //    return (i + j);
        //}
    }
}
