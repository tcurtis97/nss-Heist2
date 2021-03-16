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
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security {SkillLevel} points");
            if (hackedAlarm <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}