using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_D.DBad
{
    public class Soldier
    {
        public string Name { get; set; }

        public void Attack(Terrorist enemy)
        {
            Console.WriteLine($"{Name} attacks {enemy.Alias}!");
            enemy.TakeDamage(10);
        }
    }

    public class Terrorist
    {
        public string Alias { get; set; }
        public int Health { get; set; } = 100;

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Alias} took {amount} damage. Remaining health: {Health}");
        }
    }

    public class BattleArena
    {
        public void Fight()
        {
            var soldier = new Soldier { Name = "Elite" };
            var terrorist = new Terrorist { Alias = "Ghost" };

            soldier.Attack(terrorist);
        }
    }

    internal class BadD
    {
    }
}
