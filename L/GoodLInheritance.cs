using System;
using System.Collections.Generic;

namespace L_D.L_Inheritance
{
    public abstract class Soldier
    {
        public string Name { get; set; }

        public void Report()
        {
            Console.WriteLine($"{Name} reporting for duty.");
        }

        public abstract string GetRole();
    }

    public abstract class CombatSoldierBase : Soldier
    {
        public abstract void Shoot();
    }

    public class Infantry : CombatSoldierBase
    {
        public override void Shoot()
        {
            Console.WriteLine($"{Name} fires rifle.");
        }

        public override string GetRole() => "Infantry";
    }

    public class Sniper : CombatSoldierBase
    {
        public override void Shoot()
        {
            Console.WriteLine($"{Name} fires a sniper round.");
        }

        public override string GetRole() => "Sniper";
    }

    public class TeacherSoldier : Soldier
    {
        public override string GetRole() => "Tactical Instructor";

        public void Teach()
        {
            Console.WriteLine($"{Name} is conducting tactical training.");
        }
    }

    public class ShootingRange
    {
        public void RunShootingRange(List<CombatSoldierBase> combatants)
        {
            foreach (var soldier in combatants)
            {
                Console.WriteLine($"{soldier.GetRole()}:");
                soldier.Shoot();
            }
        }
    }

    internal class GoodL_Inheritance
    {
        public void Run()
        {
            var range = new ShootingRange();
            var fighters = new List<CombatSoldierBase>
            {
                new Infantry { Name = "Dani" },
                new Sniper { Name = "Ari" }
            };

            range.RunShootingRange(fighters);

            var instructor = new TeacherSoldier { Name = "Naomi" };
            instructor.Report();
            instructor.Teach();
        }
    }
}
