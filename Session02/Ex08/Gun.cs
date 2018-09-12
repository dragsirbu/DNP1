using System;

namespace Ex08
{
    class Gun
    {
        static int gunCount;
        static int bulletCount;
        int shotsFired;

        public Gun()
        {
            gunCount++;
            bulletCount = 0;
            shotsFired = 0;
        }

        public void Shoot()
        {
            Console.WriteLine("BANG!");
            bulletCount++;
            shotsFired++;
        }

        public int GunCount
        {
            get {return gunCount; }
        }

        public int BulletCount
        {
            get { return bulletCount; }
        }

        public int ShotsFired
        {
            get { return shotsFired; }
        }
    }
}