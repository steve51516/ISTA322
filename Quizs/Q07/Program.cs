using System;

namespace Q07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is CSharp Quiz07.");
            IFirearm shotgun = new Shotgun();
            shotgun.Shoot();

            IFirearm rifle = new Rifle();
            rifle.Shoot();

            IFirearm pistol = new Pistol();
            pistol.Shoot();
        }
    }
    interface IFirearm
    {
        void Shoot();
    }
    public class Shotgun : IFirearm
    {
        public void Shoot()
        {
            Console.WriteLine("I am a Shotgun and I go boom!");
        }
    }
    public class Rifle : IFirearm
    {
        public void Shoot()
        {
            Console.WriteLine("I am a Rifle and I go pow!");
        }
    }
    public class Pistol : IFirearm
    {
        public void Shoot()
        {
            Console.WriteLine("I am a Pistol and I go crack!");
        }
    }
}
