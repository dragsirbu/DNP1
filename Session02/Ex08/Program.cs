using System;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun1 = new Gun();
            Gun gun2 = new Gun();
            Gun gun3 = new Gun();
            gun1.Shoot();
            gun2.Shoot();
            gun3.Shoot();
            gun2.Shoot();
            gun3.Shoot();
            gun2.Shoot();
            gun1.Shoot();
            Console.WriteLine($"Gun1 -- Gun count: {gun1.GunCount}, Bullet Count: {gun1.BulletCount}, Shots Fired: {gun1.ShotsFired}");
            Console.WriteLine($"Gun2 -- Gun count: {gun2.GunCount}, Bullet Count: {gun2.BulletCount}, Shots Fired: {gun2.ShotsFired}");
            Console.WriteLine($"Gun3 -- Gun count: {gun3.GunCount}, Bullet Count: {gun3.BulletCount}, Shots Fired: {gun3.ShotsFired}");
            
        }
    }
}
