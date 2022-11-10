using System;

namespace ConsoleApp2
{
    //Создание Enum
    public enum AccountType
    {
        Main,
        Deposit,
        Credit
    }
    //Создание обьекта Account
    public struct Account
    {
        public Guid Id { get; set; }
        public long Number { get; set; }
        public AccountType Type { get; set; }
        public decimal Total { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Создание экземпляра Account, и присвоение значений.
            Account test = new Account() { Id = Guid.NewGuid(), Number = 49751234095, Type = AccountType.Deposit, Total = 2412 };
            //Вывод
            Console.WriteLine($"Id - {test.Id};\nNumber - {test.Number};\nType - {test.Type};\nTotal - {test.Total};");
            Console.ReadKey();
        }
    }
}
