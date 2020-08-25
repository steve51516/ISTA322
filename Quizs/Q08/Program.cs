using System;

namespace Q08
{
    class Program
    {
        static void Main(string[] args)
        {
            firearm shotgun = new firearm("12 Gauge", "Shotgun", "Boom");
            Console.WriteLine(shotgun.ToString());

            firearm rifle = new firearm("30-06", "Rifle", "Crack");
            Console.WriteLine(rifle.ToString());

            firearm pistol = new firearm(".45 ACP", "Pistol", "Bang");
            Console.WriteLine(pistol.ToString());

        }
    }
    class firearm
    {
        public string Caliber { get; set; }
        public string Name { get; set; }
        public string Sound { get; set; }
        static int count = 0;

        public firearm(string caliber, string name, string sound)
        {
            Caliber = caliber;
            Name = name;
            Sound = sound;
            count++;
        }

        public override string ToString()
        {
            string s = $"I'm a {Caliber} {Name} and I go {Sound}! We have {count} guns.";
            return s;
        }
    }
}
