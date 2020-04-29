using lv4_analiza.components;
using System;
using System.Collections.Generic;

namespace lv4_analiza
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadatak1_2();
            Zadatak3();
            Zadatak4();
            Zadatak5();
            Zadatak6();
            Zadatak7();
        }

        static void Zadatak1_2()
        {
            string file = @"text.csv";
            Dataset data = new Dataset(file);
            Adapter adapter = new Adapter(new Analyzer3rdParty());
            double[] result = adapter.CalculateAveragePerColumn(data);
            Console.WriteLine(String.Join(" ", result));
        }

        static void Zadatak3()
        {
            List<IRentable> lista = new List<IRentable>();
            lista.Add(new Book("Power Thought"));
            lista.Add(new Video("How to be productive!"));
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(lista);
            printer.PrintTotalPrice(lista);
        }

        static void Zadatak4()
        {
            List<IRentable> ime = new List<IRentable>();
            ime.Add(new Book("Power Thought"));
            ime.Add(new Video("How to be productive!"));
            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(ime);
            printer.PrintTotalPrice(ime);

            IRentable hotbook = new Book("Harry Potter and...");
            IRentable hotvideo = new Video("Trending Spanish Song");

            ime.Add(new Hotitem(hotbook));
            ime.Add(new Hotitem(hotvideo));

            printer.DisplayItems(ime);
            printer.PrintTotalPrice(ime);
        }

        static void Zadatak5()
        {
            List<IRentable> lista1 = new List<IRentable>();

            lista1.Add(new Video("Video"));
            lista1.Add(new Book("Book"));

            List<IRentable> lista2 = new List<IRentable>();

            foreach(IRentable elem in lista1)
            {
                lista2.Add(new DiscountedItem(elem));
            }

            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(lista2);
            printer.PrintTotalPrice(lista2);
        }

        static void Zadatak6()
        {
            EmailValidator mailValidator = new EmailValidator();
            PasswordValidator pwValidator = new PasswordValidator(10);

            string testMail1 = "mihael@ferithr";
            string testMail2 = "mihaelferit.hr";
            string testMail3 = "mihael@ferit.hr";
            if (mailValidator.IsValidAddress(testMail1)) Console.WriteLine(testMail1 + " is valid"); 
            if (mailValidator.IsValidAddress(testMail2)) Console.WriteLine(testMail2 + " is valid");
            if (mailValidator.IsValidAddress(testMail3)) Console.WriteLine(testMail3 + " is valid");

            string testPw1 = "lozinka123";
            string testPw2 = "lozinka123";
            if (pwValidator.IsValidPassword(testPw1)) Console.WriteLine(testPw1 + " is valid");
            if (pwValidator.IsValidPassword(testPw2)) Console.WriteLine(testPw2 + " is valid");
        }

        static void Zadatak7()
        {
            UserEntry input = UserEntry.ReadUserFromConsole();
            FormValidator validator = new FormValidator(10);
            if (validator.IsUserEntryValid(input))
            {
                Console.WriteLine("Successfully logged in.");
            }
            else
            {
                Console.WriteLine("Log in failed.");
            }
        }
    }
}
