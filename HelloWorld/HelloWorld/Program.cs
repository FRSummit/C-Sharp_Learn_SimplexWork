using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {

            Person person1 = new Person();
            person1.getName = "Robin";
            person1.getId = "0123";
            person1.getDob = "10 June, 2019";
            person1.getEmail = "email@email.com";
            person1.getAddress = "Dhaka";
            Console.WriteLine(person1.getName);
            Console.WriteLine(person1.getId);
            Console.WriteLine(person1.getDob);
            Console.WriteLine(person1.getEmail);
            Console.WriteLine(person1.getAddress);
        }

    }
}
