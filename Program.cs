using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            Customer customer1 = new Customer("Денис", 2);
            Customer customer2 = new Customer("Полина", 3);
            Customer customer3 = new Customer("Антон", 6);
            Customer customer4 = new Customer("Юлия", 11);
            Customer customer5 = new Customer("Роман", 51);
            Customer customer6 = new Customer("Наталья", 5);

            factory.customers.Add(customer1);
            factory.customers.Add(customer2);
            factory.customers.Add(customer3);
            factory.customers.Add(customer4);
            factory.customers.Add(customer5);
            factory.customers.Add(customer6);

            GentleSmartphone gentleSmartphone1 = new GentleSmartphone { SeriaNumber = 1, sensor = new TactileSensor { Sensitivity = 18 } };
            GentleSmartphone gentleSmartphone2 = new GentleSmartphone { SeriaNumber = 2, sensor = new TactileSensor { Sensitivity = 18 } };
            GentleSmartphone gentleSmartphone3 = new GentleSmartphone { SeriaNumber = 3, sensor = new TactileSensor { Sensitivity = 20 } };
            GentleSmartphone gentleSmartphone4 = new GentleSmartphone { SeriaNumber = 4, sensor = new TactileSensor { Sensitivity = 20 } };
            GentleSmartphone gentleSmartphone5 = new GentleSmartphone { SeriaNumber = 5, sensor = new TactileSensor { Sensitivity = 2 } };
            GentleSmartphone gentleSmartphone6 = new GentleSmartphone { SeriaNumber = 6, sensor = new TactileSensor { Sensitivity = 2 } };
            GentleSmartphone gentleSmartphone7 = new GentleSmartphone { SeriaNumber = 7, sensor = new TactileSensor { Sensitivity = 2 } };

            factory.gentleSmartphone.Add(gentleSmartphone1);
            factory.gentleSmartphone.Add(gentleSmartphone2);
            factory.gentleSmartphone.Add(gentleSmartphone3);
            factory.gentleSmartphone.Add(gentleSmartphone4);
            factory.gentleSmartphone.Add(gentleSmartphone5);
            factory.gentleSmartphone.Add(gentleSmartphone6);
            factory.gentleSmartphone.Add(gentleSmartphone7);

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Смартфоны на складе:");
            foreach (var gentleSmartphone in factory.gentleSmartphone)
            {
                Console.WriteLine($"Смартфон: {gentleSmartphone.SeriaNumber}. Чувствительность смартфона: {gentleSmartphone.sensor.Sensitivity}.");
            }
            Console.WriteLine("Иформация о людях:");
            foreach (var customer in factory.customers)
            {
                Console.WriteLine($"Имя: {customer.FullName}. Уровень нежности: {customer.GentleRate}.");
            }
            Console.WriteLine("-----------------------------------------------------------------------------");

            factory.SaleSmartphone();
            Console.WriteLine("Иформация о людях:");
            foreach (var customer in factory.customers)
            {
                Console.WriteLine($"Имя: {customer.FullName}. Уровень нежности: {customer.GentleRate}.");
            }
            Console.WriteLine("-----------------------------------------------------------------------------");

            Console.WriteLine("Информация о телефонах");
            foreach (var customer in factory.customers)
            {
                if (customer.gentleSmartphone != null && customer.TransformatorModule == null)
                {
                    Console.WriteLine($"{customer.FullName} Уровень нeжности: {customer.GentleRate}. Модель Смартфона: {customer.gentleSmartphone.SeriaNumber}. " +
                        $"Чувствительность смартфона: {customer.gentleSmartphone.sensor.Sensitivity}.");
                }
                if (customer.gentleSmartphone != null && customer.TransformatorModule != null)
                {
                    Console.WriteLine($"{customer.FullName} Уровень нeжности: {customer.GentleRate}. Модель Смартфона: {customer.gentleSmartphone.SeriaNumber}. " +
                        $"Чувствительность смартфона: {customer.gentleSmartphone.sensor.Sensitivity}. Трансформатор: {customer.TransformatorModule.Type}.");
                }
            }
        }
    }
}
