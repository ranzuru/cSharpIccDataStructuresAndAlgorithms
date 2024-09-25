using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIccDataStructuresAndAlgorithms
{
    class ArrayClass
    {
        static Device[] devices = new Device[5];
        static int deviceCount = 0;

        public static void Main()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("\nDevice Management System");
                Console.WriteLine("[1] Insert");
                Console.WriteLine("[2] Search");
                Console.WriteLine("[3] Delete");
                Console.WriteLine("[4] View");
                Console.WriteLine("[0] Exit");
                Console.Write("Option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        insetDeviceEntry();
                        break;
                    case "2":
                        searchDeviceEntry();
                        break;
                    case "3":
                        deleteDeviceEntry();
                        break;
                    case "4":
                        displayDevice();
                        break;
                    case "0":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void insetDeviceEntry()
        {
            Console.WriteLine("\nDevice Information Entry");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Type: ");
            string type = Console.ReadLine();
            Console.Write("Grade: ");
            string grade = Console.ReadLine();

            Device device = new Device(name, type, grade);
            insertDeviceArray(device);
        }
        static void insertDeviceArray(Device device)
        {
            Console.WriteLine("\nInserted Device Information");
            if (deviceCount < devices.Length)
            {
                devices[deviceCount] = device;
                deviceCount++;
                
                Console.WriteLine("Name: " + device.name);
            }
            else Console.WriteLine("\nArray Full");
        }

        static void displayDevice()
        {
            Console.WriteLine("\nDevice Information List");
            for (int i = 0; i < deviceCount; i++)
            {
                devices[i].deviceFullDetails();
            }
        }
        static void searchDeviceEntry()
        {
            Console.WriteLine("\nDevice Search Entry");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Device foundDevice = searchDeviceArray(name);

            if (foundDevice != null)
            {
                Console.WriteLine("\nDevice Information");
                foundDevice.deviceFullDetails();
            }
            else Console.WriteLine("Not Found.");
        }
        static Device searchDeviceArray(string name)
        {
            for (int i = 0; i < deviceCount; i++)
            {
                if (devices[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return devices[i];
                }
            }
            return null;
        }

        static void deleteDeviceEntry()
        {
            Console.WriteLine("\nDevice Deletion Entry");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            deleteDeviceArray(name);
        }
        static void deleteDeviceArray(string name)
        {
            for (int i = 0; i < deviceCount; i++)
            {
                if (devices[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < deviceCount - 1; j++)
                    {
                        devices[j] = devices[j + 1];
                    }
                    devices[deviceCount - 1] = null;
                    deviceCount--;
                    Console.WriteLine("\nDeleted Device");
                    Console.WriteLine("Name: " + name);
                    return;
                }
            }
            Console.WriteLine("Not Found.");
        }
    }

    class Device
    {
        public string name { get; set; }
        public string type { get; set; }
        public string grade { get; set; }

        public Device(string name, string type, string grade)
        {
            this.name = name;
            this.type = type;
            this.grade = grade;
        }

        public void deviceFullDetails()
        {
            Console.WriteLine("\nName : " + name);
            Console.WriteLine("Type : " + type);
            Console.WriteLine("Grade: " + grade);
        }
    }
}