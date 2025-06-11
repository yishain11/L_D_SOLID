using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_D.DGood
{
    public interface ITarget
    {
        void TakeDamage(int amount);
        string GetIdentifier();
    }
    public class Terrorist : ITarget
    {
        public string Alias { get; set; }
        public int Health { get; set; } = 100;

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"{Alias} took {amount} damage. Remaining health: {Health}");
        }

        public string GetIdentifier()
        {
            return Alias;
        }
        public class Soldier
        {
            public string Name { get; set; }

            public void Attack(ITarget target)
            {
                Console.WriteLine($"{Name} attacks {target.GetIdentifier()}!");
                target.TakeDamage(10);
            }
        }
        public class BattleArena
        {
            public void Fight()
            {
                var soldier = new Soldier { Name = "Elite" };
                ITarget terrorist = new Terrorist { Alias = "Ghost" };

                soldier.Attack(terrorist);
            }
        }

    }


    internal class GoodD
    {
    }
}
