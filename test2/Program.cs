using System;

namespace test2
{
    internal class Program
    {
        class ElectronicDevice
        {
            private string brandName;
            private bool isOn;

            public string BrandName
            {
                get => brandName;
                set => brandName = value;
            }

            public virtual void SwitchOn()
            {
                Console.WriteLine("On");
                isOn = true;
            }

            public virtual void SwitchOff()
            {
                Console.WriteLine("Off");
                isOn = false;
            }

            public ElectronicDevice(string brandName, bool isOn)
            {
                this.brandName = "brandName";
                this.isOn = false;
            }

            public ElectronicDevice()
            {
                brandName = "unknown";
                isOn = false;
            }
        }

        class Radio:ElectronicDevice
        {
            private double currentFrequency;
            public Radio()
            {
                BrandName = "radio";
                currentFrequency = 0.01;
            }

            public Radio(double currentFrequency)
            {
                this.currentFrequency = currentFrequency;
                BrandName = "radio";
                Console.WriteLine(this.currentFrequency);
            }

            public override void SwitchOn()
            {
                base.SwitchOn();
                Console.WriteLine("brand name is {0}",BrandName);
            }
        }

        class Computer:ElectronicDevice
        {
            private int internalMemory;
            public Computer()
            {
                BrandName = "radio";
                internalMemory = 256;
            }

            public Computer(int internalMemory)
            {
                this.internalMemory = internalMemory;
                BrandName = "radio";
            }

            public override void SwitchOn()
            {
                base.SwitchOn();
                Console.WriteLine("brand name is {0}",BrandName);
            }
        }

        class LaptopComputer:Computer
        {
            private uint maxBatteriLife;

            public LaptopComputer()
            {
                BrandName = "Laptop";
                maxBatteriLife = 100;
                Console.WriteLine("{0},{1}",BrandName,maxBatteriLife);
            }
        }
        public static void Main(string[] args)
        {
            Radio radio = new Radio(0.109);
            radio.SwitchOn();
            LaptopComputer laptopComputer = new LaptopComputer();
        }
    }
}