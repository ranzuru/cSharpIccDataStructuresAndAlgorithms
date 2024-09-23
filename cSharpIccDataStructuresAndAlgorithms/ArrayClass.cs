using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms
{
    class ArrayClass
    {
        public static void Main()
        {
            Device device1 = new Device("Root", "Computer", "Military");
            Device device2 = new Device("Samaritan", "Mobile", "Military");

            device1.introduction();
            device2.introduction();

            Owner owner1 = new Owner("Harold Finch");
            Owner owner2 = new Owner("John Greer");

            owner1.ownedDevice = device1; // sets the ownedDevice Attribute (from owner class) to device1
            owner2.ownedDevice = device2;

            owner1.ownedDevice.introduction();
            owner2.ownedDevice.introduction(); // shows the device2 since it is owned by owner2s
        }
    }

    class Device
    {
        public string name {  get; set; }
        public string type { get; set; }
        public string grade { get; set; }
        public Device(string name, string type, string grade)
        {
            this.name = name;
            this.type = type;
            this.grade = grade;
        }
        public void introduction()
        {
            Console.WriteLine("Device Information");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Type : " + type);
            Console.WriteLine("Grade: " + grade + "\n");
        }
    }

    class Owner
    {
        public string name { get; set; }
        public Device ownedDevice;
        public Owner(string name)
        {
            this.name = name;
        }
    }
}
