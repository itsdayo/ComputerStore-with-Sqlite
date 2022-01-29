using System;
using System.Collections.Generic;
namespace ComputerStore.Controllers
{
    public class Computer
    {
        public string type;
        public int memory;
        public double price;
        public string operatingSystem;
        public string processor;

        //constructor with operating system already assigned
        public Computer(string type, double price, int memory, string processor, string operatingSysem = "Windows")
        {
            this.type = type;
            this.memory = memory;
            this.price = price;
            this.processor = processor;
            this.operatingSystem = operatingSysem;
        }

        //constructor with processor already assignged
        public Computer(string type, double price, string operatingSystem, int memory, string processor = "Intel Core i7")
        {
            this.type = type;
            this.memory = memory;
            this.price = price;
            this.operatingSystem = operatingSystem;
            this.processor = processor;
        }
        //constructor with memory already assigned
        public Computer(string type, double price, string operatingSystem, string processor, int memory = 12)
        {
            this.type = type;
            this.memory = memory;
            this.price = price;
            this.operatingSystem = operatingSystem;
            this.processor = processor;
        }
        
    }

    class Program
    {


        public static List<Computer> GetComputers()
        {
            List<Computer> Inventory = new List<Computer>();
            Inventory.Add(new Computer("Desktop", 650.99, 10, "Intel Core i5"));
            Inventory.Add(new Computer("Laptop", 1299.00, "Linux", 16));
            Inventory.Add(new Computer("Desktop", 899.99, "Windows", "Intel Core i5"));
            Inventory.Add(new Computer("Desktop", 1500.00, "Windows", 16));
            Inventory.Add(new Computer("Laptop", 500.00, "Linux", "Intel Core i3"));
            Inventory.Add(new Computer("Laptop", 900.00, "MacOS", 8));
            Inventory.Add(new Computer("Desktop", 1100.99, "Unix", "Intel Core i7"));
            Inventory.Add(new Computer("Desktop", 650.99, 10, "Intel Core i5"));
            Inventory.Add(new Computer("Laptop", 1700.99, 8, "Intel Core i7"));
            return Inventory;
        }
       

        }
    }

