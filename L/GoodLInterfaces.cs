using System;
using System.Collections.Generic;

namespace L_D.L
{
    public interface ICombatUnit
    {
        void Shoot();
        string GetRole();
    }

    public abstract class Soldier
    {
        public string Name { get; set; }

        public void Report()
        {
            Console.WriteLine($"{Name} reporting for duty.");
        }
    }

    public class CombatSoldier : Soldier, ICombatUnit
    {
        public void Shoot()
        {
            Console.WriteLine($"{Name} shoots the enemy.");
        }

        public string GetRole() => "Combat Soldier";
    }

    public class Sniper : Soldier, ICombatUnit
    {
        public void Shoot()
        {
            Console.WriteLine($"{Name} takes a precise shot from long range.");
        }

        public string GetRole() => "Sniper";
    }

    public class TeacherSoldier : Soldier
    {
        public void Teach()
        {
            Console.WriteLine($"{Name} teaches tactical theory.");
        }
    }

    public class ShootingRange
    {
        public void RunShootingRange(List<ICombatUnit> soldierList)
        {
            foreach (ICombatUnit s in soldierList)
            {
                Console.WriteLine($"{s.GetRole()}:");
                s.Shoot();
            }
        }
    }

    internal class GoodL
    {
        public void RunGoodL()
        {
            var range = new ShootingRange();
            var soldiers = new List<ICombatUnit>
            {
                new CombatSoldier { Name = "Ari" },
                new Sniper { Name = "Miki" }
            };

            range.RunShootingRange(soldiers);

            TeacherSoldier teacher = new TeacherSoldier { Name = "Avi" };
            teacher.Report();
            teacher.Teach();
        }
    }
}
