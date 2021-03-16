using System;

namespace Heist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(int Bank)
        {
            int beatenGuard = Bank - SkillLevel;
            Console.WriteLine($"{Name} is beating up the security guards. Decreased security {SkillLevel} points");
            if (beatenGuard <= 0)
            {
                Console.WriteLine($"{Name} has whooped the guards!");
            }
        }
    }
}