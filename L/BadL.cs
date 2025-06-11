using System;
using System.Collections.Generic;

namespace L_D
{
    public abstract class Soldier
    {
        public abstract string soldierType { get; }
        public abstract string Shoot();
    }

    public class TankSoldier : Soldier
    {
        public override string soldierType => "tank soldier";
        public override string Shoot()
        {
            return "BANG!!!";
        }
    }

    public class FootSoldier : Soldier
    {
        public override string soldierType => "foot soldier";
        public override string Shoot()
        {
            return "bang!";
        }
    }

    public class Sniper : Soldier
    {
        public override string soldierType => "sniper";
        public override string Shoot()
        {
            return "aiming.... bang!";
        }
    }

    public class TeacherSoldier : Soldier
    {
        public override string soldierType => "teacher soldier";
        public override string Shoot()
        {
            return "Can I offer you some penciles?";
        }
    }

    public class ShootingRange
    {
        public void RunShootingRange(List<Soldier> soldierList)
        {
            foreach (Soldier s in soldierList)
            {
                Console.WriteLine($"{s.soldierType}: {s.Shoot()}");
            }
        }
    }



    public class BadL
    {
        public void runBadBL()
        {
            List<Soldier> soldierList = new List<Soldier> {
                new FootSoldier(),
                new TankSoldier(),
                new Sniper(),
                // but what happens if we add a soldier that cannot
                // shoot?
                new TeacherSoldier()

            };
            ShootingRange sr = new ShootingRange();
            sr.RunShootingRange(soldierList);
        }
    }
}
